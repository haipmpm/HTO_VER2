using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using HIKARI_HTO_VER2.LinqToSQLProcess;
using HIKARI_HTO_VER2.ModuleProcessUtil;
using HIKARI_HTO_VER2.ProcessUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIKARI_HTO_VER2.MyUserControl
{
    public partial class UC_Export_Excel : UserControl
    {
        DataTable tb_Result, tb_Result_Error, tb_Sosanh, tb_Image_Change;
        bool change_data_save = false;
        int[] numberData; int counter; int[] number_Excel;
        List<int> lst_Data_Excel_T2;
        Ham_Chung hamchung;
        public UC_Export_Excel()
        {
            InitializeComponent();
            hamchung = new Ham_Chung();
            lst_Data_Excel_T2 = new List<int>();
            tb_Sosanh = new DataTable();
            tb_Sosanh.Columns.Add("Data_Truong2");
            tb_Sosanh.Columns.Add("Dòng Dữ liệu");
            tb_Sosanh.Columns.Add("Dòng Khách hàng");
            tb_Image_Change = new DataTable();
            tb_Image_Change.Columns.Add("ImageName");
            tb_Image_Change.Columns.Add("BatchName");
            tb_Image_Change.Columns.Add("IdBatch");
        }

        private void UC_Export_Excel_Load(object sender, EventArgs e)
        {
            Change_StyleBatch("AE");
            splitContainerControl1.SplitterPosition = splitContainerControl1.Width * 3 /4;
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
            dt_exportexcel.Columns.Add("BatchID");
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
            dt_exportexcel.Columns.Add("BatchID");
            return dt_exportexcel;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {            
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            tb_Image_Change.Clear();
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
                            for (int i = 0; i < item.ResultLC.Split('‡')[1].Split('†').Length; i++)
                            {
                                bool Error = false;
                                DataRow dtr_Rs_or_Error = null;
                                dtr_Rs_or_Error = tb_Result.NewRow();
                                if (item.ResultLC.Split('‡')[1].Split('†')[i].ToString() != "" && item.ResultLC.Split('‡')[1].Split('†')[i].ToString() != "?" && item.ResultLC.Split('‡')[1].Split('†')[i].ToString() != "T")
                                {
                                    Error = false;
                                }
                                else  {  Error = true;}
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
                                dtr_Rs_or_Error[Constant.BatchID] = item.ID_Batch;
                                tb_Result.Rows.Add(dtr_Rs_or_Error);
                                if (Error == true)
                                {                                    
                                    DataRow dt_Error = tb_Result_Error.NewRow();
                                    dt_Error = dtr_Rs_or_Error;
                                    tb_Result_Error.ImportRow(dt_Error);
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

                                dtr_Rs_or_Error[Constant.Truong06] = (i).ToString();//STT
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
                                dtr_Rs_or_Error[Constant.BatchID] = item.ID_Batch;
                                tb_Result.Rows.Add(dtr_Rs_or_Error);                                
                            }
                        }
                    }
                    if (tb_Result.Rows.Count > 0)
                    {
                        grd_img.DataSource = null;
                        grd_img.DataSource = tb_Result;
                        grdV_img.Columns[Constant.ImageName].OptionsColumn.ReadOnly = false;
                        grdV_img.Columns[Constant.ImageName].OptionsColumn.AllowEdit = false;
                        grdV_img.Columns[Constant.BatchID].Visible = false;
                    }
                    if (tb_Result_Error.Rows.Count > 0)
                    {
                        grd_Error.DataSource = null;
                        grd_Error.DataSource = tb_Result_Error;
                        grdV_Error.Columns[Constant.ImageName].OptionsColumn.ReadOnly = false;
                        grdV_Error.Columns[Constant.ImageName].OptionsColumn.AllowEdit = false;
                        grdV_img.Columns[Constant.BatchID].Visible = false;
                    }                    
                }
                else
                { splashScreenManager1.CloseWaitForm(); MessageBox.Show("Thiếu thông tin Loại được chọn ???"); return; }
            }
            else { splashScreenManager1.CloseWaitForm(); MessageBox.Show("Thiếu thông tin Batch được chọn ???"); return; }
            List<int> lst_Data_Excel_T2 = new List<int>(tb_Result.Rows.Count);
            DataRow[] dtr = tb_Result.Select("[" + tb_Result.Columns[Constant.Truong02].ColumnName + "] <> ''");
            lst_Data_Excel_T2.AddRange(dtr.Select(x => Convert.ToInt32(x.ItemArray[2].ToString())).Distinct());
            
            
            splashScreenManager1.CloseWaitForm();
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

        private void btn_Export_Click(object sender, EventArgs e)
        {
            if (tb_Image_Change.Rows.Count > 0)
            {
                MessageBox.Show("Dữ liệu có Sửa nhưng chưa Save Data !!!");
                return;
            }
            var MessQuesstion = MessageBox.Show("Thực hiện Convert Dữ liệu đang hiển thị -> .txt", "Question ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (MessQuesstion == DialogResult.Yes)
            {
                if (tb_Result.Rows.Count > 0)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Text Files (.txt) |*.txt";
                    sfd.Title = "Save Text File";
                    sfd.FileName = "";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string Filename = Path.GetDirectoryName(sfd.FileName);
                        grdV_img.ClearSorting();
                        grdV_img.ClearColumnsFilter();
                        grdV_img.ClearGrouping();
                        (grd_img.MainView as GridView).OptionsPrint.PrintHorzLines = false;
                        XlsxExportOptionsEx advOptions = new XlsxExportOptionsEx();
                        //advOptions.TextExportMode = TextExportMode.Text;
                        advOptions.ExportMode = XlsxExportMode.SingleFile;
                        advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;
                        advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False;
                        advOptions.SheetName = "Data";
                        advOptions.CustomizeCell += AdvOptions_CustomizeCell; ;
                        grd_img.ExportToXlsx(Filename + @"\" + "File_Excel_Data.xlsx" , advOptions);

                        grdV_Error.ClearSorting();
                        grdV_Error.ClearColumnsFilter();
                        grdV_Error.ClearGrouping();
                        (grd_Error.MainView as GridView).OptionsPrint.PrintHeader = true;
                        XlsxExportOptionsEx advOptions_Err = new XlsxExportOptionsEx();
                        advOptions_Err.TextExportMode = TextExportMode.Text;
                        advOptions_Err.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;
                        advOptions_Err.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False;
                        advOptions_Err.SheetName = "Data_Error";

                        advOptions_Err.CustomizeCell += AdvOptions_CustomizeCell_Error; ;
                        grd_Error.ExportToXlsx(Filename + @"\" + "File_Excel_Data_Error.xlsx", advOptions_Err);

                        try
                        {
                            string fullPath = Path.GetDirectoryName(sfd.FileName) + @"\" + Path.GetFileName(sfd.FileName).Split('.')[0].ToString();
                            File.Delete(fullPath + ".txt");
                            File.Delete(fullPath + "_WithPath" + ".txt");
                            int dem = 1;
                            for (int i = 0; i < tb_Result.Rows.Count; i++)
                            {
                                string logd1 = "", logd2 = "";
                                logd1 += hamchung.ThemKyTubatKyStrPhiaSau(hamchung.ToHalfWidth(tb_Result.Rows[i][1].ToString()), 2, " "); //Trường cố định
                                logd1 += hamchung.ThemKyTubatKyStrPhiaSau(hamchung.ToHalfWidth(tb_Result.Rows[i][2].ToString()), 6, " ");//trường No
                                logd1 += hamchung.ThemKyTubatKyStrPhiaSau(hamchung.ToHalfWidth(tb_Result.Rows[i][3].ToString()), 4, " ");//truong code
                                logd1 += hamchung.ThemKyTubatKyStrPhiaSau(hamchung.ToHalfWidth(tb_Result.Rows[i][4].ToString()), 10, " ");//truong 04
                                logd1 += hamchung.ThemKyTubatKyStrPhiaSau(hamchung.ToHalfWidth(tb_Result.Rows[i][5].ToString()), 15, " ");//truong 05
                                logd1 += hamchung.ThemKyTubatKyStrPhiaSau(hamchung.ToHalfWidth(tb_Result.Rows[i][6].ToString()), 2, " ");//truong stt
                                logd1 += hamchung.ThemKyTubatKyStrPhiaSau(hamchung.ToHalfWidth(tb_Result.Rows[i][7].ToString()), 30, " ");//truong 07
                                logd1 += hamchung.ThemKyTubatKyStrPhiaSau(hamchung.ToHalfWidth(tb_Result.Rows[i][8].ToString()), 25, " ");//truong 08
                                if (string.IsNullOrEmpty(tb_Result.Rows[i][9].ToString()))
                                {
                                    logd1 += hamchung.ThemKyTuPhiaTruocVaBoKyTuPhiaSau(hamchung.ToHalfWidth(tb_Result.Rows[i][9].ToString()), 10, " ");
                                }
                                else
                                {
                                    logd1 += hamchung.ThemKyTuPhiaTruocVaBoKyTuPhiaSau(hamchung.ToHalfWidth(tb_Result.Rows[i][9] + ".00"), 10, "0");//truong 9 - số lượng
                                }
                                int a;
                                if (int.TryParse(tb_Result.Rows[i][10].ToString(), out a))
                                {
                                    logd1 += hamchung.ThemKyTuPhiaTruocVaBoKyTuPhiaSau(hamchung.ToHalfWidth(tb_Result.Rows[i][10].ToString()), 2, "0");//truong 10
                                }
                                else
                                {
                                    logd1 += hamchung.ThemKyTubatKyStrPhiaSau(hamchung.ToHalfWidth(tb_Result.Rows[i][10].ToString()), 2, " ");//truong 10
                                }
                                logd1 += hamchung.ThemKyTubatKyStrPhiaSau(hamchung.ToHalfWidth(tb_Result.Rows[i][11].ToString()), 2, " ");//truong 11-mặc định
                                logd1 += hamchung.ThemKyTubatKyStrPhiaSau(hamchung.ToHalfWidth(tb_Result.Rows[i][12].ToString()), 3, " ");//truong 12- phân loại
                                logd1 += hamchung.ThemKyTubatKyStrPhiaSau(tb_Result.Rows[i][13].ToString(), 20, " ");
                                logd1 += hamchung.ThemKyTubatKyStrPhiaSau(tb_Result.Rows[i][14].ToString(), 30, " ");
                                logd1 += hamchung.ThemKyTubatKyStrPhiaSau(tb_Result.Rows[i][15].ToString(), 3, " ");
                                logd1 += hamchung.ThemKyTubatKyStrPhiaSau(tb_Result.Rows[i][16].ToString(), 8, " ");
                                logd1 += hamchung.ThemKyTubatKyStrPhiaSau(tb_Result.Rows[i][17].ToString(), 20, " ");
                                logd1 += hamchung.ThemKyTubatKyStrPhiaSau(tb_Result.Rows[i][18].ToString(), 58, " ");

                                LogFile.WriteLog(fullPath + ".txt", logd1, false);

                                logd2 = logd1 + hamchung.ThemKyTubatKyStrPhiaSau(tb_Result.Rows[i][19].ToString(), 35, " ");
                                LogFile.WriteLog(fullPath + "_WithPath" + ".txt", logd2, false);
                                //}
                                //lb_sodong.Text = (i + 1) +"/"+ (_kq.Rows.Count);
                            }
                            Process.Start(fullPath + ".txt");
                            Process.Start(fullPath + "_WithPath" + ".txt");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Có lỗi xảy ra. Có thể file excel không đúng chuẩn file của dự án Phiếu kiểm kê.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void AdvOptions_CustomizeCell_Error(DevExpress.Export.CustomizeCellEventArgs e)
        {
            e.Formatting.NumberFormat = DevExpress.Export.Xl.XlNumberFormat.Text;
            string link = "";
            if (e.ColumnFieldName == "TRƯỜNG")
            {
                link = Global.StrPath + @"\" + tb_Result_Error.Rows[e.RowHandle]["BatchID"].ToString() + "_" + tb_Result_Error.Rows[e.RowHandle]["BatchName"].ToString() + @"\" + tb_Result_Error.Rows[e.RowHandle]["TRƯỜNG"].ToString();
                e.Hyperlink = link;
            }
            e.Handled = true;
        }

        private void AdvOptions_CustomizeCell(DevExpress.Export.CustomizeCellEventArgs e)
        {
            e.Formatting.NumberFormat = DevExpress.Export.Xl.XlNumberFormat.Text;
            string link = "";
            if (e.ColumnFieldName == "TRƯỜNG")
            {
                link = Global.StrPath + @"\" + tb_Result.Rows[e.RowHandle]["BatchID"].ToString() + "_" + tb_Result.Rows[e.RowHandle]["BatchName"].ToString() + @"\" + tb_Result.Rows[e.RowHandle]["TRƯỜNG"].ToString();
                e.Hyperlink = link;
            }
            e.Handled = true;
        }

        private void DeleteSelectedRows(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            if (view == null || view.SelectedRowsCount == 0) return;
            DataRow[] rows = new DataRow[view.SelectedRowsCount];
            for (int i = 0; i < view.SelectedRowsCount; i++)
                rows[i] = view.GetDataRow(view.GetSelectedRows()[i]);
            view.BeginSort();
            try
            {
                foreach (DataRow row in rows)
                    row.Delete();
            }
            finally
            {
                view.EndSort();
            }
        }
        private void grd_img_EditorKeyDown(object sender, KeyEventArgs e)
        {
            ColumnView View = (ColumnView)grd_img.FocusedView;
            GridColumn column = View.Columns[grdV_img.FocusedColumn.FieldName];
            int row = grdV_img.FocusedRowHandle;
            string name_img = grdV_img.GetRowCellValue(row, tb_Result.Columns[Constant.ImageName].ColumnName).ToString();
            string name_batch = grdV_img.GetRowCellValue(row, tb_Result.Columns[Constant.BatchName].ColumnName).ToString();
            string ID_batch = grdV_img.GetRowCellValue(row, tb_Result.Columns[Constant.BatchID].ColumnName).ToString();
            if (e.Control && e.KeyCode == Keys.Subtract)
            {
                if (row != 0)
                {
                    DeleteSelectedRows(grdV_img);
                    View.FocusedRowHandle = row - 1;
                    View.FocusedColumn = column;
                }
                else
                {
                    MessageBox.Show("Không thể xóa");
                    return;
                }
                change_data_save = true;
                Change_Data_Export(name_img, name_batch, ID_batch);
            }
            //else if (e.KeyCode == Keys.Enter)
            //{                    
            //    if (row < 0)
            //    {
            //        row = 1;
            //    }
            //    if (row == grdV_img.RowCount - 1)
            //    {
            //        View.FocusedRowHandle = row + 1;
            //        View.FocusedColumn = column;
            //        grdV_img.AddNewRow();
            //        View.FocusedRowHandle = row + 1;
            //        View.FocusedColumn = grdV_img.VisibleColumns[0];
            //        Add_InfoRow_Gridcontrol(row);
            //    }
            //    else
            //    {
            //        View.FocusedRowHandle = row + 1;
            //        View.FocusedColumn = column;
            //    }
            //    change_data_save = true;
            //    Change_Data_Export(name_img, name_batch, ID_batch);
            //}
            else if (e.Control && e.KeyCode == Keys.Add)
            {                    
                DataRow dtr = tb_Result.NewRow();
                tb_Result.Rows.InsertAt(dtr, row + 1);
                //dtcopy.Rows.Add();
                //dtcopy.AcceptChanges();
                grd_img.DataSource = null;
                grd_img.DataSource = tb_Result;
                Add_InfoRow_Gridcontrol(row);
                grd_img.Focus();
                View.FocusedRowHandle = row + 1;
                View.FocusedColumn = column;                    
                change_data_save = true;
                Change_Data_Export(name_img, name_batch, ID_batch);
                SendKeys.Send("{F2}");
                SendKeys.Send("{END}");
            }            
        }
        private void Add_InfoRow_Gridcontrol(int row)
        {
            tb_Result.Rows[row + 1][Constant.ImageName] = tb_Result.Rows[row][Constant.ImageName].ToString();
            tb_Result.Rows[row + 1][Constant.Truong01] = tb_Result.Rows[row][Constant.Truong01].ToString();
            tb_Result.Rows[row + 1][Constant.Truong02] = tb_Result.Rows[row][Constant.Truong02].ToString();
            tb_Result.Rows[row + 1][Constant.Truong03] = tb_Result.Rows[row][Constant.Truong03].ToString();
            tb_Result.Rows[row + 1][Constant.Truong04] = tb_Result.Rows[row][Constant.Truong04].ToString();
            tb_Result.Rows[row + 1][Constant.Truong05] = tb_Result.Rows[row][Constant.Truong05].ToString();
            tb_Result.Rows[row + 1][Constant.Truong12] = tb_Result.Rows[row][Constant.Truong12].ToString();
            tb_Result.Rows[row + 1][Constant.path] = tb_Result.Rows[row][Constant.path].ToString();
            tb_Result.Rows[row + 1][Constant.BatchName] = tb_Result.Rows[row][Constant.BatchName].ToString();
            tb_Result.Rows[row + 1][Constant.BatchID] = tb_Result.Rows[row][Constant.BatchID].ToString();
        }
        
        private void btn_Import_txt_Click(object sender, EventArgs e)
        {
            if (grdV_img.RowCount < 1)
            {
                MessageBox.Show("Bảng hiển thị dữ liệu không có thông tin !!!");
                return;
            }
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //string text = File.ReadAllText(textBox1.Text);
                splashScreenManager1.ShowWaitForm();
                using (StreamReader file = new StreamReader(openFileDialog1.FileName))
                {
                    counter = 0;
                    string ln;
                    StringBuilder st = new StringBuilder();
                    numberData = new int[1000000];
                    while ((ln = file.ReadLine()) != null)
                    {
                        if (ln.Substring(0, 2) == "AE")
                        {
                            st.Append(ln + "\n");
                            numberData[counter] = Int32.Parse(ln.Substring(4, 6));                            
                            counter++;
                        }
                    }
                    rtb_txt.Text = st.ToString();
                    file.Close();
                    Console.WriteLine($"File has {counter} lines.");
                }
                //splashScreenManager1.ShowWaitForm();
                lst_Data_Excel_T2 = new List<int>(tb_Result.Rows.Count);
                DataRow[] dtr = tb_Result.Select("["+ tb_Result.Columns[Constant.Truong02].ColumnName+ "] <> ''");
                number_Excel = new int[dtr.Select(x => Convert.ToInt32(x.ItemArray[2].ToString())).Count()];
                number_Excel = dtr.Select(x => Convert.ToInt32(x.ItemArray[2].ToString())).ToArray();
                try { lst_Data_Excel_T2.AddRange(dtr.Select(x => Convert.ToInt32(x.ItemArray[2].ToString())).Distinct()); }
                catch { MessageBox.Show("Tồn tại dữ liệu trường 2 không phải là số !!!");btn_Export.Visible = false; return; }
                splashScreenManager1.CloseWaitForm();
                tb_Sosanh.Clear();
                bgw_CheckData.RunWorkerAsync();
            }
        }

        private void bgw_CheckData_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < lst_Data_Excel_T2.Count; i++)
            {                
                if (numberData.Where(x => x == lst_Data_Excel_T2[i]).Select(x => x).Count() != number_Excel.Where(x => x == lst_Data_Excel_T2[i]).Select(x => x).Count())
                {
                    tb_Sosanh.Rows.Add(lst_Data_Excel_T2[i].ToString(), number_Excel.Where(x => x == lst_Data_Excel_T2[i]).Select(x => x).Count(), numberData.Where(x => x == lst_Data_Excel_T2[i]).Select(x => x).Count());
                }
            }
        }

        private void grdV_CheckTxt_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle > -1)
            {
                string str_truong2 = grdV_CheckTxt.GetRowCellValue(e.FocusedRowHandle, "Data_Truong2").ToString();
                DataRow[] dtr = tb_Result.Select("[" + tb_Result.Columns[Constant.Truong02].ColumnName + "] = '" + str_truong2 + "'");
                int indexRow = tb_Result.Rows.IndexOf(dtr[0]);
                grd_img.Focus();
                grdV_img.FocusedRowHandle = indexRow + Convert.ToInt32(grdV_CheckTxt.GetRowCellValue(e.FocusedRowHandle, "Dòng Dữ liệu").ToString()) -1;
                ColumnView View = (ColumnView)grd_img.FocusedView;
                GridColumn column = View.Columns[tb_Result.Columns[Constant.Truong02].ToString()];
                grdV_img.FocusedColumn = column;
            }
        }

        private void grdV_CheckTxt_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = (DevExpress.XtraGrid.Views.Grid.GridView)sender;
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void grdV_img_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (e.RowHandle > -1)
            {
                string name_img = grdV_img.GetRowCellValue(e.RowHandle, tb_Result.Columns[Constant.ImageName].ColumnName).ToString();
                string name_batch = grdV_img.GetRowCellValue(e.RowHandle, tb_Result.Columns[Constant.BatchName].ColumnName).ToString();
                string ID_batch = grdV_img.GetRowCellValue(e.RowHandle, tb_Result.Columns[Constant.BatchID].ColumnName).ToString();
                Change_Data_Export(name_img, name_batch, ID_batch);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {            
            if (tb_Image_Change.Rows.Count > 0)
            {
                DataTable dt_update = new DataTable();
                dt_update.Columns.Add("ID_Batch");
                dt_update.Columns.Add("Data_update");
                dt_update.Columns.Add("ImageName");
                for (int i = 0; i < tb_Image_Change.Rows.Count; i++)
                {
                    DataRow[] dtr = tb_Result.Select("[TRƯỜNG] = '" + tb_Image_Change.Rows[i]["ImageName"].ToString() + "' and [BatchName] = '" + tb_Result.Rows[i]["BatchName"].ToString() + "'");
                    string Vung1 = dtr[0].ItemArray[Constant.Truong02].ToString() + "†" + dtr[0].ItemArray[Constant.Truong03].ToString() + "†" + dtr[0].ItemArray[Constant.Truong04].ToString() + "†" + dtr[0].ItemArray[Constant.Truong05].ToString();
                    string str_SaveData = "";
                    if (rdb_AE.Checked)
                    {
                        List<string> lst_Data = new List<string>();
                        foreach (var item in dtr)
                        {
                            lst_Data.Add(item.ItemArray[Constant.Truong09].ToString());
                        }
                        str_SaveData = Vung1 + "‡" + String.Join("†", lst_Data);
                    }
                    else if (rdb_AT.Checked)
                    { //‡
                        List<string> lst_Data = new List<string>();
                        foreach (var item in dtr)
                        {
                            lst_Data.Add(item.ItemArray[Constant.Truong07] + "†" + item.ItemArray[Constant.Truong10] + "†" + item.ItemArray[Constant.Truong08] + "†" + item.ItemArray[Constant.Truong09]);
                        }
                        str_SaveData = Vung1 + "‡" + String.Join("‡", lst_Data);
                    }
                    dt_update.Rows.Add(dtr[0].ItemArray[Constant.BatchID].ToString(), str_SaveData, dtr[0].ItemArray[Constant.ImageName].ToString());
                }
                try
                {
                    string ConnectionString = Global.ConnectionString;
                    SqlConnection con = new SqlConnection(ConnectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Export_Update_ChangeData", con);
                    cmd.Parameters.Clear();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 60 * 60;                    
                    cmd.Parameters.AddWithValue("@table_truyen", dt_update).SqlDbType = SqlDbType.Structured;
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception exx)
                {
                    MessageBox.Show("Upload Data Error --> Try Again !!! \r\n " + exx.ToString());
                    return;
                }
                MessageBox.Show("Upload Data Complete and Perform Data Load !!!");
                btn_View_Click(null, null);
            }
            btn_Export.Visible = true;
            btn_Export.Enabled = true;
        }

        private void grdV_img_DoubleClick(object sender, EventArgs e)
        {
            if (grdV_img.FocusedRowHandle >= 0)
            {//Global.StrPath + @"\" + item.ID_Batch + "_" + item.BatchName + @"\" + item.ImageName;
                string nameImg = Global.StrPath + @"\" + grdV_img.GetFocusedRowCellValue("BatchID").ToString() + "_" + grdV_img.GetFocusedRowCellValue("BatchName").ToString() + @"\" + grdV_img.GetFocusedRowCellValue("TRƯỜNG").ToString();
                Process.Start(nameImg);
            }
        }

        private void grdV_Error_DoubleClick(object sender, EventArgs e)
        {
            if (grdV_Error.FocusedRowHandle >= 0)
            {//Global.StrPath + @"\" + item.ID_Batch + "_" + item.BatchName + @"\" + item.ImageName;
                string nameImg = Global.StrPath + @"\" + grdV_Error.GetFocusedRowCellValue("BatchID").ToString() + "_" + grdV_Error.GetFocusedRowCellValue("BatchName").ToString() + @"\" + grdV_Error.GetFocusedRowCellValue("TRƯỜNG").ToString();
                Process.Start(nameImg);
            }
        }

        private void bgw_CheckData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (tb_Sosanh.Rows.Count > 0)
            {
                grd_CheckTxt.DataSource = null;
                grd_CheckTxt.DataSource = tb_Sosanh;
                MessageBox.Show("Dữ liệu lệch ... Vui lòng kiểm tra lại !!!");
            }
            else
            {
                grd_CheckTxt.DataSource = null;
                MessageBox.Show("Không có dữ liệu lệch !!!");
            }
        }
        private void Change_Data_Export(string name_img, string BatchName, string ID_Batch)
        {
            if (tb_Image_Change.Select("ImageName = '"+ name_img + "' and BatchName = '"+ BatchName + "'").Length > 0)
            {
                int indexRow = tb_Image_Change.Rows.IndexOf(tb_Image_Change.Select("ImageName = '" + name_img + "' and BatchName = '" + BatchName + "'")[0]);
                tb_Image_Change.Rows.RemoveAt(indexRow);
            }
            tb_Image_Change.Rows.Add(name_img, BatchName);
        }
    }
}
