using HIKARI_HTO_VER2.LinqToSQLProcess;
using HIKARI_HTO_VER2.ModuleProcessUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIKARI_HTO_VER2.MyForm
{
    public partial class frm_Operator : Form
    {
        using_Tb_Batch using_Tb_Batch;
        using_Tb_Data using_Tb_Data;
        Entry_info Entry_info;
        public frm_Operator()
        {
            InitializeComponent();
            using_Tb_Batch = new using_Tb_Batch();
            using_Tb_Data = new using_Tb_Data();
            Entry_info = new Entry_info();
        }
         
        private void frm_Operator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Enter)
            {
                btn_Submit_Click(null, null);
                e.Handled = true;
            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.L)
            {
                btn_Submit_Logout_Click(null, null);
                e.Handled = true;
            }
            if (e.Control)
            {                
                if (e.KeyCode == Keys.F)
                {
                    ImgV.CurrentZoom = 1;
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.Right)
                {
                    try
                    { ImgV.RotateImage("270"); }
                    catch
                    { }
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.Left)
                {
                    try
                    { ImgV.RotateImage("90"); }
                    catch
                    { }
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.Up)
                {
                    ImgV.CurrentZoom = ImgV.CurrentZoom + 0.1f;                    
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.Down)
                {
                    ImgV.CurrentZoom = ImgV.CurrentZoom <= 0.1f ? 0.1f : ImgV.CurrentZoom - 0.1f;                    
                    e.Handled = true;
                }
            }
        }

        private void frm_Operator_Load(object sender, EventArgs e)
        {
            lb_UserName.Text = Global.strUsername;
            lb_fBatchName.Text = Global.BatchNameSelected;
            lb_City.Text = Global.BatchTypeSelected;
            btn_Submit_Logout.Enabled = false;
            lb_SoPhieuCon.Text = "";
            lb_SoPhieuNhap.Text = "";
            lb_TongPhieu.Text = "";
            lb_IdImage.Text = "";
            Entry_info.flZoom = 0;
        }


        private void btn_Submit_Click(object sender, EventArgs e)
        {
            //tránh click submit duble //////
            if (btn_Submit.Enabled == false)
                return;
            btn_Submit.Enabled = false;
            
            //if (ApplicationDeployment.IsNetworkDeployed)
            //{
            BackgroundWorker a = new BackgroundWorker();
            a.DoWork += delegate
            { Thread.Sleep(1700); btn_Submit.BeginInvoke(new Action(() => { btn_Submit.Enabled = true; })); };
            a.RunWorkerAsync();
            //Token
            if (!Global.checkTokenLogin())
            {
                MessageBox.Show("Bạn đã có phiên đăng nhập mới. Vui lòng đăng nhập lại", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.Yes;
                return;
            }
            ///////

            ///Start
            if (btn_Submit.Text == "Start")
            {
                lb_IdImage.Text = "";
                if (string.IsNullOrEmpty(Global.BatchIDSelected))
                {
                    MessageBox.Show("Vui lòng đăng nhập lại và chọn Batch!");
                    return;
                }
                startInput();
                btn_Submit_Logout.Enabled = true;
            }
            else //Submit
            {
                Entry_info.flZoom = ImgV.CurrentZoom;
                //kiem tra phieu trống:
                string kqsubmit = "";
                if (tabcontrol.SelectedTabPage.Name == "tab_AE")
                {
                    if (!uC_PhieuAE1.ConfirmEmptyWarning())
                    {
                        return;
                    }
                    kqsubmit = uC_PhieuAE1.Submit(Global.BatchIDSelected, Entry_info.ID_Getdata.ToString());
                }
                else if (tabcontrol.SelectedTabPage.Name == "tab_AT")
                {
                    if (!uC_PhieuAT1.ConfirmEmptyWarning())
                    {
                        return;
                    }
                    kqsubmit = uC_PhieuAT1.Submit(Global.BatchIDSelected, Entry_info.ID_Getdata.ToString());
                }

                if (kqsubmit == "3")
                {
                    ResetDataAllUC();
                    SetInformation();
                    startInput();
                }
                else if (kqsubmit == "1")
                {
                    MessageBox.Show("Không để trống trường 2  \n Vui lòng đọc QUY ĐỊNH và kiểm tra lại !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
                else if (kqsubmit == "2")
                {
                    MessageBox.Show("Trống thông tin ID Batch và Image. \n Vui lòng đọc QUY ĐỊNH và kiểm tra lại !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (kqsubmit == "4")
                {
                    MessageBox.Show("Batch đã tắt 'Chế độ Công Khai' .", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Entry_info.imageName = "";
                    this.Close();

                }
                else if (kqsubmit == "5")
                {
                    MessageBox.Show("Trường số 7 trống thông tin \n Vui lòng đọc QUY ĐỊNH và kiểm tra lại !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void SetInformation()
        {
            try
            {
                var a = using_Tb_Data.GetInforBatchForOperator(Global.BatchIDSelected, Global.Level_Image.ToString(),Global.LevelUser.ToString(),Global.strUsername, Global.BatchChiaUser.ToString());
                lb_SoPhieuCon.Text = a.Số_phiếu_còn + "";
                lb_SoPhieuNhap.Text = a.Số_phiếu_nhập + "";
                lb_TongPhieu.Text = a.Tổng_số_phiếu + "";
            }
            catch (Exception)
            {
            }
        }
        private void ResetDataAllUC()
        {
            uC_PhieuAE1.ClearAllText();
            uC_PhieuAT1.ClearAllText();
        }
        private void startInput()
        {
            if (Global.BatchTypeSelected == "AE")
            {
                lb_quyDinh.Text = Global.RegulationAE;
            }
            else if (Global.BatchTypeSelected == "AT")
            {
                lb_quyDinh.Text = Global.RegulationAT;

            }
            //GetImage. trường hợp hình bõ lỡ cần nhập lại thì đã tích hợp trong store getiamge ở database
            string kq = GetImageAndShow();
            if (kq == "NULL")//hết hình
            {
                MessageBox.Show(@"Hoàn thành batch '" + lb_fBatchName.Text + "'");
                NhapBatchTiepTheo();
            }
            else if (kq == "OK")
            {
                ResetDataAllUC();
                SetInformation();
                btn_Submit.Text = "Submit";
                btn_Submit_Logout.Enabled = true;
                btn_Submit_Logout.Visible = true;
                if (Global.BatchTypeSelected == "AE")
                {
                    tab_AE.PageVisible = true;
                    tabcontrol.SelectedTabPage = tab_AE;
                    uC_PhieuAE1.FocusUC();
                    tab_AT.PageVisible = false;

                }
                else
                {
                    tab_AT.PageVisible = true;
                    tabcontrol.SelectedTabPage = tab_AT;
                    uC_PhieuAT1.FocusUC();
                    tab_AE.PageVisible = false;
                }
            }
            else if (kq == "ERROR")
            {
                MessageBox.Show("Không thể load hình!");
                this.Close();
            }
        }
        void NhapBatchTiepTheo()
        {            
            Global.BatchNameSelected = "";
            Global.BatchTypeSelected = "";
            lb_IdImage.Text = "";
            lb_fBatchName.Text = "";

            var listResult = (from w in using_Tb_Batch.Get_ListBatch_Entry(Global.Level_Image, Global.BatchIDSelected, Global.LevelUser.ToString(), Global.strUsername) select new { w.ID, w.BatchName, w.BatchType }).ToList();

            if (listResult.Count > 0)
            {
                if (MessageBox.Show("Bạn có muốn làm batch tiếp theo không?\r\nBatch: " + listResult[0].BatchName, "Hoàn thành Batch!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //Check outsource
                    Global.BatchIDSelected = listResult[0].ID.ToString();
                    Global.BatchNameSelected = listResult[0].BatchName;
                    Global.BatchTypeSelected = listResult[0].BatchType;
                    lb_fBatchName.Text = Global.BatchNameSelected;
                    lb_City.Text = listResult[0].BatchType;
                    startInput();
                }
                else
                {
                    Entry_info.imageName = "";
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Hoàn thành tất cả các Batch.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Entry_info.imageName = "";
                this.Close();
            }
        }
        public string GetImageAndShow()
        {
            lb_IdImage.Text = "";
            DataTable dt_info_img = new DataTable();
            if (Global.isOperatorGroup)
            {                
                try
                {
                    DataSet ds = new DataSet();
                    SqlConnection con = new SqlConnection(Global.ConnectionString);
                    SqlCommand cmd = new SqlCommand("spImage_GetImage_Input_Entry_v2", con);
                    cmd.CommandTimeout = 10 * 60;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BatchID", Global.BatchIDSelected.ToString());
                    cmd.Parameters.AddWithValue("@User", Global.strUsername);
                    cmd.Parameters.AddWithValue("@LevelUser", Global.LevelUser);
                    cmd.Parameters.AddWithValue("@ChiaUser", Global.BatchChiaUser);
                    cmd.Parameters.AddWithValue("@Level_Image", Global.Level_Image.ToString());
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    dt_info_img = ds.Tables[0];
                }
                catch (Exception exx)
                {
                    MessageBox.Show(exx.ToString());
                    return "ERROR";
                }
                if (dt_info_img.Rows.Count > 0)
                {
                    Entry_info.imageName = dt_info_img.Rows[0]["Name_Img"].ToString();
                    Entry_info.ID_Getdata = Convert.ToInt32(dt_info_img.Rows[0]["ID"].ToString());
                    Entry_info.int_pair_Entry_Nhap = Convert.ToInt32(dt_info_img.Rows[0]["pair"].ToString());
                    Global.Level_Pair_Entry_Nhap = Entry_info.int_pair_Entry_Nhap;
                    string path_webservice = Global.Webservice + Global.BatchIDSelected + "_" + Global.BatchNameSelected + @"/" + Entry_info.imageName;
                    try
                    {                        
                        System.Net.WebRequest request = System.Net.WebRequest.Create(path_webservice);
                        System.Net.WebResponse response = request.GetResponse();
                        System.IO.Stream responseStream = response.GetResponseStream();
                        Bitmap Source_Image = new Bitmap(responseStream);
                        ImgV.Dispose();
                        ImgV.Image = Source_Image;
                        lb_IdImage.Text = Entry_info.imageName;
                        if (Entry_info.flZoom != 0)
                        {
                            ImgV.CurrentZoom = Entry_info.flZoom;
                        }
                    }
                    catch 
                    {
                        lb_IdImage.Text = "";
                        return "ERROR";
                    }
                    return "OK";
                }
                else
                {
                    return "NULL";
                }                
            }
            return null;
        }

        private void frm_Operator_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Global.isOperatorGroup && !string.IsNullOrEmpty(Entry_info.imageName))
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình. \r\nPhiếu của bạn đang nhập sẽ được trả lại để User khác nhập.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Handle_RefreshImage refreshImage;
                    refreshImage = new Handle_RefreshImage();
                    //int level = Hikari_LoginDLL.Hikari_Login.GetLevelUserOfGroupProject(Global.strUsername, Global.Group_Operator_VN_Code);
                    refreshImage.spData_Refresh_Image_Entry_Check(Global.BatchIDSelected, Entry_info.int_pair_Entry_Nhap.ToString(), Entry_info.ID_Getdata.ToString() ,"ENTRY");
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
        private void btn_Submit_Logout_Click(object sender, EventArgs e)
        {
            string kqsubmit = "";
            if (tabcontrol.SelectedTabPage.Name == "tab_AT")
            {
                if (!uC_PhieuAT1.ConfirmEmptyWarning())
                {
                    return;
                }
                kqsubmit = uC_PhieuAT1.Submit(Global.BatchIDSelected, Entry_info.ID_Getdata.ToString());
            }
            else if (tabcontrol.SelectedTabPage.Name == "tab_AE")
            {
                if (!uC_PhieuAE1.ConfirmEmptyWarning())
                {
                    return;
                }
                kqsubmit = uC_PhieuAE1.Submit(Global.BatchIDSelected, Entry_info.ID_Getdata.ToString());
            }            
            if (kqsubmit == "3")
            {
                ResetDataAllUC();
                Entry_info.imageName = "";
            }
            else if (kqsubmit == "1")
            {
                MessageBox.Show("Không để trống trường 2  \n Vui lòng đọc QUY ĐỊNH và kiểm tra lại !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (kqsubmit == "2")
            {
                MessageBox.Show("Trống thông tin ID Batch và Image. \n Vui lòng đọc QUY ĐỊNH và kiểm tra lại !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (kqsubmit == "4")
            {
                MessageBox.Show("Batch đã tắt 'Chế độ Công Khai' .", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (kqsubmit == "5")
            {
                MessageBox.Show("Trường số 7 trống thông tin \n Vui lòng đọc QUY ĐỊNH và kiểm tra lại !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btn_CopyInfo_Click(object sender, EventArgs e)
        {
            string copy = "";
            if (!string.IsNullOrEmpty(lb_fBatchName.Text))
                copy += "BatchName: " + lb_fBatchName.Text + "\r\n";
            if (!string.IsNullOrEmpty(lb_IdImage.Text))
                copy += "Image: " + lb_IdImage.Text + "\r\n";
            if (!string.IsNullOrEmpty(lb_City.Text))
                copy += "City: " + lb_City.Text + "\r\n";
            copy += "UserName: " + Global.strUsername;

            if (!string.IsNullOrEmpty(copy))
            {
                Clipboard.SetText(copy);
            }
        }
    }
}
