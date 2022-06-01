using DevExpress.Export;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using HIKARI_HTO_VER2.LinqToSQLProcess;
using HIKARI_HTO_VER2.ModuleProcessUtil;
using HIKARI_HTO_VER2.MyForm;
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
    public partial class UC_Admin_Pfm : UserControl
    {
        Admin_info admin_info;
        
        public UC_Admin_Pfm()
        {
            InitializeComponent();
            admin_info = new Admin_info();
            admin_info.dt_pfm_Entry = new DataTable();
            admin_info.dt_pfm_Entry.Columns.Add("UserName");
            admin_info.dt_pfm_Entry.Columns.Add("Nhân Viên");
            admin_info.dt_pfm_Entry.Columns.Add("Tổng dòng nhập",typeof(double));
            admin_info.dt_pfm_Entry.Columns.Add("Số dòng đúng", typeof(double));
            admin_info.dt_pfm_Entry.Columns.Add("Số dòng sai", typeof(double));
            admin_info.dt_pfm_Entry.Columns.Add("Thời gian (h)", typeof(double));
            admin_info.dt_pfm_Entry.Columns.Add("Hiệu Suất (%)", typeof(double));
            admin_info.dt_pfm_Entry.Columns.Add("Năng Suất", typeof(double));

            admin_info.dt_pfm_Check = new DataTable();
            admin_info.dt_pfm_Check.Columns.Add("UserName");
            admin_info.dt_pfm_Check.Columns.Add("Nhân Viên");
            admin_info.dt_pfm_Check.Columns.Add("Tổng phiếu xử lý", typeof(double));
            admin_info.dt_pfm_Check.Columns.Add("Thời gian (h)", typeof(double));
            admin_info.dt_pfm_Check.Columns.Add("Năng Suất", typeof(double));

            admin_info.dt_pfm_LastCheck = new DataTable();
            admin_info.dt_pfm_LastCheck.Columns.Add("UserName");
            admin_info.dt_pfm_LastCheck.Columns.Add("Nhân Viên");
            admin_info.dt_pfm_LastCheck.Columns.Add("Thời gian (h)", typeof(double));
        }
        int tiendo_View = 0;
        
        private void btn_View_Click(object sender, EventArgs e)
        {            
            admin_info.Time_Start = dtpk_pfm_1.Value.ToString("yyyy-MM-dd ") + time_Start.Text + ":00";
            admin_info.Time_End = dtpk_pfm_2.Value.ToString("yyyy-MM-dd ") + Time_End.Text + ":59";
            if (DateTime.Parse(admin_info.Time_Start) > DateTime.Parse(admin_info.Time_End))
            {
                MessageBox.Show("Thời gian được chọn sai !!!");
                return;
            }                      
            if (rdb_Entry.Checked) // Tính PFM của Entry
            {
                admin_info.Str_Select_Pfm = "Entry";
                admin_info.dt_pfm_Entry.Clear();
                DataTable pfm_AE = new DataTable();
                DataTable pfm_AT = new DataTable();
                pfm_AE = admin_info.dt_pfm_Entry.Clone();
                pfm_AT = admin_info.dt_pfm_Entry.Clone();
                DataTable dt_Entry = new DataTable();
                string ConnectionString = Global.ConnectionString;
                SqlConnection con = new SqlConnection(ConnectionString);
                SqlCommand cmd = new SqlCommand("Admin_Pfm_GetData", con);
                try
                {
                    DataSet ds = new DataSet();                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 60 * 60;
                    cmd.Parameters.AddWithValue("@style_Pfm", "ENTRY");
                    cmd.Parameters.AddWithValue("@Time_Start", admin_info.Time_Start);
                    cmd.Parameters.AddWithValue("@Time_End", admin_info.Time_End);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    dt_Entry = ds.Tables[0];
                    con.Close();
                }
                catch (Exception ex)
                {
                    con.Close(); MessageBox.Show(ex.ToString());
                }
                if (dt_Entry.Rows.Count > 0)
                {                    
                    for (int i = 0; i < dt_Entry.Rows.Count; i++)
                    {
                        if (dt_Entry.Rows[i]["LoaiNhap"].ToString() == "AE")
                        {
                            dt_Entry.Rows[i]["ContentE"] = (dt_Entry.Rows[i]["ContentE"].ToString().Split('‡')[1].Split('†').Where(x => x.ToString() != "").Count() + 1).ToString();                            
                        }
                        else
                        {
                            dt_Entry.Rows[i]["ContentE"] = "11";                            
                        }                        
                    }
                    var results = from status in dt_Entry.AsEnumerable()
                                  group status by (status.Field<string>("UserName"),status.Field<string>("LoaiNhap")) into status
                                  select new
                                  {              
                                      UserName = status.Select(x => x.Field<string>("UserName")).FirstOrDefault(),
                                      Fullname = status.Select(x => x.Field<string>("FullName")).FirstOrDefault(),
                                      Tongtruong = status.Select(x => Convert.ToInt32(x.Field<string>("ContentE"))).Sum(),
                                      Loisai = status.Select(x => x.Field<int>("Error_Entry")).Sum(),
                                      Thoigian = ((status.Select(x => x.Field<int>("TimeEntry")).Sum()) / 1000.0) / 360,
                                      LoaiNhap = status.Select(x => x.Field<string>("LoaiNhap")).FirstOrDefault(),
                                  };
                    double FullTruong = results.Sum(x => x.Tongtruong);
                    double FullLoisai = results.Sum(x => x.Loisai);
                    double FullThoigian = results.Sum(x => x.Thoigian);
                    foreach (var element in results)
                    {                                                
                        if (element.LoaiNhap == "AE")
                        {
                            var rowindex = pfm_AE.NewRow(); 
                            rowindex["UserName"] = element.UserName;
                            rowindex["Nhân Viên"] = element.Fullname;
                            rowindex["Tổng dòng nhập"] = element.Tongtruong;
                            rowindex["Số dòng đúng"] = Convert.ToInt32(element.Tongtruong - element.Loisai);
                            rowindex["Số dòng sai"] = element.Loisai;
                            rowindex["Thời gian (h)"] = Math.Round(element.Thoigian, 2);
                            rowindex["Hiệu Suất (%)"] = Math.Round((Convert.ToDouble(element.Tongtruong - element.Loisai) / element.Tongtruong) * 100, 2);
                            rowindex["Năng Suất"] = Math.Round((Convert.ToDouble(element.Tongtruong) / element.Thoigian), 2);
                            pfm_AE.Rows.Add(rowindex);//Năng Suất (%)
                        }
                        else
                        {
                            var rowindex = pfm_AT.NewRow();
                            rowindex["UserName"] = element.UserName;
                            rowindex["Nhân Viên"] = element.Fullname;
                            rowindex["Tổng dòng nhập"] = element.Tongtruong;
                            rowindex["Số dòng đúng"] = Convert.ToInt32(element.Tongtruong - element.Loisai);
                            rowindex["Số dòng sai"] = element.Loisai;
                            rowindex["Thời gian (h)"] = Math.Round(element.Thoigian, 2);
                            rowindex["Hiệu Suất (%)"] = Math.Round((Convert.ToDouble(element.Tongtruong - element.Loisai) / element.Tongtruong) * 100, 2);
                            rowindex["Năng Suất"] = Math.Round((Convert.ToDouble(element.Tongtruong) / element.Thoigian), 2);
                            pfm_AT.Rows.Add(rowindex);
                        }
                    } 
                    #region Tính tổng thông số cho AE
                    if (pfm_AE.Rows.Count > 0)
                    {
                        DataRow newRow = pfm_AE.NewRow();
                        DataRow newRow1 = pfm_AE.NewRow();
                        DataRow newRow2 = pfm_AE.NewRow();
                        DataRow newRow3 = pfm_AE.NewRow();
                        DataRow newRow4 = pfm_AE.NewRow();
                        // Tính ra thông số Max, Min, Avgs
                        newRow1[1] = "Cao nhất";
                        newRow1[2] = pfm_AE.Compute("Max ([Tổng dòng nhập])", "");
                        newRow1[3] = pfm_AE.Compute("Max ([Số dòng đúng])", "");
                        newRow1[4] = pfm_AE.Compute("Max ([Số dòng sai])", "");
                        newRow1[5] = pfm_AE.Compute("Max ([Thời gian (h)])", "");
                        newRow1[6] = pfm_AE.Compute("Max ([Hiệu Suất (%)])", "");

                        newRow2[1] = "Thấp nhất";
                        newRow2[2] = pfm_AE.Compute("Min ([Tổng dòng nhập])", "");
                        newRow2[3] = pfm_AE.Compute("Min ([Số dòng đúng])", "");
                        newRow2[4] = pfm_AE.Compute("Min ([Số dòng sai])", "");
                        newRow2[5] = pfm_AE.Compute("Min ([Thời gian (h)])", "");
                        newRow2[6] = pfm_AE.Compute("Min ([Hiệu Suất (%)])", "");

                        try
                        {
                            newRow3[1] = "Trung bình";
                            newRow3[2] = Math.Round(double.Parse(pfm_AE.Compute("Avg ([Tổng dòng nhập])", "").ToString()), 0);
                            newRow3[3] = Math.Round(double.Parse(pfm_AE.Compute("Avg ([Số dòng đúng])", "").ToString()), 0);
                            newRow3[4] = Math.Round(double.Parse(pfm_AE.Compute("Avg ([Số dòng sai])", "").ToString()), 0);
                            newRow3[5] = Math.Round(double.Parse(pfm_AE.Compute("Avg ([Thời gian (h)])", "").ToString()), 2);
                            newRow3[6] = Math.Round(double.Parse(pfm_AE.Compute("Avg ([Hiệu Suất (%)])", "").ToString()), 2);
                        }
                        catch
                        {  }
                        pfm_AE.Rows.Add(newRow); pfm_AE.Rows.Add(newRow1); pfm_AE.Rows.Add(newRow2); pfm_AE.Rows.Add(newRow3); pfm_AE.Rows.Add(newRow4);
                        DataRow newRow5 = pfm_AE.NewRow();
                        DataRow newRow6 = pfm_AE.NewRow();
                        pfm_AE.Rows.Add(newRow5);                        
                        newRow6[1] = "ALL";
                        newRow6[2] = FullTruong;
                        newRow6[3] = (FullTruong - FullLoisai).ToString();
                        newRow6[4] = FullLoisai.ToString();
                        newRow6[5] = Math.Round(FullThoigian, 2);
                        newRow6[6] = Math.Round((Convert.ToDouble(FullTruong - FullLoisai) / FullTruong)*100, 2);
                        pfm_AE.Rows.Add(newRow6);
                    }
                    #endregion

                    #region Tính tổng thông số cho AT
                    if (pfm_AT.Rows.Count >0)
                    {
                        DataRow newRow = pfm_AT.NewRow();
                        DataRow newRow1 = pfm_AT.NewRow();
                        DataRow newRow2 = pfm_AT.NewRow();
                        DataRow newRow3 = pfm_AT.NewRow();
                        DataRow newRow4 = pfm_AT.NewRow();
                        // Tính ra thông số Max, Min, Avgs
                        newRow1[1] = "Cao nhất";
                        newRow1[2] = pfm_AT.Compute("Max ([Tổng dòng nhập])", "");
                        newRow1[3] = pfm_AT.Compute("Max ([Số dòng đúng])", "");
                        newRow1[4] = pfm_AT.Compute("Max ([Số dòng sai])", "");
                        newRow1[5] = pfm_AT.Compute("Max ([Thời gian (h)])", "");
                        newRow1[6] = pfm_AT.Compute("Max ([Hiệu Suất (%)])", "");

                        newRow2[1] = "Thấp nhất";
                        newRow2[2] = pfm_AT.Compute("Min ([Tổng dòng nhập])", "");
                        newRow2[3] = pfm_AT.Compute("Min ([Số dòng đúng])", "");
                        newRow2[4] = pfm_AT.Compute("Min ([Số dòng sai])", "");
                        newRow2[5] = pfm_AT.Compute("Min ([Thời gian (h)])", "");
                        newRow2[6] = pfm_AT.Compute("Min ([Hiệu Suất (%)])", "");

                        try
                        {
                            newRow3[1] = "Trung bình";
                            newRow3[2] = Math.Round(double.Parse(pfm_AT.Compute("Avg ([Tổng dòng nhập])", "").ToString()), 0);
                            newRow3[3] = Math.Round(double.Parse(pfm_AT.Compute("Avg ([Số dòng đúng])", "").ToString()), 0);
                            newRow3[4] = Math.Round(double.Parse(pfm_AT.Compute("Avg ([Số dòng sai])", "").ToString()), 0);
                            newRow3[5] = Math.Round(double.Parse(pfm_AT.Compute("Avg ([Thời gian (h)])", "").ToString()), 2);
                            newRow3[6] = Math.Round(double.Parse(pfm_AT.Compute("Avg ([Hiệu Suất (%)])", "").ToString()), 2);
                        }
                        catch
                        { }
                        pfm_AT.Rows.Add(newRow); pfm_AT.Rows.Add(newRow1); pfm_AT.Rows.Add(newRow2); pfm_AT.Rows.Add(newRow3); pfm_AT.Rows.Add(newRow4);
                        DataRow newRow5 = pfm_AT.NewRow();
                        DataRow newRow6 = pfm_AT.NewRow();
                        pfm_AE.Rows.Add(newRow5);                        
                        newRow6[1] = "ALL";
                        newRow6[2] = FullTruong;
                        newRow6[3] = (FullTruong - FullLoisai).ToString();
                        newRow6[4] = FullLoisai.ToString();
                        newRow6[5] = Math.Round(FullThoigian, 2);
                        newRow6[6] = Math.Round((Convert.ToDouble(FullTruong - FullLoisai) / FullTruong) * 100, 2);
                        pfm_AE.Rows.Add(newRow6);
                    }
                    grdV_pfm_AE.Columns.Clear();
                    grd_pfm_AE.DataSource = null;
                    grd_pfm_AE.DataSource = pfm_AE;

                    grdV_pfm_AT.Columns.Clear();
                    grd_pfm_AT.DataSource = null;
                    grd_pfm_AT.DataSource = pfm_AT;
                    #endregion                    
                }
                else { MessageBox.Show("Không có thông tin Performance !!!");return; }
            }
            else if (rdb_Check.Checked) // Tính PFM của Checker
            {
                admin_info.Str_Select_Pfm = "Check";
                admin_info.dt_pfm_Check.Clear();                            
                DataTable dt_Checker = new DataTable();
                string ConnectionString = Global.ConnectionString;
                SqlConnection con = new SqlConnection(ConnectionString);
                SqlCommand cmd = new SqlCommand("Admin_Pfm_Checker", con);
                try
                {
                    DataSet ds = new DataSet();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 60 * 60;                    
                    cmd.Parameters.AddWithValue("@Time_Start", admin_info.Time_Start);
                    cmd.Parameters.AddWithValue("@Time_End", admin_info.Time_End);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    dt_Checker = ds.Tables[0];
                    con.Close();
                }
                catch (Exception ex)
                {
                    con.Close(); MessageBox.Show(ex.ToString());
                }
                var results = from status in dt_Checker.AsEnumerable()
                              group status by (status.Field<string>("UserName")) into status
                              select new
                              {
                                  UserName = status.Select(x => x.Field<string>("UserName")).FirstOrDefault(),
                                  Fullname = status.Select(x => x.Field<string>("FullName")).FirstOrDefault(),
                                  Tongtruong = status.Select(x => x.Field<string>("UserName")).Count(),                                  
                                  Thoigian = ((status.Select(x => x.Field<int>("TimeEntry")).Sum()) / 1000.0) / 360,                                  
                              };
                double FullTruong = results.Sum(x => x.Tongtruong);                
                double FullThoigian = results.Sum(x => x.Thoigian);
                foreach (var element in results)
                {                    
                    var rowindex = admin_info.dt_pfm_Check.NewRow();
                    rowindex[admin_info.dt_pfm_Check.Columns[0].ToString()] = element.UserName;
                    rowindex[admin_info.dt_pfm_Check.Columns[1].ToString()] = element.Fullname;
                    rowindex[admin_info.dt_pfm_Check.Columns[2].ToString()] = element.Tongtruong;
                    rowindex[admin_info.dt_pfm_Check.Columns[3].ToString()] = element.Thoigian;
                    rowindex[admin_info.dt_pfm_Check.Columns[4].ToString()] = Math.Round((Convert.ToDouble(element.Tongtruong) / element.Thoigian) , 2);
                    admin_info.dt_pfm_Check.Rows.Add(rowindex);     
                }
                DataRow newRow = admin_info.dt_pfm_Check.NewRow();
                DataRow newRow1 = admin_info.dt_pfm_Check.NewRow();
                DataRow newRow2 = admin_info.dt_pfm_Check.NewRow();
                DataRow newRow3 = admin_info.dt_pfm_Check.NewRow();
                DataRow newRow4 = admin_info.dt_pfm_Check.NewRow();
                // Tính ra thông số Max, Min, Avgs
                newRow1[1] = "Cao nhất";
                newRow1[2] = admin_info.dt_pfm_Check.Compute("Max (["+ admin_info.dt_pfm_Check.Columns[2].ToString() + "])", "");
                newRow1[3] = admin_info.dt_pfm_Check.Compute("Max ([" + admin_info.dt_pfm_Check.Columns[3].ToString() + "])", "");
                newRow1[4] = admin_info.dt_pfm_Check.Compute("Max ([" + admin_info.dt_pfm_Check.Columns[4].ToString() + "])", "");
                newRow2[1] = "Thấp nhất";
                newRow2[2] = admin_info.dt_pfm_Check.Compute("Min ([" + admin_info.dt_pfm_Check.Columns[2].ToString() + "])", "");
                newRow2[3] = admin_info.dt_pfm_Check.Compute("Min ([" + admin_info.dt_pfm_Check.Columns[3].ToString() + "])", "");
                newRow2[4] = admin_info.dt_pfm_Check.Compute("Min ([" + admin_info.dt_pfm_Check.Columns[4].ToString() + "])", "");
                try
                {
                    newRow3[1] = "Trung bình";
                    newRow3[2] = Math.Round(double.Parse(admin_info.dt_pfm_Check.Compute("Avg ([" + admin_info.dt_pfm_Check.Columns[2].ToString() + "])", "").ToString()), 0);
                    newRow3[3] = Math.Round(double.Parse(admin_info.dt_pfm_Check.Compute("Avg ([" + admin_info.dt_pfm_Check.Columns[3].ToString() + "])", "").ToString()), 0);
                    newRow3[4] = Math.Round(double.Parse(admin_info.dt_pfm_Check.Compute("Avg ([" + admin_info.dt_pfm_Check.Columns[4].ToString() + "])", "").ToString()), 0);
                }
                catch
                { }
                admin_info.dt_pfm_Check.Rows.Add(newRow); admin_info.dt_pfm_Check.Rows.Add(newRow1); admin_info.dt_pfm_Check.Rows.Add(newRow2); admin_info.dt_pfm_Check.Rows.Add(newRow3); admin_info.dt_pfm_Check.Rows.Add(newRow4);
                DataRow newRow5 = admin_info.dt_pfm_Check.NewRow();
                DataRow newRow6 = admin_info.dt_pfm_Check.NewRow();
                admin_info.dt_pfm_Check.Rows.Add(newRow5);
                newRow6[1] = "ALL";
                newRow6[2] = FullTruong;                
                newRow6[3] = FullThoigian.ToString();
                admin_info.dt_pfm_Check.Rows.Add(newRow6);
                grdV_pfm_AE.Columns.Clear();
                grdV_pfm_AT.Columns.Clear();
                grd_pfm_AE.DataSource = null;
                grd_pfm_AE.DataSource = admin_info.dt_pfm_LastCheck;

            }
            else if (rdb_LastCheck.Checked) // Tính PFM của LastCheck
            {
                admin_info.Str_Select_Pfm = "LastCheck";
                admin_info.dt_pfm_LastCheck.Clear();
                DataTable dt_Checker = new DataTable();
                string ConnectionString = Global.ConnectionString;
                SqlConnection con = new SqlConnection(ConnectionString);
                SqlCommand cmd = new SqlCommand("Admin_Pfm_LC", con);
                try
                {
                    DataSet ds = new DataSet();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 60 * 60;
                    cmd.Parameters.AddWithValue("@Time_Start", admin_info.Time_Start);
                    cmd.Parameters.AddWithValue("@Time_End", admin_info.Time_End);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    dt_Checker = ds.Tables[0];
                    con.Close();
                }
                catch (Exception ex)
                {
                    con.Close(); MessageBox.Show(ex.ToString());
                }
                var results = from status in dt_Checker.AsEnumerable()
                              group status by (status.Field<string>("UserName")) into status
                              select new
                              {
                                  UserName = status.Select(x => x.Field<string>("UserName")).FirstOrDefault(),
                                  Fullname = status.Select(x => x.Field<string>("FullName")).FirstOrDefault(),
                                  Thoigian = ((status.Select(x => x.Field<int>("Time_LC")).Sum())),
                              };
                double FullThoigian = results.Sum(x => x.Thoigian);
                foreach (var element in results)
                {
                    var rowindex = admin_info.dt_pfm_LastCheck.NewRow();
                    rowindex[admin_info.dt_pfm_LastCheck.Columns[0].ToString()] = element.UserName;
                    rowindex[admin_info.dt_pfm_LastCheck.Columns[1].ToString()] = element.Fullname;
                    rowindex[admin_info.dt_pfm_LastCheck.Columns[2].ToString()] = Math.Round(Convert.ToDouble(element.Thoigian) / 3600, 2);
                    admin_info.dt_pfm_LastCheck.Rows.Add(rowindex);
                }
                grdV_pfm_AE.Columns.Clear();
                grdV_pfm_AT.Columns.Clear();
                grd_pfm_AE.DataSource = null;
                grd_pfm_AE.DataSource = admin_info.dt_pfm_LastCheck;
            }
            //MessageBox.Show("Show Performance Complete !!!");            
        }

        private void UC_PfmAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void dtpk_pfm_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Files |*.xlsx";
            sfd.Title = "Save an Excel File";
            sfd.FileName = "Export_Pfm_" + admin_info.Str_Select_Pfm + "";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (admin_info.Str_Select_Pfm == "Entry")
                {
                    (grd_pfm_AE.MainView as GridView).OptionsPrint.PrintHeader = true;
                    XlsxExportOptionsEx advOptions = new XlsxExportOptionsEx();
                    advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;
                    advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False;
                    advOptions.ExportType = ExportType.WYSIWYG;
                    advOptions.SheetName = "Pfm_AE" + admin_info.Str_Select_Pfm + "";
                    grd_pfm_AE.ExportToXlsx(sfd.FileName, advOptions);

                    (grd_pfm_AT.MainView as GridView).OptionsPrint.PrintHeader = true;
                    XlsxExportOptionsEx advOptions_AT = new XlsxExportOptionsEx();
                    advOptions_AT.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;
                    advOptions_AT.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False;
                    advOptions_AT.ExportType = ExportType.WYSIWYG;
                    advOptions_AT.SheetName = "Pfm_AT" + admin_info.Str_Select_Pfm + "";
                    grd_pfm_AT.ExportToXlsx(sfd.FileName, advOptions_AT);
                }
                else
                {
                    (grd_pfm_AE.MainView as GridView).OptionsPrint.PrintHeader = true;
                    XlsxExportOptionsEx advOptions = new XlsxExportOptionsEx();
                    advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;
                    advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False;
                    advOptions.ExportType = ExportType.WYSIWYG;
                    advOptions.SheetName = "Pfm_" + admin_info.Str_Select_Pfm + "";
                    grd_pfm_AE.ExportToXlsx(sfd.FileName, advOptions);
                }
            }
            #region 
            //if (rdb_Entry.Checked)
            //{
            //    if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Productivity.xlsx"))
            //    {
            //        File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Productivity.xlsx");
            //        File.WriteAllBytes((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Productivity.xlsx"), Properties.Resources.productivity);
            //    }
            //    else
            //    {
            //        File.WriteAllBytes((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Productivity.xlsx"), Properties.Resources.productivity);
            //    }
            //    TableToExcel(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Productivity.xlsx");
            //}
            //else
            //{

            //}
            #endregion            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {            
            //for (int i = 0; i < dt_pfm.Rows.Count; i++)
            //{
            //    //int sodongE1 =  dt_pfm.Rows[i]["ContentE1"].ToString().Split('‡')[1].Split('†')
            //}
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (progressBar1.Maximum == tiendo_View)
            {
                MessageBox.Show("Show Performance Entry !!!");
            }
        }
        private void phancheck()
        {
            //var results = from status in dtp.AsEnumerable()
            //              group status by (status.Field<string>("MSNV")) into status
            //              select new
            //              {
            //                  Fullname = status.Select(x => x.Field<string>("FullName")).FirstOrDefault(),
            //                  Trungtam = status.Select(x => x.Field<string>("Trung Tâm")).FirstOrDefault(),
            //                  Tongtruong = status.Select(x => x.Field<string>("MSNV")).Count(),
            //                  Loisai = status.Select(x => x.Field<int>("Lỗi sai")).Sum(),
            //                  Thoigian = ((status.Select(x => x.Field<int>("Thời gian")).Sum()) / 1000.0) / 60,
            //                  NotGood = status.Select(x => x.Field<int>("NGP")).Where(x => x != 0).Count(),
            //              };
            //double tongall = results.Sum(x => x.Tongtruong);
            //double tongls = results.Sum(x => x.Loisai);
            //double tongtg = Math.Round(results.Sum(x => x.Thoigian), 2);
            //double tongtruong = results.Sum(x => x.Tongtruong);
            //double tongng = results.Sum(x => x.NotGood);
            //prgbExcel.Invoke((System.Action)(() =>
            //{
            //    prgbExcel.Maximum = results.Count();
            //}));
            //foreach (var element in results)
            //{
            //    var rowindex = dtPFMP.NewRow();
            //    rowindex["Họ và tên"] = element.Fullname;
            //    rowindex["Trung tâm"] = element.Trungtam;
            //    rowindex["Tổng ký tự"] = element.Tongtruong;
            //    rowindex["Lỗi sai"] = element.Loisai;
            //    rowindex["Tỷ lệ sai(%)"] = Math.Round((element.Loisai / Convert.ToDouble(element.Tongtruong)) * 100, 2);
            //    rowindex["Thời gian(phút)"] = Math.Round(element.Thoigian, 2);
            //    rowindex["Tốc độ(ký tự/phút)"] = Math.Round(Convert.ToDouble(element.Tongtruong) / element.Thoigian, 2);
            //    rowindex["Đảm nhận(%)"] = Math.Round((element.Tongtruong / tongtruong) * 100, 2);
            //    rowindex["Tổng trường"] = element.Tongtruong;
            //    rowindex["Tổng trường notgood"] = element.Tongtruong;
            //    rowindex["Tỷ lệ NG"] = element.NotGood;
            //    //// Làm thêm:
            //    System.Data.DataTable dtsum = new System.Data.DataTable(); System.Data.DataTable dtsumcheck = new System.Data.DataTable(); System.Data.DataTable dtsumqc = new System.Data.DataTable();
            //    try
            //    {
            //        dtsum = dtout.Select("Fullname = '" + element.Fullname + "' and Lvl = 0 and Name like 'P%'").CopyToDataTable();

            //        //sumObject = dtsum.Compute("Sum(Timeout)", string.Empty);ErrorLc
            //        rowindex["Tổng Thời gian"] = Convert.ToDouble(Math.Round(Convert.ToInt32(dtsum.Compute("Sum ([Timeout])", "").ToString()) / 60000.0, 2).ToString()) + Convert.ToDouble(Math.Round(element.Thoigian, 2));
            //    }
            //    catch
            //    { rowindex["Tổng Thời gian"] = Math.Round(element.Thoigian, 2); }
            //    try { dtsumcheck = dtout.Select("Fullname = '" + element.Fullname + "' and Lvl = 1 and LevelLC = 1 and Name like 'P%' ").CopyToDataTable(); rowindex["Lỗi sai so với LC (nội dung qua checker)"] = dtsumcheck.Compute("Sum ([ErrorLc])", "").ToString(); }
            //    catch { rowindex["Lỗi sai so với LC (nội dung qua checker)"] = "0"; }
            //    //// Hết thêm
            //    dtPFMP.Rows.Add(rowindex);
            //}
            //DataRow newRow = dtPFMP.NewRow();
            //DataRow newRow1 = dtPFMP.NewRow();
            //DataRow newRow2 = dtPFMP.NewRow();
            //DataRow newRow3 = dtPFMP.NewRow();
            //DataRow newRow4 = dtPFMP.NewRow();
            ////Max,Min,average 
            //newRow1[1] = "Cao nhất";
            //newRow1[2] = dtPFMP.Compute("Max ([Tổng ký tự])", "");
            //newRow1[3] = dtPFMP.Compute("Max ([Lỗi sai])", "");
            //newRow1[4] = dtPFMP.Compute("Max ([Tỷ lệ sai(%)])", "");
            //newRow1[5] = dtPFMP.Compute("Max ([Thời gian(phút)])", "");
            //newRow1[6] = dtPFMP.Compute("Max ([Tốc độ(ký tự/phút)])", "");
            //newRow1[7] = dtPFMP.Compute("Max ([Đảm nhận(%)])", "");
            //newRow1[8] = dtPFMP.Compute("Max ([Tổng trường])", "");
            //newRow1[9] = dtPFMP.Compute("Max ([Tổng trường notgood])", "");
            //newRow1[10] = dtPFMP.Compute("Max ([Tỷ lệ NG])", "");
            //newRow2[1] = "Thấp nhất";
            //newRow2[2] = dtPFMP.Compute("Min ([Tổng ký tự])", "");
            //newRow2[3] = dtPFMP.Compute("Min ([Lỗi sai])", "");
            //newRow2[4] = dtPFMP.Compute("Min ([Tỷ lệ sai(%)])", "");
            //newRow2[5] = dtPFMP.Compute("Min ([Thời gian(phút)])", "");
            //newRow2[6] = dtPFMP.Compute("Min ([Tốc độ(ký tự/phút)])", "");
            //newRow2[7] = dtPFMP.Compute("Min ([Đảm nhận(%)])", "");
            //newRow2[8] = dtPFMP.Compute("Min ([Tổng trường])", "");
            //newRow2[9] = dtPFMP.Compute("Min ([Tổng trường notgood])", "");
            //newRow2[10] = dtPFMP.Compute("Min ([Tỷ lệ NG])", "");
            //try
            //{
            //    newRow3[1] = "Trung bình";
            //    newRow3[2] = Math.Round(double.Parse(dtPFMP.Compute("Avg ([Tổng ký tự])", "").ToString()), 0);
            //    newRow3[3] = Math.Round(double.Parse(dtPFMP.Compute("Avg ([Lỗi sai])", "").ToString()), 0);
            //    newRow3[4] = Math.Round(double.Parse(dtPFMP.Compute("Avg ([Tỷ lệ sai(%)])", "").ToString()), 2);
            //    newRow3[5] = Math.Round(double.Parse(dtPFMP.Compute("Avg ([Thời gian(phút)])", "").ToString()), 0);
            //    newRow3[6] = Math.Round(double.Parse(dtPFMP.Compute("Avg ([Tốc độ(ký tự/phút)])", "").ToString()), 0);
            //    newRow3[7] = Math.Round(double.Parse(dtPFMP.Compute("Avg ([Đảm nhận(%)])", "").ToString()), 0);
            //    newRow3[8] = Math.Round(double.Parse(dtPFMP.Compute("Avg ([Tổng trường])", "").ToString()), 0);
            //    newRow3[9] = Math.Round(double.Parse(dtPFMP.Compute("Avg ([Tổng trường notgood])", "").ToString()), 0);
            //    newRow3[10] = Math.Round(double.Parse(dtPFMP.Compute("Avg ([Tỷ lệ NG])", "").ToString()), 0);
            //}
            //catch
            //{
            //}
            //dtPFMP.Rows.Add(newRow);
            //dtPFMP.Rows.Add(newRow1);
            //dtPFMP.Rows.Add(newRow2);
            //dtPFMP.Rows.Add(newRow3);
            //if (trungtam == "ALL")
            //{
            //    DataRow newRow5 = dtPFMP.NewRow();
            //    DataRow newRow7 = dtPFMP.NewRow();
            //    DataRow newRow8 = dtPFMP.NewRow();
            //    dtPFMP.Rows.Add(newRow5);
            //    newRow7[1] = "ALL";
            //    newRow7[2] = tongtruong;
            //    newRow7[3] = tongls;
            //    newRow7[4] = Math.Round(tongls / tongtg, 2);
            //    newRow7[5] = tongtg;
            //    newRow7[6] = Math.Round(tongtruong / tongtg, 2);
            //    newRow7[7] = Math.Round((tongtruong / tongall) * 100, 2);
            //    newRow7[8] = tongtruong;
            //    newRow7[9] = tongng;
            //    newRow7[10] = Math.Round((tongng / tongtruong) * 100, 2);
            //    dtPFMP.Rows.Add(newRow7);
            //    string tkuGroup = dtPFMP.Compute("COUNT ([Trung tâm])", "[Trung tâm] = 'DN'").ToString();
            //    if (tkuGroup != "0" && tkuGroup != "")
            //    {
            //        string timeGroup = dtPFMP.Compute("Sum ([Thời gian(phút)])", "[Trung tâm] = 'DN'").ToString();
            //        double tlsGroup = double.Parse(dtPFMP.Compute("Sum ([Lỗi sai])", "[Trung tâm] = 'DN'").ToString());
            //        double tongtruongdn = double.Parse(dtPFMP.Compute("Sum ([Tổng trường])", "[Trung tâm] = 'DN'").ToString());
            //        double tongngdn = double.Parse(dtPFMP.Compute("SUM ([Tổng trường notgood])", "[Trung tâm] = 'DN'").ToString());
            //        newRow8[1] = "DN";
            //        newRow8[2] = tkuGroup;
            //        newRow8[3] = tlsGroup;
            //        newRow8[4] = Math.Round(tlsGroup / Convert.ToDouble(tkuGroup), 2);
            //        newRow8[5] = timeGroup;
            //        newRow8[6] = Math.Round(Convert.ToDouble(tkuGroup) / Convert.ToDouble(timeGroup), 2);
            //        newRow8[7] = Math.Round(Convert.ToDouble(tkuGroup) / tongall, 2);
            //        newRow8[8] = tongtruongdn;
            //        newRow8[9] = tongngdn;
            //        newRow8[10] = Math.Round((tongngdn / tongtruongdn) * 100, 2);
            //        dtPFMP.Rows.Add(newRow8);
            //    }
            //    tkuGroup = dtPFMP.Compute("Sum ([Tổng trường])", "[Trung tâm] = 'HUE'").ToString();
            //    if (tkuGroup != "0" && tkuGroup != "")
            //    {
            //        newRow8 = dtPFMP.NewRow();
            //        string timeGroup = dtPFMP.Compute("Sum ([Thời gian(phút))", "[Trung tâm] = 'HUE'").ToString();
            //        double tlsGroup = double.Parse(dtPFMP.Compute("Sum ([Lỗi sai])", "[Trung tâm] = 'HUE'").ToString());
            //        double tongtruonghue = double.Parse(dtPFMP.Compute("Sum ([Tổng trường])", "[Trung tâm] = 'HUE'").ToString());
            //        double tongnghue = double.Parse(dtPFMP.Compute("SUM ([Tổng trường notgood])", "[Trung tâm] = 'HUE'").ToString());
            //        newRow8[1] = "HUE";
            //        newRow8[2] = tkuGroup;
            //        newRow8[3] = tlsGroup;
            //        newRow8[4] = Math.Round(tlsGroup / Convert.ToDouble(tkuGroup), 2);
            //        newRow8[5] = timeGroup;
            //        newRow8[6] = Math.Round(Convert.ToDouble(tkuGroup) / Convert.ToDouble(timeGroup), 2);
            //        newRow8[7] = Math.Round(Convert.ToDouble(tkuGroup) / tongall, 2);
            //        newRow8[8] = tongtruonghue;
            //        newRow8[9] = tongnghue;
            //        newRow8[10] = Math.Round((tongtruonghue / tongnghue) * 100, 2);
            //        dtPFMP.Rows.Add(newRow8);
            //    }
            //    tkuGroup = dtPFMP.Compute("Sum ([Tổng trường])", "[Trung tâm] = 'PY'").ToString();
            //    if (tkuGroup != "0" && tkuGroup != "")
            //    {
            //        newRow8 = dtPFMP.NewRow();
            //        string timeGroup = dtPFMP.Compute("Sum ([Thời gian(phút)])", "[Trung tâm] = 'PY'").ToString();
            //        double tlsGroup = double.Parse(dtPFMP.Compute("Sum ([Lỗi sai])", "[Trung tâm] = 'PY'").ToString());
            //        double tongtruongpy = double.Parse(dtPFMP.Compute("Sum ([Tổng trường])", "[Trung tâm] = 'PY'").ToString());
            //        double tongngpy = double.Parse(dtPFMP.Compute("SUM ([Tổng trường notgood])", "[Trung tâm] = 'PY'").ToString());
            //        newRow8[1] = "PY";
            //        newRow8[2] = tkuGroup;
            //        newRow8[3] = tlsGroup;
            //        newRow8[4] = Math.Round(tlsGroup / Convert.ToDouble(tkuGroup), 2);
            //        newRow8[5] = timeGroup;
            //        newRow8[6] = Math.Round(Convert.ToDouble(tkuGroup) / Convert.ToDouble(timeGroup), 2);
            //        newRow8[7] = Math.Round(Convert.ToDouble(tkuGroup) / tongall, 2);
            //        newRow8[8] = tongtruongpy;
            //        newRow8[9] = tongngpy;
            //        newRow8[10] = Math.Round((tongtruongpy / tongngpy) * 100, 2);
            //        dtPFMP.Rows.Add(newRow8);
            //    }
            //    tkuGroup = dtPFMP.Compute("Sum ([Tổng trường])", "[Trung tâm] = 'DL'").ToString();
            //    if (tkuGroup != "0" && tkuGroup != "")
            //    {
            //        newRow8 = dtPFMP.NewRow();
            //        string timeGroup = dtPFMP.Compute("Sum ([Thời gian(phút)])", "[Trung tâm] = 'DL'").ToString();
            //        double tlsGroup = double.Parse(dtPFMP.Compute("Sum ([Lỗi sai])", "[Trung tâm] = 'DL'").ToString());
            //        double tongtruongdl = double.Parse(dtPFMP.Compute("Sum ([Tổng trường])", "[Trung tâm] = 'DL'").ToString());
            //        double tongngdl = double.Parse(dtPFMP.Compute("SUM ([Tổng trường notgood])", "[Trung tâm] = 'DL'").ToString());
            //        newRow8[1] = "DL";
            //        newRow8[2] = tkuGroup;
            //        newRow8[3] = tlsGroup;
            //        newRow8[4] = Math.Round(tlsGroup / Convert.ToDouble(tkuGroup), 2);
            //        newRow8[5] = timeGroup;
            //        newRow8[6] = Math.Round(Convert.ToDouble(tkuGroup) / Convert.ToDouble(timeGroup), 2);
            //        newRow8[7] = Math.Round(Convert.ToDouble(tkuGroup) / tongall, 2);
            //        newRow8[8] = tongtruongdl;
            //        newRow8[9] = tongngdl;
            //        newRow8[10] = Math.Round((tongtruongdl / tongngdl) * 100, 2);
            //        dtPFMP.Rows.Add(newRow8);
            //    }
            //}
            //else
            //{
            //    DataRow newRow5 = dtPFMP.NewRow();
            //    DataRow newRow6 = dtPFMP.NewRow();
            //    DataRow newRow7 = dtPFMP.NewRow();
            //    dtPFMP.Rows.Add(newRow5);
            //    dtPFMP.Rows.Add(newRow6);
            //    newRow7[1] = trungtam;
            //    newRow7[2] = tongtruong;
            //    newRow7[3] = tongls;
            //    newRow7[5] = tongtg;
            //    newRow7[8] = tongtruong;
            //    newRow7[9] = tongng;
            //    dtPFMP.Rows.Add(newRow7);
            //}
            //worker.ReportProgress(dtPFMP.Rows.Count);
        }

        Microsoft.Office.Interop.Excel.Application app = null;
        Microsoft.Office.Interop.Excel.Workbook book = null;
        Microsoft.Office.Interop.Excel.Worksheet wrksheet = null;
        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        private void TableToExcel(string strfilename)
        {
            try
            {
                lb_SoLuong.Text = "";
                progressBar1.Step = 1;
                progressBar1.Value = 0;
                progressBar1.Maximum = grdV_pfm_AE.RowCount; /*+ dataGridView4.RowCount + dataGridView5.RowCount*/;
                progressBar1.Minimum = 0;
                progressBar1.Visible = true;
                ModifyProgressBarColor.SetState(progressBar1, 1);
                app = new Microsoft.Office.Interop.Excel.Application();

                book = app.Workbooks.Open(strfilename, 0, true, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);

                wrksheet = (Microsoft.Office.Interop.Excel.Worksheet)book.Sheets["AE"];
                int h = 1, n = 0;
                wrksheet.Cells[1, 1] = "BÁO CÁO HIỆU SUẤT DỰ ÁN HTO 2022 - " + admin_info.dataDetail;
                wrksheet.Cells[2, 10] = "Thời gian:" + time_Start.Text + "/" + dtpk_pfm_1.Value.ToString("dd/MM/yyyy") + " đến " + Time_End.Text + "/" + dtpk_pfm_2.Value.ToString("dd/MM/yyyyy");

                for (int i = 0; i < grdV_pfm_AE.RowCount; i++)
                {
                    wrksheet.Cells[h + 2, 1] = h;
                    wrksheet.Cells[h + 2, 2] = grdV_pfm_AE.GetRowCellValue(i, admin_info.dt_pfm_Entry.Columns[0].ToString()).ToString() + "";//username
                    wrksheet.Cells[h + 2, 3] = grdV_pfm_AE.GetRowCellValue(i, admin_info.dt_pfm_Entry.Columns[1].ToString()).ToString() + "";//fullname
                    wrksheet.Cells[h + 2, 4] = grdV_pfm_AE.GetRowCellValue(i, admin_info.dt_pfm_Entry.Columns[2].ToString()).ToString() + "";//tong
                    wrksheet.Cells[h + 2, 5] = grdV_pfm_AE.GetRowCellValue(i, admin_info.dt_pfm_Entry.Columns[3].ToString()).ToString() + "";//phieudung
                    wrksheet.Cells[h + 2, 6] = grdV_pfm_AE.GetRowCellValue(i, admin_info.dt_pfm_Entry.Columns[4].ToString()).ToString() + "";//phieusai
                    wrksheet.Cells[h + 2, 7] = grdV_pfm_AE.GetRowCellValue(i, admin_info.dt_pfm_Entry.Columns[5].ToString()).ToString() + "";//thoigian
                    wrksheet.Cells[h + 2, 8] = grdV_pfm_AE.GetRowCellValue(i, admin_info.dt_pfm_Entry.Columns[6].ToString()).ToString() + "";//hieusuat
                    wrksheet.Cells[h + 2, 9] = grdV_pfm_AE.GetRowCellValue(i, admin_info.dt_pfm_Entry.Columns[7].ToString()).ToString() + "";//nangsuat
                    h++;
                    progressBar1.PerformStep();
                    lb_SoLuong.Text = ++n + @"\" + progressBar1.Maximum;
                }

                wrksheet = (Microsoft.Office.Interop.Excel.Worksheet)book.Sheets["AT"];
                h = 1;
                wrksheet.Cells[1, 1] = "BÁO CÁO HIỆU SUẤT DỰ ÁN HTO 2022 - " + admin_info.dataTitle;
                wrksheet.Cells[2, 10] = "Thời gian:" + time_Start.Text + "/" + dtpk_pfm_1.Value.ToString("dd/MM/yyyy") + " đến " + Time_End.Text + "/" + dtpk_pfm_2.Value.ToString("dd/MM/yyyyy");
                for (int i = 0; i < grdV_pfm_AT.RowCount; i++)
                {
                    wrksheet.Cells[h + 2, 1] = h;
                    wrksheet.Cells[h + 2, 2] = grdV_pfm_AT.GetRowCellValue(i, admin_info.dt_pfm_Entry.Columns[0].ToString()).ToString() + "";//username
                    wrksheet.Cells[h + 2, 3] = grdV_pfm_AT.GetRowCellValue(i, admin_info.dt_pfm_Entry.Columns[1].ToString()).ToString() + "";//fullname
                    wrksheet.Cells[h + 2, 4] = grdV_pfm_AT.GetRowCellValue(i, admin_info.dt_pfm_Entry.Columns[2].ToString()).ToString() + "";//tong
                    wrksheet.Cells[h + 2, 5] = grdV_pfm_AT.GetRowCellValue(i, admin_info.dt_pfm_Entry.Columns[3].ToString()).ToString() + "";//phieudung
                    wrksheet.Cells[h + 2, 6] = grdV_pfm_AT.GetRowCellValue(i, admin_info.dt_pfm_Entry.Columns[4].ToString()).ToString() + "";//phieusai
                    wrksheet.Cells[h + 2, 7] = grdV_pfm_AT.GetRowCellValue(i, admin_info.dt_pfm_Entry.Columns[5].ToString()).ToString() + "";//thoigian
                    wrksheet.Cells[h + 2, 8] = grdV_pfm_AT.GetRowCellValue(i, admin_info.dt_pfm_Entry.Columns[6].ToString()).ToString() + "";//hieusuat
                    wrksheet.Cells[h + 2, 9] = grdV_pfm_AE.GetRowCellValue(i, admin_info.dt_pfm_Entry.Columns[7].ToString()).ToString() + "";//nangsuat
                    h++;
                    progressBar1.PerformStep();
                    lb_SoLuong.Text = ++n + @"\" + progressBar1.Maximum;
                }
                string savePath;

                saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Title = @"Save Excel Files";
                saveFileDialog1.Filter = @"Excel files (*.xlsx)|*.xlsx";
                saveFileDialog1.FileName = "NangSuat_HTO2022_" + dtpk_pfm_1.Value.ToString("ddMM") + "-" + dtpk_pfm_2.Value.ToString("ddMM");
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    book.SaveCopyAs(saveFileDialog1.FileName);
                    book.Saved = true;
                    savePath = Path.GetDirectoryName(saveFileDialog1.FileName);
                    MessageBox.Show(@"Xuất file excel thành công!");
                    Process.Start(savePath);
                }
                else
                {
                    MessageBox.Show(@"Xuất file excel không thành công !");
                    return;
                }
                if (savePath != null) Process.Start(savePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                progressBar1.Visible = false;
                lb_SoLuong.Text = "";
                if (book != null)
                    book.Close(false);
                if (app != null)
                    app.Quit();
                if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Productivity.xlsx"))
                {
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Productivity.xlsx");
                }
                if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + saveFileDialog1.FileName))
                {
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + saveFileDialog1.FileName);
                }
            }
        }
    }
}
