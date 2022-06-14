using HIKARI_HTO_VER2.LinqToSQLModels;
using HIKARI_HTO_VER2.LinqToSQLProcess;
using HIKARI_HTO_VER2.ModuleProcessUtil;
using HIKARI_HTO_VER2.ProcessUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIKARI_HTO_VER2.MyForm
{
    public partial class frm_Main : Form
    {
        string[] lstFunctionCheckDeSo = { "CHECK DESO" };
        using_Tb_Batch using_Tb_Batch;
        Ham_Chung dtl = new Ham_Chung();
        public frm_Main()
        {
            InitializeComponent();
            using_Tb_Batch =new using_Tb_Batch();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            if (Global.isAdminGroup)
            {
                cbb_Role.Items.Add(Constant.ADMIN);
            }
            if (Global.isCheckerVNGroup)
            {
                cbb_Role.Items.Add(Constant.CHECKDESO);
            }
            if (Global.isOperatorGroup)
            {
                cbb_Role.Items.Add(Constant.DESO);
            }
            if (Global.isLastCheck)
            {
                cbb_Role.Items.Add(Constant.LASTCHECK);
            }
            lb_UserName.Text = Global.strUsername;
            cbb_Role.SelectedIndex = 0;
            if (Global.isCheckerVNGroup || Global.isOperatorGroup)
            {
                LoadListBatchName();
            }           

            try
            {
                Thread t = new Thread(new ThreadStart(getListAutocompelet));
                t.Start();
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi luồng");
            }
        }
        private void LoadListBatchName()
        {
            cbb_batchname.DataSource = null;
            if (cbb_Role.Text == Constant.DESO)
            {
                var listResult = (from w in using_Tb_Batch.Get_ListBatch_Entry(Global.Level_Image,"0",Global.LevelUser.ToString(),Global.strUsername) select new { w.ID, w.BatchName, w.BatchType, w.ChiaUser }).ToList();
                cbb_batchname.DataSource = listResult;
                cbb_batchname.DisplayMember = "BatchName";
                cbb_batchname.ValueMember = "ID";
            }
            else if (cbb_Role.Text == Constant.CHECKDESO)
            {
                var List_check = (from w in using_Tb_Batch.Get_ListBatch_Checker_New0806(Global.Level_Image,"0") select new { w.ID, w.BatchName, w.BatchType, w.ChiaUser, w.Hit_E11 }).Where(x => x.Hit_E11 > 0).ToList();
                cbb_batchname.DataSource = List_check;
                cbb_batchname.DisplayMember = "BatchName";
                cbb_batchname.ValueMember = "ID";
            }
            else if (cbb_Role.Text == Constant.LASTCHECK)
            {
                var query = (from w in using_Tb_Batch.get_batch_LastCheck(Global.strUsername) select new { w.ID, w.BatchName }).ToList();
                cbb_batchname.DataSource = query;
                cbb_batchname.DisplayMember = "BatchName";
                cbb_batchname.ValueMember = "ID";
            }
        }
        public void getListAutocompelet()
        {
            using (HTO_DataStoreDataContext db = new HTO_DataStoreDataContext())
            {
                List<spDataAutocomplete_GetListAutoComplete_v2Result> listAutoCompelete = new List<spDataAutocomplete_GetListAutoComplete_v2Result>();
                listAutoCompelete = db.spDataAutocomplete_GetListAutoComplete_v2().ToList();
                AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                foreach (var item in listAutoCompelete)
                {
                    data.Add(item.MaSP);
                }
                Global.listAuto = data;
            };
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadListBatchName();
        }

        private void cbb_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_Function.Items.Clear();
            if (cbb_Role.Text == Constant.DESO)
            {
                lb_Funtion.Visible = false;
                cbb_Function.Visible = false;
            }
            else if (cbb_Role.Text == Constant.CHECKDESO)
            {
                cbb_Function.Items.AddRange(lstFunctionCheckDeSo);
                cbb_Function.SelectedIndex = 0;
                lb_Funtion.Visible = true;
                cbb_Function.Visible = true;
            }
            else if (cbb_Role.Text == Constant.LASTCHECK)
            {
                
            }
            LoadListBatchName();
        }

        private void btn_Continue_Click(object sender, EventArgs e)
        {
            if (cbb_batchname.Items.Count > 0)
            {
                Global.BatchNameSelected = cbb_batchname.Text;
                Global.BatchIDSelected = cbb_batchname.SelectedValue.ToString();
                Global.BatchTypeSelected = using_Tb_Batch.GetBatchType(Global.BatchIDSelected);
                Global.BatchChiaUser = using_Tb_Batch.Get_ChiaUser(Global.BatchIDSelected) == true ? 1 : 0;
            }

            if (Global.isAdminGroup && cbb_Role.Text == Constant.ADMIN)
            {
                frm_Admin frm = new frm_Admin();
                frm.ShowDialog();
            }
            else if (Global.isOperatorGroup && cbb_Role.Text == Constant.DESO)
            {
                if (cbb_batchname.Text == "")
                    if (MessageBox.Show("Không có batch nào được chọn. Bạn vẫn muốn tiếp tục?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                frm_Operator frMain = new frm_Operator();
                if (frMain.ShowDialog() == DialogResult.Yes)
                {
                    frMain.Close();
                }
            }
            else if (Global.isCheckerVNGroup && cbb_Role.Text == Constant.CHECKDESO)
            {
                if (cbb_batchname.Text == "")
                    if (MessageBox.Show("Không có batch nào được chọn. Bạn vẫn muốn tiếp tục?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                frm_Checker fCheck = new frm_Checker();
                fCheck.ShowDialog();
            }
            else if (Global.isCheckerVNGroup && cbb_Role.Text == Constant.LASTCHECK)
            {
                if (cbb_batchname.Text == "")
                    if (MessageBox.Show("Không có batch nào được chọn. Bạn vẫn muốn tiếp tục?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                frm_LastCheck fLastCheck = new frm_LastCheck();
                fLastCheck.ShowDialog();
            }
            // reload 
            LoadListBatchName();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbb_batchname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hikari_LoginDLL.Hikari_Login.updateToken(Global.ProjectCode, Global.strUsername, Global.Strtoken);
            if (DialogResult != DialogResult.None)
            {
                DialogResult = DialogResult.Yes;
            }
        }

        private void frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
