using HIKARI_HTO_VER2.LinqToSQLProcess;
using HIKARI_HTO_VER2.ProcessUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIKARI_HTO_VER2.MyUserControl
{
    public partial class UC_Export_Excel : UserControl
    {
        DataTable tb_Result, tb_Result_Error;
        public UC_Export_Excel()
        {
            InitializeComponent();
        }

        private void UC_Export_Excel_Load(object sender, EventArgs e)
        {
            Change_StyleBatch("AE");
        }
        private DataTable AddColumnDataAE()
        {
            DataTable dt_exportexcel = new DataTable();
            dt_exportexcel.Columns.Add("TRƯỜNG");
            dt_exportexcel.Columns.Add("1. Cố định AE");
            dt_exportexcel.Columns.Add("2. No");
            dt_exportexcel.Columns.Add("3. Code");
            dt_exportexcel.Columns.Add("4. 班");
            dt_exportexcel.Columns.Add("5.棚番");
            dt_exportexcel.Columns.Add("6. STT");
            dt_exportexcel.Columns.Add("7. Mã SP");
            dt_exportexcel.Columns.Add("8. Mã 工号");
            dt_exportexcel.Columns.Add("9. Số lượng");

            dt_exportexcel.Columns.Add("10.機能Chức năng");
            dt_exportexcel.Columns.Add("11. Mặc định K hoặc M");
            dt_exportexcel.Columns.Add("12. Phân loại");

            dt_exportexcel.Columns.Add("TRỐNG1");
            dt_exportexcel.Columns.Add("TRỐNG2");
            dt_exportexcel.Columns.Add("TRỐNG3");
            dt_exportexcel.Columns.Add("TRỐNG4");
            dt_exportexcel.Columns.Add("TRỐNG5");
            dt_exportexcel.Columns.Add("TRỐNG6");
            dt_exportexcel.Columns.Add("PATH");
            dt_exportexcel.Columns.Add("BatchName");
            return dt_exportexcel;
        }

        private DataTable AddColumnDataAT()
        {
            DataTable dt_exportexcel = new DataTable();
            dt_exportexcel.Columns.Add("TRƯỜNG");
            dt_exportexcel.Columns.Add("1. Cố định AE");
            dt_exportexcel.Columns.Add("2. No");
            dt_exportexcel.Columns.Add("3. Code");
            dt_exportexcel.Columns.Add("4. 班");
            dt_exportexcel.Columns.Add("5.棚番");
            dt_exportexcel.Columns.Add("6. STT");
            dt_exportexcel.Columns.Add("7. Mã SP");
            dt_exportexcel.Columns.Add("8. Mã 工号");
            dt_exportexcel.Columns.Add("9. Số lượng");

            dt_exportexcel.Columns.Add("10.機能Chức năng");
            dt_exportexcel.Columns.Add("11. Mặc định K hoặc M");
            dt_exportexcel.Columns.Add("12. Phân loại");

            dt_exportexcel.Columns.Add("TRỐNG1");
            dt_exportexcel.Columns.Add("TRỐNG2");
            dt_exportexcel.Columns.Add("TRỐNG3");
            dt_exportexcel.Columns.Add("TRỐNG4");
            dt_exportexcel.Columns.Add("TRỐNG5");
            dt_exportexcel.Columns.Add("TRỐNG6");
            dt_exportexcel.Columns.Add("PATH");
            dt_exportexcel.Columns.Add("BatchName");
            return dt_exportexcel;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {            
        }
        

        private void btn_xuatExel_Click(object sender, EventArgs e)
        {
            //if (backgroundWorker1.IsBusy)
            //{
            //    MessageBox.Show("Đang thực hiện xuất excel. Vui lòng đợi...");
            //    return;
            //}
            //btn_ShowData_Click(null, null);

            //Dictionary<string, string> batchChuaCheck = new Dictionary<string, string>();
            //Dictionary<string, string> batchChuaNhap = new Dictionary<string, string>();

            //List<spData_ListUserIsNotFinishCheckResult> notfnCheck = new List<spData_ListUserIsNotFinishCheckResult>();
            //List<spData_ListUserIsNotFinishInputResult> notfnInput = new List<spData_ListUserIsNotFinishInputResult>();



            //// lặp qua các batch muốn xuất excel
            //foreach (ListViewItem item in lwv_Batch.SelectedItems)
            //{
            //    if (tb_Data.spData_IsFinishInput(item.SubItems[1].Text) == 0)
            //    {
            //        // lấy ra batch chưa nhập xong
            //        batchChuaNhap.Add(item.SubItems[2].Text, item.SubItems[1].Text);
            //    }
            //    if (tb_Data.spData_IsFinishCheck(item.SubItems[1].Text) == 0)
            //    {
            //        //lấy ra batch chưa check xong
            //        batchChuaCheck.Add(item.SubItems[2].Text, item.SubItems[1].Text);
            //    }
            //}
            //int coutCheck = batchChuaCheck.Count;
            //int countNhap = batchChuaNhap.Count;
            //string err = "";
            //if (countNhap > 0)
            //{
            //    err = "";

            //    // lặp qua các batch đang nhập để lấy User và Image cho từng batch để in ra
            //    foreach (var item in batchChuaNhap)
            //    {
            //        notfnInput = tb_Data.spData_ListUserIsNotFinishInput(item.Value);
            //        err += item.Key + "\n";
            //        // lấy ra string các Image và user đang nhập
            //        if (notfnInput.Count > 0)
            //        {
            //            for (int j = 0; j < notfnInput.Count; j++)
            //            {
            //                if (String.IsNullOrEmpty(notfnInput[j].UserNameDeSo))
            //                    err += "Ảnh " + notfnInput[j].IDImage + "Chưa đủ 2 người nhập \n";
            //                else
            //                    err += "Ảnh " + notfnInput[j].IDImage + " đang nhập bởi " + notfnInput[j].UserNameDeSo + " \n";


            //            }
            //        }


            //    }
            //    // làm tương tự cho các batch đang nhập

            //    MessageBox.Show("Batch " + err + " Chưa hoàn thành nhập");
            //}
            //else if (coutCheck > 0)
            //{
            //    err = "";
            //    // lặp qua các batch đang check để lấy User và Image cho từng batch để in ra
            //    foreach (var item in batchChuaCheck)
            //    {
            //        notfnCheck = tb_Data.spData_ListUserIsNotFinishCheck(item.Value);
            //        // lấy ra string các Image và user đang check
            //        err += item.Key + "\n";
            //        for (int j = 0; j < notfnCheck.Count; j++)
            //        {
            //            if (String.IsNullOrEmpty(notfnCheck[j].UserNameChecker))
            //                err += "Ảnh " + notfnCheck[j].IDImage + " chưa được ai check" + " \n";

            //            else
            //                err += "Ảnh " + notfnCheck[j].IDImage + " đang check bởi " + notfnCheck[j].UserNameChecker + " \n";
            //        }
            //    }
            //    // làm tương tự cho các batch đang nhập
            //    MessageBox.Show("Batch " + err + " chưa hoàn thành check");
            //}
            //else
            //{
            //    if (ApplicationDeployment.IsNetworkDeployed)
            //    {
            //        backgroundWorker1.RunWorkerAsync();
            //    }
            //    else
            //    {
            //        exportexcel();
            //        SaveFile();
            //    }


            //}

        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            string str_batchId = CheckCBB_Export.Properties.GetCheckedItems().ToString();
            if (str_batchId != "")
            {
                if (rdb_AE.Checked == true || rdb_AT.Checked == true)
                {
                    tb_Result = new DataTable(); tb_Result_Error = new DataTable();
                    var Result = (from w in GlobalDB.DBLinq.Admin_Export_Data(str_batchId) select new { w.BatchName, w.ID_Batch, w.ImageName, w.ResultLC, w.Loai, w.PathPicture }).ToList();
                    tb_Result = rdb_AE.Checked ? AddColumnDataAE() : AddColumnDataAT();
                    tb_Result_Error = rdb_AE.Checked ? AddColumnDataAE() : AddColumnDataAT();
                    foreach (var item in Result)
                    {
                        if (rdb_AE.Checked)
                        {
                            for (int i = 0; i < item.ResultLC.Split('‡')[1].Split('†')[0].Length; i++)
                            {
                                bool Error = false;
                                DataRow dtr_Rs_or_Error = null;
                                if (item.ResultLC.Split('‡')[1].Split('†')[i].ToString() != "" && item.ResultLC.Split('‡')[1].Split('†')[i].ToString() != "?" && item.ResultLC.Split('‡')[1].Split('†')[i].ToString() != "T")
                                {
                                    dtr_Rs_or_Error = tb_Result.NewRow();
                                    Error = false;
                                }
                                else
                                {
                                    dtr_Rs_or_Error = tb_Result_Error.NewRow(); Error = true;
                                }
                                dtr_Rs_or_Error[Constant.ImageName] = item.ImageName; // Image                                                         // 1
                                dtr_Rs_or_Error[Constant.Truong01] = "AE"; //AT hay AE
                                dtr_Rs_or_Error[Constant.Truong02] = item.ResultLC.Split('‡')[0].Split('†')[0].ToString() == null ? "" : item.ResultLC.Split('‡')[0].Split('†')[0].ToString();//2  

                                dtr_Rs_or_Error[Constant.Truong03] = item.ResultLC.Split('‡')[0].Split('†')[1].ToString() == null ? "" : item.ResultLC.Split('‡')[0].Split('†')[1].ToString();//3  
                                dtr_Rs_or_Error[Constant.Truong04] = item.ResultLC.Split('‡')[0].Split('†')[2].ToString() == null ? "" : item.ResultLC.Split('‡')[0].Split('†')[2].ToString();//4
                                dtr_Rs_or_Error[Constant.Truong05] = item.ResultLC.Split('‡')[0].Split('†')[3].ToString() == null ? "" : item.ResultLC.Split('‡')[0].Split('†')[3].ToString();//5

                                dtr_Rs_or_Error[Constant.Truong06] = (i + 1).ToString();//STT
                                dtr_Rs_or_Error[Constant.Truong07] = "";//7
                                dtr_Rs_or_Error[Constant.Truong08] = "";//8
                                dtr_Rs_or_Error[Constant.Truong09] = item.ResultLC.Split('‡')[1].Split('†')[i].ToString() == null ? "" : item.ResultLC.Split('‡')[1].Split('†')[i].ToString();//9
                                dtr_Rs_or_Error[Constant.Truong10] = "";//10
                                dtr_Rs_or_Error[Constant.Truong11] = "";//11
                                dtr_Rs_or_Error[Constant.Truong12] = phanLoaiAE(item.PathPicture + item.BatchName + @"\" + item.ImageName == null ? "" : item.PathPicture + item.BatchName + @"\" + item.ImageName);//12 phân loại
                                dtr_Rs_or_Error[13] = ""; //13
                                dtr_Rs_or_Error[14] = "";//14
                                dtr_Rs_or_Error[15] = "";//15
                                dtr_Rs_or_Error[16] = "";//16
                                dtr_Rs_or_Error[17] = "";//17
                                dtr_Rs_or_Error[18] = "";//18
                                dtr_Rs_or_Error[Constant.path] = item.PathPicture + item.BatchName + @"\" + item.ImageName == null ? "" : item.PathPicture + item.BatchName + @"\" + item.ImageName;//18
                                dtr_Rs_or_Error[Constant.BatchName] = item.BatchName;
                                if (Error == false)
                                {
                                    tb_Result.Rows.Add(dtr_Rs_or_Error);
                                }
                                else
                                {
                                    tb_Result_Error.Rows.Add(dtr_Rs_or_Error);
                                }
                            }
                        }
                        else
                        {
                            for (int i = 1; i < item.ResultLC.Split('‡').Length; i++)
                            {                                
                                DataRow dtr_Rs_or_Error = null;
                                dtr_Rs_or_Error = tb_Result.NewRow();
                                
                                dtr_Rs_or_Error[Constant.ImageName] = item.ImageName; // Image                                                         // 1
                                dtr_Rs_or_Error[Constant.Truong01] = "AT"; //AT hay AE
                                dtr_Rs_or_Error[Constant.Truong02] = item.ResultLC.Split('‡')[0].Split('†')[0].ToString() == null ? "" : item.ResultLC.Split('‡')[0].Split('†')[0].ToString();//2  

                                if (checkTruong7LoaiAT(item.ResultLC.Split('‡')[i].Split('†')[0].ToString() == null ? "" : item.ResultLC.Split('‡')[i].Split('†')[0].ToString()) == false)
                                {
                                    dtr_Rs_or_Error[Constant.Truong03] = ""; //3
                                    dtr_Rs_or_Error[Constant.Truong04] = ""; //4
                                    dtr_Rs_or_Error[Constant.Truong05] = ""; // 5
                                }
                                else
                                {
                                    dtr_Rs_or_Error[Constant.Truong03] = item.ResultLC.Split('‡')[0].Split('†')[1].ToString() == null ? "" : item.ResultLC.Split('‡')[0].Split('†')[1].ToString();//3  
                                    dtr_Rs_or_Error[Constant.Truong04] = item.ResultLC.Split('‡')[0].Split('†')[2].ToString() == null ? "" : item.ResultLC.Split('‡')[0].Split('†')[2].ToString();//4
                                    dtr_Rs_or_Error[Constant.Truong05] = item.ResultLC.Split('‡')[0].Split('†')[3].ToString() == null ? "" : item.ResultLC.Split('‡')[0].Split('†')[3].ToString();//5
                                }                                

                                dtr_Rs_or_Error[Constant.Truong06] = (i + 1).ToString();//STT
                                dtr_Rs_or_Error[Constant.Truong07] = item.ResultLC.Split('‡')[i].Split('†')[0].ToString() == null ? "" : item.ResultLC.Split('‡')[i].Split('†')[0].ToString();//7

                                if (checkTruong7LoaiAT(item.ResultLC.Split('‡')[i].Split('†')[0].ToString() == null ? "" : item.ResultLC.Split('‡')[i].Split('†')[0].ToString()) == false)
                                {
                                    dtr_Rs_or_Error[Constant.Truong08] = ""; //8
                                    dtr_Rs_or_Error[Constant.Truong09] = ""; //9
                                    dtr_Rs_or_Error[Constant.Truong10] = ""; //10
                                }
                                else
                                {
                                    dtr_Rs_or_Error[Constant.Truong08] = item.ResultLC.Split('‡')[i].Split('†')[2].ToString() == null ? "" : item.ResultLC.Split('‡')[i].Split('†')[2].ToString();//8  
                                    dtr_Rs_or_Error[Constant.Truong09] = item.ResultLC.Split('‡')[i].Split('†')[3].ToString() == null ? "" : item.ResultLC.Split('‡')[i].Split('†')[3].ToString();//9
                                    dtr_Rs_or_Error[Constant.Truong10] = item.ResultLC.Split('‡')[i].Split('†')[1].ToString() == null ? "" : item.ResultLC.Split('‡')[i].Split('†')[1].ToString();//10
                                }

                                dtr_Rs_or_Error[Constant.Truong11] = TakeFirstChar(item.ResultLC.Split('‡')[i].Split('†')[0].ToString() == null ? "" : item.ResultLC.Split('‡')[i].Split('†')[0].ToString());//11
                                dtr_Rs_or_Error[Constant.Truong12] = phanLoaiAT(item.PathPicture + item.BatchName + @"\" + item.ImageName == null ? "" : item.PathPicture + item.BatchName + @"\" + item.ImageName);//12 phân loại
                                dtr_Rs_or_Error[13] = ""; //13
                                dtr_Rs_or_Error[14] = "";//14
                                dtr_Rs_or_Error[15] = "";//15
                                dtr_Rs_or_Error[16] = "";//16
                                dtr_Rs_or_Error[17] = "";//17
                                dtr_Rs_or_Error[18] = "";//18
                                dtr_Rs_or_Error[Constant.path] = item.PathPicture + item.BatchName + @"\" + item.ImageName == null ? "" : item.PathPicture + item.BatchName + @"\" + item.ImageName;//18
                                dtr_Rs_or_Error[Constant.BatchName] = item.BatchName;
                                
                                tb_Result.Rows.Add(dtr_Rs_or_Error);                                
                            }
                        }
                    }
                    if (tb_Result.Rows.Count > 0)
                    {
                        grd_img.DataSource = null;
                        grd_img.DataSource = tb_Result;
                        grdV_Error.Columns[Constant.ImageName].OptionsColumn.ReadOnly = true;
                        grdV_Error.Columns[Constant.ImageName].OptionsColumn.AllowEdit = false;
                    }
                    if (tb_Result_Error.Rows.Count > 0)
                    {
                        grd_Error.DataSource = null;
                        grd_Error.DataSource = tb_Result_Error;
                        grdV_Error.Columns[Constant.ImageName].OptionsColumn.ReadOnly = true;
                        grdV_Error.Columns[Constant.ImageName].OptionsColumn.AllowEdit = false;
                    }
                    
                }
                else
                {  MessageBox.Show("Thiếu thông tin Loại được chọn ???"); return; }
            }
            else { MessageBox.Show("Thiếu thông tin Batch được chọn ???"); return; }
        }

        private void rdb_AE_CheckedChanged(object sender, EventArgs e)
        {
            Change_StyleBatch("AE");
        }

        private void rdb_AT_CheckedChanged(object sender, EventArgs e)
        {
            Change_StyleBatch("AT");
        }

        private void Change_StyleBatch(string Style)
        {
            CheckCBB_Export.Properties.Items.Clear();
            CheckCBB_Export.Properties.DataSource = GlobalDB.DBLinq.Admin_GetListLC_Export(Style).ToList();
            CheckCBB_Export.Properties.ValueMember = "ID";
            CheckCBB_Export.Properties.DisplayMember = "BatchName";
        }
        public string phanLoaiAE(string path)
        {
            if (path == "")
                return "";
            string s = path.Substring(10, 4);
            switch (s)
            {
                case "SOKA":
                    return "EA1";

                case "TUKU":
                    return "EA2";

                case "SIMO":
                    return "EA8";

                case "YAMA":
                    return "EA3";

                case "TONO":
                    return "EA5";

                case "KAMA":
                    return "EA4";

                case "BUTU":
                    return "EA6";
                default:
                    return "";
            }
        }

        public string phanLoaiAT(string path)
        {
            if (path == "")
                return "";

            string s = path.Substring(7, 4);
            switch (s)
            {
                case "SOKA":
                    return "TA1";

                case "TUKU":
                    return "TA2";

                case "SIMO":
                    return "TA8";

                case "YAMA":
                    return "TA3";

                case "TONO":
                    return "TA5";

                case "KAMA":
                    return "TA4";

                case "BUTU":
                    return "TA6";
                default:
                    return "";
            }
        }

        public void CheckChamHoiVaT(string truong9, int i)
        {
            if (truong9 == "?" || truong9 == "T") { }
                
        }


        public bool checkTruong7LoaiAT(string truong7)
        {
            if (truong7.Contains("YOHAKU") || truong7.Contains("SAKUJYO") || truong7.Contains("KAKISONJI") || truong7.Contains("MISIYO"))
            {
                return false;
            }
            return true;
        }

        public string TakeFirstChar(string truong7)
        {
            if (truong7.Contains("KAKISONJI"))
                return "K";
            else if (truong7.Contains("MISIYO"))
            {
                return "M";
            }

            return "";
        }

        private void ConvertData_AE(DataTable dt_Result, DataTable dt_Result_Error)
        {
            
        }

        private void grdV_img_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = (DevExpress.XtraGrid.Views.Grid.GridView)sender;
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void grdV_Error_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = (DevExpress.XtraGrid.Views.Grid.GridView)sender;
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void CheckCBB_Export_Enter(object sender, EventArgs e)
        {
            Change_StyleBatch(rdb_AE.Checked ? "AE" : "AT");
        }

        private DataTable ConvertData_AT()
        {
            DataTable dt_data_AT = new DataTable();
            return dt_data_AT;
        }
    }
}
