using HIKARI_HTO_VER2.LinqToSQLProcess;
using HIKARI_HTO_VER2.ModuleProcessUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIKARI_HTO_VER2.MyForm
{
    public partial class Admin_Status_Detail_Batch : Form
    {        
        int BatchID;
        string Info = "";
        string LoaiBatch = "";
        public Admin_Status_Detail_Batch(int ID_batch, string info, string Style_batch)
        {
            InitializeComponent();            
            BatchID = ID_batch; Info = info;
            LoaiBatch = Style_batch;
        }

        private void Admin_Status_Detail_Batch_Load(object sender, EventArgs e)
        {
            lb_hienthi.Text = Info;
            grd_Chitiet.DataSource = null;
            grd_Chitiet.DataSource = (from w in GlobalDB.DBLinq.Admin_Status_ViewChitiet_V2(BatchID)
                                      select new
                                      { w.ID, w.ImageName, w.Level_Image, w.Content_E1, w.UserName_E1, w.Content_E2, w.UserName_E2, w.Content_Check, w.UserName_Check, w.Content_LC }).OrderBy(x=>x.ImageName).ToList();
            
            //btn_BackCheck.Enabled = false;
        }

        private void grdV_Chitiet_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = (DevExpress.XtraGrid.Views.Grid.GridView)sender;
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void grdV_Chitiet_DoubleClick(object sender, EventArgs e)
        {
            if (grdV_Chitiet.FocusedRowHandle >= 0)
            {
                string nameImg = grdV_Chitiet.GetFocusedRowCellValue("ImageName").ToString();
                string Data1 = grdV_Chitiet.GetFocusedRowCellValue("Content_E1").ToString();
                string User1 = grdV_Chitiet.GetFocusedRowCellValue("UserName_E1").ToString();
                string Data2 = grdV_Chitiet.GetFocusedRowCellValue("Content_E2").ToString();
                string User2 = grdV_Chitiet.GetFocusedRowCellValue("UserName_E2").ToString();
                string Datacheck = grdV_Chitiet.GetFocusedRowCellValue("Content_Check").ToString();
                string DataLC = grdV_Chitiet.GetFocusedRowCellValue("Content_LC").ToString();
                string UserCheck = grdV_Chitiet.GetFocusedRowCellValue("UserName_Check").ToString();
                Admin_Status_Detail_Data_Image frm_chitietimg = new Admin_Status_Detail_Data_Image(LoaiBatch, nameImg, Data1, Data2, User1, User2, Datacheck, UserCheck, DataLC);
                frm_chitietimg.ShowDialog();
            }
        }

        private void btn_BackEntry_Click(object sender, EventArgs e)
        {

        }

        private void grdV_Chitiet_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //btn_BackCheck.Enabled = false;
            try
            {
                if (grdV_Chitiet.GetFocusedRowCellValue("Content_E2") != null && grdV_Chitiet.GetFocusedRowCellValue("Content_E1") != null)
                {
                    btn_BackCheck.Enabled = true;
                }
            }
            catch { }
        }

        private void btn_BackEntry_1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn trả ảnh này về Entry Level 1 xử lý lại ???","Question",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GlobalDB.DBLinq.Admin_return_Role_image_v2("E1", BatchID, Convert.ToInt32(grdV_Chitiet.GetFocusedRowCellValue("ID").ToString()), Global.Level_Image);
                Admin_Status_Detail_Batch_Load(null, null);
            }
            else { return; }
        }

        private void btn_BackEntry_2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn trả ảnh này về Entry Level 2 xử lý lại ???", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GlobalDB.DBLinq.Admin_return_Role_image_v2("E2", BatchID, Convert.ToInt32(grdV_Chitiet.GetFocusedRowCellValue("ID").ToString()), Global.Level_Image);
                Admin_Status_Detail_Batch_Load(null, null);
            }
            else { return; }
        }

        private void btn_BackCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn trả ảnh này về Checker xử lý lại ???", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GlobalDB.DBLinq.Admin_return_Role_image_v2("CHECK", BatchID, Convert.ToInt32(grdV_Chitiet.GetFocusedRowCellValue("ID")), Global.Level_Image);
                Admin_Status_Detail_Batch_Load(null, null);
            }
            else { return; }
        }

        private void btn_backImage_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn trả ảnh này về Entry xử lý lại ???", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GlobalDB.DBLinq.Admin_return_Role_image_v2("E1E2", BatchID, Convert.ToInt32(grdV_Chitiet.GetFocusedRowCellValue("ID").ToString()), Global.Level_Image);
                Admin_Status_Detail_Batch_Load(null, null);
            }
            else { return; }
        }

        private void btn_rt_batchLC_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thực hiện LC lại Bacth đang chọn ???", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GlobalDB.DBLinq.Admin_return_Role_image_v2("LC", BatchID, Convert.ToInt32(grdV_Chitiet.GetFocusedRowCellValue("ID").ToString()), Global.Level_Image);
                Admin_Status_Detail_Batch_Load(null, null);
            }
            else { return; }
        }
    }
}
