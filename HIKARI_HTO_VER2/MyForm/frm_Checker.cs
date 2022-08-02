using HIKARI_HTO_VER2.LinqToSQLProcess;
using HIKARI_HTO_VER2.ModuleProcessUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIKARI_HTO_VER2.MyForm
{
    public partial class frm_Checker : Form
    {
        using_Tb_Batch using_Tb_Batch;
        using_Tb_Data using_Tb_Data;        
        Check_Info CheckInfo;
        Check_Info_imgBack Data_ImgBack;
        public frm_Checker()
        {
            InitializeComponent();
            using_Tb_Batch = new using_Tb_Batch();
            using_Tb_Data = new using_Tb_Data();
            CheckInfo = new Check_Info();
            Data_ImgBack = new Check_Info_imgBack();
        }

        private void frm_Checker_Load(object sender, EventArgs e)
        {
            lb_UserName.Text = Global.strUsername;
            lb_batchname.Text = Global.BatchNameSelected;            
            lb_City.Text = Global.BatchTypeSelected;
            btn_Submit_Logout.Enabled = false;
            lb_checkconlai.Text = "";
            //lb_SoPhieuNhap.Text = "";
            lb_TongPhieu.Text = "";
            lb_IdImage.Text = "";
            CheckInfo.flZoom =0;
            AE_Back.PageVisible = false;
            AT_Back.PageVisible = false;
        }

        private void frm_Checker_KeyDown(object sender, KeyEventArgs e)
        {
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
                else if (e.KeyCode == Keys.Q)
                {
                    btn_back_Click(null, null);
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.W)
                {
                    btn_Next_Click(null, null);
                    e.Handled = true;
                }
            }
        }
        private void SetInformation()
        {
            try
            {
                var a = using_Tb_Data.Get_info_ImageCheck(Global.BatchIDSelected, Global.Level_Image.ToString(),Global.strUsername);
                lb_checkconlai.Text = a.Số_phiếu_check + "";
                lb_SoPhieuDaCheck.Text = a.Số_phiếu_đã_check + "";
                //lb_TongPhieu.Text = a.Tổng_số_phiếu + "";
            }
            catch (Exception)
            {

            }
        }
        private void ResetDataAllUC()
        {
            
        }

        private void btn_CopyInfo_Click(object sender, EventArgs e)
        {
            string copy = "";
            if (!string.IsNullOrEmpty(cbb_Batch_Check.Text))
                copy += "BatchName: " + cbb_Batch_Check.Text + "\r\n";
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

        private void btn_Submit_Click(object sender, EventArgs e)
        {
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
                btn_back.Visible = true;
                btn_Next.Visible = true;
            }
            else
            {
                //bool Execult_Sql = false;
                CheckInfo.flZoom = ImgV.CurrentZoom;
                int Complete = 0;
                if (Global.BatchTypeSelected == "AE")
                {
                    if (!uC_CHECKER_AE1.ConfirmEmptyWarning())
                    {
                        return;
                    }
                    Complete = uC_CHECKER_AE1.Submit_Data_Check(Convert.ToInt32(Global.BatchIDSelected), CheckInfo.ID_image);
                    
                }
                else if (Global.BatchTypeSelected == "AT")
                {
                    if (!uC_CHECKER_AT1.ConfirmEmptyWarning())
                    {
                        return;
                    }
                    Complete = uC_CHECKER_AT1.Submit_Data_Check(Convert.ToInt32(Global.BatchIDSelected), CheckInfo.ID_image);
                }
                
                //if (!Execult_Sql)
                //{
                //    MessageBox.Show("Đã có lỗi trong quá trình lưu dữ liệu của checker", "Thông Báo!", MessageBoxButtons.OK);
                //    return;
                //}
                if (Complete == 0)
                {
                    MessageBox.Show("Thiếu thông tin cho việc Submit");return;
                }
                else if (Complete == 1)
                {
                    MessageBox.Show("Trường số 2 trống dữ liệu -- \r\n Vui lòng đọc QUY ĐỊNH và kiểm tra lại !"); return;
                }
                else if (Complete == 2)
                {
                    MessageBox.Show("Trường số 7 có dòng trống dữ liệu -- \r\n Vui lòng đọc QUY ĐỊNH và kiểm tra lại !"); return;
                }
                else if (Complete == 4)
                {
                    MessageBox.Show("Đã có lỗi trong quá trình lưu dữ liệu của checker", "Thông Báo!", MessageBoxButtons.OK); return;
                }
                else if (Complete == 5)
                {
                    MessageBox.Show("Trường số 7 8 9 10 (Loại AT) trống dữ liệu", "Thông Báo!", MessageBoxButtons.OK); return;
                }
                Data_ImgBack = new Check_Info_imgBack {
                    BatchName = lb_batchname.Text,
                    Content_E1 = CheckInfo.Content_E1,
                    Content_E2 = CheckInfo.Content_E2,
                    Data_check = Global.BatchTypeSelected == "AE" ? uC_CHECKER_AE1.getDataFull() : uC_CHECKER_AT1.getDataFull() ,
                    ID_Batch = Convert.ToInt32(Global.BatchIDSelected),
                    ID_image = CheckInfo.ID_image,
                    NameImage = CheckInfo.NameImage,
                    UserName_Check = CheckInfo.UserName_Check,
                    UserName_E1 = CheckInfo.UserName_E1,
                    UserName_E2 = CheckInfo.UserName_E2,
                    style_bacth = Global.BatchTypeSelected
                };
                startInput();
                btn_BackImage.Visible = true;
            }
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
                MessageBox.Show(@"Hoàn thành Check Batch '" + Global.BatchNameSelected + "'");
                btn_BackImage.Visible = false;
                Check_BatchTiepTheo();
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
                    uC_CHECKER_AE1.FocusUC();
                    tab_AT.PageVisible = false;                    
                    uC_CHECKER_AE1.Add_Data_AE(CheckInfo);
                }
                else
                {
                    tab_AT.PageVisible = true;
                    tabcontrol.SelectedTabPage = tab_AT;
                    uC_CHECKER_AT1.FocusUC();
                    tab_AE.PageVisible = false;
                    uC_CHECKER_AT1.Add_Data_AT(CheckInfo);
                }
            }
            else if (kq == "ERROR")
            {
                
                this.Close();
            }
        }
        void Check_BatchTiepTheo()
        {
            Global.BatchNameSelected = "";
            Global.BatchTypeSelected = "";
            lb_IdImage.Text = "";
            lb_batchname.Text = "";

            var listResult = (from w in using_Tb_Batch.Get_ListBatch_Checker(Global.Level_Image, Global.BatchIDSelected) select new { w.ID, w.BatchName, w.BatchType , w.Hit_E11}).Where(x=>x.Hit_E11 > 0).ToList();

            if (listResult.Count > 0)
            {
                if (MessageBox.Show("Bạn có muốn Check Batch tiếp theo không?\r\nBatch: " + listResult[0].BatchName, "Hoàn thành Batch!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //Check outsource
                    Global.BatchIDSelected = listResult[0].ID.ToString();
                    Global.BatchNameSelected = listResult[0].BatchName;
                    Global.BatchTypeSelected = listResult[0].BatchType;
                    lb_batchname.Text = Global.BatchNameSelected;
                    lb_City.Text = listResult[0].BatchType;
                    startInput();
                }
                else
                {
                    CheckInfo.NameImage = "";
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Hoàn thành tất cả các Batch.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CheckInfo.NameImage = "";
                btn_BackImage.Visible = false;
                this.Close();
            }
        }
        public string GetImageAndShow()
        {
            lb_IdImage.Text = "";
            DataTable dt_info_img = new DataTable();
            if (Global.isOperatorGroup)
            {
                var Info_Image_check = using_Tb_Data.Get_Image_Check(Global.BatchIDSelected.ToString(), Global.strUsername, Global.Level_Image);
                #region đóng code cũ
                //try
                //{

                //    DataSet ds = new DataSet();
                //    SqlConnection con = new SqlConnection(Global.ConnectionString);
                //    SqlCommand cmd = new SqlCommand("spData_GetImage_Check_v2", con);
                //    cmd.CommandTimeout = 10 * 60;
                //    cmd.CommandType = CommandType.StoredProcedure;
                //    cmd.Parameters.AddWithValue("@BatchID", Global.BatchIDSelected.ToString());
                //    cmd.Parameters.AddWithValue("@User", Global.strUsername);
                //    cmd.Parameters.AddWithValue("@Level_Image", Global.Level_Image.ToString());
                //    SqlDataAdapter da = new SqlDataAdapter();
                //    da.SelectCommand = cmd;
                //    da.Fill(ds);
                //    dt_info_img = ds.Tables[0];
                //}
                //catch (Exception exx)
                //{
                //    MessageBox.Show(exx.ToString());
                //    return "ERROR";
                //}

                #endregion
                if (Info_Image_check.Count < 1)
                {
                    return "NULL";
                }
                else
                {                    
                    CheckInfo.Content_E1 = Info_Image_check.Select(x => x.Content_E1).FirstOrDefault();
                    CheckInfo.Content_E2 = Info_Image_check.Select(x => x.Content_E2).FirstOrDefault();
                    CheckInfo.UserName_E1 = Info_Image_check.Select(x => x.UserName_E1).FirstOrDefault();
                    CheckInfo.UserName_E2 = Info_Image_check.Select(x => x.UserName_E2).FirstOrDefault();
                    CheckInfo.ID_image = Convert.ToInt32(Info_Image_check.Select(x => x.ID).FirstOrDefault());
                    CheckInfo.NameImage = Info_Image_check.Select(x => x.ImageName).FirstOrDefault();
                    CheckInfo.BatchName = Global.BatchNameSelected;
                    CheckInfo.ID_Batch = Convert.ToInt32(Global.BatchIDSelected);
                    string path_webservice = Global.Webservice + Global.BatchIDSelected + "_" + Global.BatchNameSelected + @"/" + CheckInfo.NameImage;
                    if (Show_image(path_webservice, CheckInfo.NameImage) == "ERROR")
                    {
                        MessageBox.Show("Không thể load hình! \r\n " + Global.BatchIDSelected + "_" + Global.BatchNameSelected + @"/" + CheckInfo.NameImage);
                        lb_IdImage.Text = "";
                        return "ERROR";
                    }
                    return "OK";
                }
                #region đóng code cũ
                //if (dt_info_img.Rows.Count > 0)
                //{
                //    imageName = dt_info_img.Rows[0]["ImageName"].ToString();
                //    ID_Getdata = Convert.ToInt32(dt_info_img.Rows[0]["ID"].ToString());
                //    string path_webservice = Global.Webservice + Global.BatchIDSelected + "_" + Global.BatchNameSelected + @"/" + imageName;
                //    try
                //    {
                //        System.Net.WebRequest request = System.Net.WebRequest.Create(path_webservice);
                //        System.Net.WebResponse response = request.GetResponse();
                //        System.IO.Stream responseStream = response.GetResponseStream();
                //        Bitmap Source_Image = new Bitmap(responseStream);
                //        ImgV.Dispose();
                //        ImgV.Image = Source_Image;
                //        lb_IdImage.Text = imageName;
                //    }
                //    catch
                //    {
                //        lb_IdImage.Text = "";
                //        return "ERROR";
                //    }
                //    return "OK";
                //}
                //else
                //{
                //    return "NULL";
                //}
                #endregion
            }
            return null;
        }
        #region Compare string
        static int max(int a, int b)
        {
            return (a > b) ? a : b;
        }
        static int[,] c;
        //Prints one LCS
        private string BackTrack_AT(string s1, string s2, int i, int j)
        {
            if (i == 0 || j == 0)
                return "";
            if (s1[i - 1] == s2[j - 1])
            {
                //lsttxt[numbertrtxt].SelectionStart = i - 1;
                //lsttxt[numbertrtxt].SelectionLength = 1;
                //lsttxt[numbertrtxt].SelectionColor = Color.Black;
                return BackTrack_AT(s1, s2, i - 1, j - 1) + s1[i - 1];
            }
            else if (c[i - 1, j] > c[i, j - 1])
                return BackTrack_AT(s1, s2, i - 1, j);

            else
                return BackTrack_AT(s1, s2, i, j - 1);

        }
        private string BackTrack_AE(string s1, string s2, int i, int j)
        {
            if (i == 0 || j == 0)
                return "";
            if (s1[i - 1] == s2[j - 1])
            {
                //lsttxt[numbertrtxt].SelectionStart = i - 1;
                //lsttxt[numbertrtxt].SelectionLength = 1;
                //lsttxt[numbertrtxt].SelectionColor = Color.Black;
                return BackTrack_AE(s1, s2, i - 1, j - 1) + s1[i - 1];
            }
            else if (c[i - 1, j] > c[i, j - 1])
                return BackTrack_AE(s1, s2, i - 1, j);

            else
                return BackTrack_AE(s1, s2, i, j - 1);

        }
        //Nghịch       
        //private string BackTrack2(string s1, string s2, int i, int j)
        //{
        //    if (i == 0 || j == 0)
        //        return "";
        //    if (s1[i - 1] == s2[j - 1])
        //    {
        //        return BackTrack2(s1, s2, i - 1, j - 1) + s1[i - 1];
        //    }
        //    else if (c[i - 1, j] > c[i, j - 1])
        //        return BackTrack2(s1, s2, i - 1, j);

        //    else
        //        return BackTrack2(s1, s2, i, j - 1);

        //}
        static int LCS(string s1, string s2)
        {
            for (int i = 1; i <= s1.Length; i++)
                c[i, 0] = 0;
            for (int i = 1; i <= s2.Length; i++)
                c[0, i] = 0;

            for (int i = 1; i <= s1.Length; i++)
                for (int j = 1; j <= s2.Length; j++)
                {
                    if (s1[i - 1] == s2[j - 1])
                        c[i, j] = c[i - 1, j - 1] + 1;
                    else
                    {
                        c[i, j] = max(c[i - 1, j], c[i, j - 1]);

                    }

                }

            return c[s1.Length, s2.Length];

        }
        #endregion

        private void frm_Checker_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Global.isOperatorGroup && !string.IsNullOrEmpty(CheckInfo.NameImage))
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình. \r\nPhiếu của bạn đang xử lý Check sẽ được trả lại để người khác thực hiện Check.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Handle_RefreshImage refreshImage;
                    refreshImage = new Handle_RefreshImage();
                    //int level = Hikari_LoginDLL.Hikari_Login.GetLevelUserOfGroupProject(Global.strUsername, Global.Group_Operator_VN_Code);
                    refreshImage.spData_Refresh_Image_Entry_Check(Global.BatchIDSelected, "", CheckInfo.ID_image.ToString(), "CHECK");
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void cbb_Batch_Check_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel_Top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            TimeSpan tsp = new TimeSpan();
            tsp = DateTime.Now - dtime_Back;
            int timerun = Convert.ToInt32(tsp.TotalMilliseconds);
            
            AE_Back.PageVisible = false;
            AT_Back.PageVisible = false;
            if (Global.BatchTypeSelected == "AE")
            {
                uc_CheckAE_Back1.Submit_Data_Check_Back(Data_ImgBack.ID_Batch, Data_ImgBack.ID_image, timerun);
                tab_AE.PageVisible = true;
                tabcontrol.SelectedTabPage = tab_AE;
                uC_CHECKER_AE1.FocusUC();
                tab_AT.PageVisible = false;
                uC_CHECKER_AE1.Add_Data_AE(CheckInfo);
            }
            else
            {
                uc_CheckAT_Back1.Submit_Check_Back(Data_ImgBack.ID_Batch, Data_ImgBack.ID_image, timerun);
                tab_AT.PageVisible = true;
                tabcontrol.SelectedTabPage = tab_AT;
                uC_CHECKER_AT1.FocusUC();
                tab_AE.PageVisible = false;
                uC_CHECKER_AT1.Add_Data_AT(CheckInfo);
            }
            string path_webservice = Global.Webservice + CheckInfo.ID_Batch + "_" + CheckInfo.BatchName + @"/" + CheckInfo.NameImage;
            Show_image(path_webservice, CheckInfo.NameImage);
            btn_Save.Visible = false; btn_Cancel.Visible = false;
            btn_Submit.Visible = true; btn_Submit_Logout.Visible = true;
            btn_BackImage.Visible = false;
            lb_IdImage.Text = CheckInfo.NameImage;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ResetDataAllUC();
            SetInformation();
            AE_Back.PageVisible = false;
            AT_Back.PageVisible = false;
            if (Global.BatchTypeSelected == "AE")
            {
                tab_AE.PageVisible = true;
                tabcontrol.SelectedTabPage = tab_AE;
                uC_CHECKER_AE1.FocusUC();
                tab_AT.PageVisible = false;
                uC_CHECKER_AE1.Add_Data_AE(CheckInfo);
            }
            else
            {
                tab_AT.PageVisible = true;
                tabcontrol.SelectedTabPage = tab_AT;
                uC_CHECKER_AT1.FocusUC();
                tab_AE.PageVisible = false;
                uC_CHECKER_AT1.Add_Data_AT(CheckInfo);
            }
            btn_BackImage.Visible = false;            
            string path_webservice = Global.Webservice + CheckInfo.ID_Batch + "_" + CheckInfo.BatchName + @"/" + CheckInfo.NameImage;
            Show_image(path_webservice, CheckInfo.NameImage);
            //Add_Data(Data_ImgBack.data_nhap, Data_ImgBack.BatchType);
            btn_Save.Visible = false; btn_Cancel.Visible = false;
            btn_Submit.Visible = true; btn_Submit_Logout.Visible = true;
            btn_BackImage.Visible = false;
            lb_IdImage.Text = CheckInfo.NameImage;
        }
        DateTime dtime_Back;
        private void btn_BackImage_Click(object sender, EventArgs e)
        {
            dtime_Back =DateTime.Now;
            if (Data_ImgBack.style_bacth == "AE")
            {                
                AE_Back.PageVisible = true;
                AT_Back.PageVisible = false;
                tabcontrol.SelectedTabPage = AE_Back;
                uc_CheckAE_Back1.lst_header[0].Focus();
                uc_CheckAE_Back1.Add_Data_Back(Data_ImgBack);
            }
            else
            {
                AE_Back.PageVisible = false;
                AT_Back.PageVisible = true;
                tabcontrol.SelectedTabPage = AT_Back;
                uc_CheckAT_Back1.lst_header_AT[0].Focus();
                uc_CheckAT_Back1.Add_Data_Back(Data_ImgBack);
            }
            string path_webservice = Global.Webservice + Data_ImgBack.ID_Batch + "_" + Data_ImgBack.BatchName + @"/" + Data_ImgBack.NameImage;
            if (Show_image(path_webservice, Data_ImgBack.NameImage) == "ERROR")
            {
                MessageBox.Show("Không thể load hình! \r\n " + Data_ImgBack.ID_Batch + "_" + Data_ImgBack.BatchName + @"/" + Data_ImgBack.NameImage);
                lb_IdImage.Text = "";
                this.Close();
            }
            tab_AE.PageVisible = false;
            tab_AT.PageVisible = false;
            btn_Save.Visible = true; btn_Cancel.Visible = true;
            btn_Submit.Visible = false; btn_Submit_Logout.Visible = false;
            btn_BackImage.Visible = false;
            lb_IdImage.Text = Data_ImgBack.NameImage;
        }
        public string Show_image(string linkImg, string nameImg)
        {
            string Status_Image = "";
            try
            {
                System.Net.WebRequest request = System.Net.WebRequest.Create(linkImg);
                System.Net.WebResponse response = request.GetResponse();
                System.IO.Stream responseStream = response.GetResponseStream();
                Bitmap Source_Image = new Bitmap(responseStream);
                ImgV.Dispose();
                ImgV.Image = Source_Image;
                lb_IdImage.Text = nameImg;
                if (CheckInfo.flZoom != 0)
                {
                    ImgV.CurrentZoom = CheckInfo.flZoom;
                }
            }
            catch
            {                
                return Status_Image = "ERROR";
            }
            return Status_Image;
        }

        public void Add_Data(string linkDataImg, string style)
        {
            if (style == "AE")
            {
                for (int i = 0; i < uC_CHECKER_AE1.lst_header.Count; i++)
                {
                    uC_CHECKER_AE1.lst_header[i].Text = linkDataImg.Split('‡')[0].Split('†')[i].ToString();
                }
                for (int i = 0; i < uC_CHECKER_AE1.lst_body.Count; i++)
                {
                    uC_CHECKER_AE1.lst_body[i].Text = linkDataImg.Split('‡')[1].Split('†')[i].ToString();
                }
            }
            else
            {                
                for (int i = 0; i < uC_CHECKER_AT1.lst_to_List_Rtb.Count; i++)
                {
                    for (int t = 0; t < uC_CHECKER_AT1.lst_to_List_Rtb[i].Count; t++)
                    {
                        uC_CHECKER_AT1.lst_to_List_Rtb[i][t].Text = linkDataImg.Split('‡')[i].Split('†')[t].ToString();
                    }
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (btn_Save.Visible)
            {
                try
                {
                    string rs_nameImg = GlobalDB.DBLinq.Check_ViewImage_Back_Next(Global.BatchIDSelected, Data_ImgBack.ID_image.ToString(), "Back", "1").FirstOrDefault().Column1.ToString();
                    string path_webservice = Global.StrPath + @"\" + Global.BatchIDSelected + "_" + Data_ImgBack.BatchName + @"\" + rs_nameImg;
                    Process.Start(path_webservice);
                }
                catch (Exception)
                {
                }                
            }
            else
            {
                try
                {
                    string rs_nameImg = GlobalDB.DBLinq.Check_ViewImage_Back_Next(Global.BatchIDSelected, CheckInfo.ID_image.ToString(), "Back", "1").FirstOrDefault().Column1.ToString();
                    string path_webservice = Global.StrPath + @"\" + Global.BatchIDSelected + "_" + CheckInfo.BatchName + @"\" + rs_nameImg;
                    Process.Start(path_webservice);
                }
                catch (Exception)
                {                    
                }
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (btn_Save.Visible)
            {
                try
                {
                    string rs_nameImg = GlobalDB.DBLinq.Check_ViewImage_Back_Next(Global.BatchIDSelected, Data_ImgBack.ID_image.ToString(), "Next", "1").FirstOrDefault().Column1.ToString();
                    string path_webservice = Global.StrPath + @"\" + Global.BatchIDSelected + "_" + Data_ImgBack.BatchName + @"\" + rs_nameImg;
                    Process.Start(path_webservice);
                }
                catch (Exception)
                {
                }
            }
            else
            {
                try
                {
                    string rs_nameImg = GlobalDB.DBLinq.Check_ViewImage_Back_Next(Global.BatchIDSelected, CheckInfo.ID_image.ToString(), "Next", "1").FirstOrDefault().Column1.ToString();
                    string path_webservice = Global.StrPath + @"\" + Global.BatchIDSelected + "_" + CheckInfo.BatchName + @"\" + rs_nameImg;                    
                    Process.Start(path_webservice);
                }
                catch (Exception)
                {
                }
            }
        }
    }
}
