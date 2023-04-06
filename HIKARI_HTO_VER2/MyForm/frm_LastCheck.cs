using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using HIKARI_HTO_VER2.LinqToSQLProcess;
using HIKARI_HTO_VER2.ModuleProcessUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIKARI_HTO_VER2.MyForm
{
    public partial class frm_LastCheck : Form
    {
        using_Tb_Data using_data;
        LastCheck_info lc_info;        
        bool change_data_save = false;
        bool change = false;
        bool Done_batch = true;
        DateTime dtime_now = new DateTime();
        public frm_LastCheck()
        {
            InitializeComponent();
            using_data = new using_Tb_Data();
            lc_info = new LastCheck_info();            
        }
        int StartLC = 0;
        private void btn_start_Click(object sender, EventArgs e)
        {
            if (btn_start.Text == "Start LastCheck")
            {
                if (MessageBox.Show("Bạn muốn thực hiện LastCheck Batch: " + Global.BatchNameSelected + "", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    splashScreenManager1.ShowWaitForm();
                    btn_start.Text = "Done Batch";
                    btn_SaveData.Enabled = true;
                    btn_CheckLogic.Enabled = true;
                    DataTable dt_Data_batch = new DataTable();
                    dt_Data_batch = using_data.LC_GetData_batch(Convert.ToInt32(Global.BatchIDSelected), Global.strUsername, Global.Level_Image);
                    if (dt_Data_batch.Rows.Count > 0)
                    {
                        StartLC = 1;
                        Creater_Columns_Table(Global.BatchTypeSelected);                        
                        dt_Data_batch.Columns.Add("Select_Row");
                        dt_Data_batch.Columns.Add("Changed_Data");
                        lc_info.Tb_Data_Batch = dt_Data_batch;
                        grd_Image.DataSource = null;
                        grd_Image.DataSource = lc_info.Tb_Data_Batch;                        
                        grdV_Image.Columns["ID"].Visible = false;
                        grdV_Image.Columns["Content_E1"].Visible = false;
                        grdV_Image.Columns["Content_E2"].Visible = false;
                        grdV_Image.Columns["Content_Check"].Visible = false;
                        grdV_Image.Columns["Content_LC"].Visible = false;
                        grdV_Image.Columns["Select_Row"].Visible = false;
                        grdV_Image.Columns["Changed_Data"].Visible = false;
                    }
                    else
                    {
                        splashScreenManager1.CloseWaitForm();
                        MessageBox.Show("Batch này đang có người LastCheck !!!");
                        dtime_now = DateTime.Now;
                        this.Close(); return;
                    }
                    btn_CheckLogic_Click(null, null);
                    splashScreenManager1.CloseWaitForm();
                }
                else
                {
                    StartLC = 3;
                    this.Close();
                }
            }
            else if (btn_start.Text == "Done Batch")
            {
                StartLC = 2;
                this.Close();
            }
            dtime_now = DateTime.Now;
        }

        private void frm_LastCheck_Load(object sender, EventArgs e)
        {
            lb_BatchName.Text = "BatchName: " + Global.BatchNameSelected;
            btn_CheckLogic.Enabled = false;
            btn_SaveData.Enabled = false;
            if (Global.BatchNameSelected == "" || Convert.ToInt32(Global.BatchIDSelected) < 1 )
            {
                MessageBox.Show("Batch được chọn đang có thông tin bị sai --> Auto Exit !!!");
                this.Close();
            }
            splitContainerControl3.SplitterPosition = splitContainerControl3.Height - 10;
            dtime_now = DateTime.Now;
        }

        private void bgw_Load_Data_DoWork(object sender, DoWorkEventArgs e)
        {
        }

        private void bgw_Load_Data_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }

        private void frm_LastCheck_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (change_data_save)
            {
                var Question = MessageBox.Show("Bạn có Sửa dữ liệu --> Thực hiện Save Data ???", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ;
                if (Question == DialogResult.Yes)
                {
                    btn_SaveData_Click(null, null);
                }                 
            }
            if (StartLC == 1)
            {
                var Question = MessageBox.Show("Thoát phiên LastCheck Batch " + Global.BatchNameSelected + "", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Question == DialogResult.Yes)
                {
                    GlobalDB.DBLinq.LC_Exit_Batch(Global.BatchIDSelected, "Exit", "1");
                }
                else
                {
                    e.Cancel = true;
                }
                //MessageBox.Show("Bạn chưa nhấn nút Done Batch hoàn thành !!!","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                //e.Cancel = true;
            }
            else if (StartLC == 2)
            {
                GlobalDB.DBLinq.LC_Exit_Batch(Global.BatchIDSelected, "OK", "1");
            }
            else
            {
                return;
            }
            TimeSpan Tsp = new TimeSpan();
            Tsp = DateTime.Now - dtime_now;
            int time_Lc = Convert.ToInt32(Tsp.TotalSeconds);
            string dtime = dtime_now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            GlobalDB.DBLinq.LC_Update_Info_LC(Global.BatchIDSelected, Global.strUsername, time_Lc.ToString(), dtime);

        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            
        }

        private void grdV_Image_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int row = e.FocusedRowHandle;
            string ImageName = grdV_Image.GetRowCellValue(row, "NameImage").ToString();
            lc_info.index_Click = row;
            Show_image_Data(row, ImageName);            
            string path_webservice = Global.Webservice + Global.BatchIDSelected + "_" + Global.BatchNameSelected + @"/" + ImageName;
            try
            {
                System.Net.WebRequest request = System.Net.WebRequest.Create(path_webservice);
                System.Net.WebResponse response = request.GetResponse();
                System.IO.Stream responseStream = response.GetResponseStream();
                Bitmap Source_Image = new Bitmap(responseStream);
                ImgV.Dispose();
                ImgV.Image = Source_Image;                
            }
            catch
            {
                MessageBox.Show("Load ảnh có vấn đề !!! \r\n" + Global.BatchIDSelected + "_" + Global.BatchNameSelected + @"/" + ImageName);
                return;
            }
            lc_info.Tb_Data_Batch.Rows[row]["Select_Row"] = "1";
        }

        private DataTable Function_Data(string Data_content)
        {
            DataTable dt = new DataTable();
            dt = lc_info.Tb_Cloumns.Clone();
            if (Global.BatchTypeSelected == "AE")
            {
                for (int i = 0; i < Data_content.Split('‡')[1].Split('†').Count(); i++)
                {
                    dt.Rows.Add(Data_content.Split('‡')[0].Split('†')[0].ToString(),
                        Data_content.Split('‡')[0].Split('†')[1].ToString(),
                        Data_content.Split('‡')[0].Split('†')[2].ToString(),
                        Data_content.Split('‡')[0].Split('†')[3].ToString(),
                        Data_content.Split('‡')[1].Split('†')[i].ToString());
                }
            }
            else if (Global.BatchTypeSelected == "AT")
            {
                for (int i = 1; i < Data_content.Split('‡').Count(); i++)
                {
                    dt.Rows.Add(Data_content.Split('‡')[0].Split('†')[0].ToString(),
                        Data_content.Split('‡')[0].Split('†')[1].ToString(),
                        Data_content.Split('‡')[0].Split('†')[2].ToString(),
                        Data_content.Split('‡')[0].Split('†')[3].ToString(),
                        Data_content.Split('‡')[i].Split('†')[0].ToString(),
                        Data_content.Split('‡')[i].Split('†')[1].ToString(),
                        Data_content.Split('‡')[i].Split('†')[2].ToString(),
                        Data_content.Split('‡')[i].Split('†')[3].ToString());
                }
            }
            return dt;
        }
        void Creater_Columns_Table(string Style_columns)
        {
            lc_info.Tb_Cloumns = new DataTable();
            if (Style_columns == "AE")
            {
                lc_info.Tb_Cloumns.Columns.Add("Truong:2");
                lc_info.Tb_Cloumns.Columns.Add("Truong:3");
                lc_info.Tb_Cloumns.Columns.Add("Truong:4"); 
                lc_info.Tb_Cloumns.Columns.Add("Truong:5");
                lc_info.Tb_Cloumns.Columns.Add("Truong:9");
            }
            else if (Style_columns == "AT")
            {
                lc_info.Tb_Cloumns.Columns.Add("Truong:2");
                lc_info.Tb_Cloumns.Columns.Add("Truong:3");
                lc_info.Tb_Cloumns.Columns.Add("Truong:4");
                lc_info.Tb_Cloumns.Columns.Add("Truong:5");
                lc_info.Tb_Cloumns.Columns.Add("Truong:7");
                lc_info.Tb_Cloumns.Columns.Add("Truong:10");
                lc_info.Tb_Cloumns.Columns.Add("Truong:8");
                lc_info.Tb_Cloumns.Columns.Add("Truong:9");
            }
            //lc_info.Tb_ContenE1 = lc_info.Tb_Cloumns.Clone();
            //lc_info.Tb_ContenE2 = lc_info.Tb_Cloumns.Clone();
            lc_info.Tb_ContenCheck = lc_info.Tb_Cloumns.Clone();
            lc_info.Tb_LC = lc_info.Tb_Cloumns.Clone();
        }
        private void Show_image_Data(int Index_Row, string name_iamge)
        {            
            lc_info.Tb_ContenCheck.Clear();
            lc_info.Tb_LC.Clear();
            //lc_info.Tb_ContenE1 = Function_Data(dt_Data_batch.Rows[Index_Row]["Content_E1"].ToString());
            //lc_info.Tb_ContenE2 = Function_Data(dt_Data_batch.Rows[Index_Row]["Content_E2"].ToString());
            lc_info.Tb_ContenCheck = Function_Data(lc_info.Tb_Data_Batch.Rows[Index_Row]["Content_Check"].ToString());
            lc_info.Tb_LC = Function_Data(lc_info.Tb_Data_Batch.Rows[Index_Row]["Content_LC"].ToString());
            
            grd_Data.DataSource = null;
            grd_Data.DataSource = lc_info.Tb_LC;            
        }
        private void grdV_Image_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                if (e.RowHandle >= 0)
                {
                    if (grdV_Image.GetRowCellValue(e.RowHandle, grdV_Image.Columns["Select_Row"]).ToString() == "1")//lc_info.Tb_LC.Rows[e.RowHandle]["Select_Row"].ToString() == "1")
                    {
                        if (e.Column.FieldName == "NameImage")
                        {
                            e.Appearance.BackColor = Color.SteelBlue;
                        }
                    }
                }
            }
            catch { }            
        }

        private void grdV_Data_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle > -1)
            {
                try
                {
                    if (lc_info.Tb_LC.Rows[e.RowHandle][e.Column.FieldName].ToString() != lc_info.Tb_ContenCheck.Rows[e.RowHandle][e.Column.FieldName].ToString())
                    {
                        e.Appearance.BackColor = Color.LightSkyBlue;
                    }
                }
                catch
                {
                    e.Appearance.BackColor = Color.LightSkyBlue;
                }
                
            }
        }

        private void grdV_Data_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.RowHandle > -1)
            {
                change = true;
                change_data_save = true;
            }
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
        private void grd_Data_EditorKeyDown(object sender, KeyEventArgs e)
        {
            ColumnView View = (ColumnView)grd_Data.FocusedView;
            GridColumn column = View.Columns[grdV_Data.FocusedColumn.FieldName];
            int row = grdV_Data.FocusedRowHandle;            
            
            if (e.Control && e.KeyCode == Keys.Subtract)
            {
                if (row != 0)
                {
                    DeleteSelectedRows(grdV_Data);
                    View.FocusedRowHandle = row - 1;
                    View.FocusedColumn = grdV_Data.VisibleColumns[1];
                }
                else
                {
                    MessageBox.Show("Không thể xóa");
                    return;
                }
                change = true;
                change_data_save = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (row >= 9)
                {
                    return;
                }
                if (row < 0)
                {
                    row = 1;
                }
                if (row == grdV_Data.RowCount - 1)
                {
                    View.FocusedRowHandle = row + 1;
                    View.FocusedColumn = column;
                    grdV_Data.AddNewRow();
                    View.FocusedRowHandle = row + 1;
                    View.FocusedColumn = grdV_Data.VisibleColumns[0];
                }
                else
                {
                    View.FocusedRowHandle = row + 1;
                    View.FocusedColumn = column;
                }
                lc_info.Tb_LC.Rows[row + 1]["Truong:2"] = lc_info.Tb_LC.Rows[row]["Truong:2"].ToString();
                lc_info.Tb_LC.Rows[row + 1]["Truong:3"] = lc_info.Tb_LC.Rows[row]["Truong:3"].ToString();
                lc_info.Tb_LC.Rows[row + 1]["Truong:4"] = lc_info.Tb_LC.Rows[row]["Truong:4"].ToString();
                lc_info.Tb_LC.Rows[row + 1]["Truong:5"] = lc_info.Tb_LC.Rows[row]["Truong:5"].ToString();
                change = true;
                change_data_save = true;
            }
            else if (e.Control && e.KeyCode == Keys.Add)
            {
                DataRow dtr = lc_info.Tb_LC.NewRow();
                lc_info.Tb_LC.Rows.InsertAt(dtr, row + 1);
                //dtcopy.Rows.Add();
                //dtcopy.AcceptChanges();
                grd_Data.DataSource = null;
                grd_Data.DataSource = lc_info.Tb_LC;
                lc_info.Tb_LC.Rows[row + 1]["Truong:2"] = lc_info.Tb_LC.Rows[row]["Truong:2"].ToString();
                lc_info.Tb_LC.Rows[row + 1]["Truong:3"] = lc_info.Tb_LC.Rows[row]["Truong:3"].ToString();
                lc_info.Tb_LC.Rows[row + 1]["Truong:4"] = lc_info.Tb_LC.Rows[row]["Truong:4"].ToString();
                lc_info.Tb_LC.Rows[row + 1]["Truong:5"] = lc_info.Tb_LC.Rows[row]["Truong:5"].ToString();
                grd_Data.Focus();
                View.FocusedRowHandle = row + 1;
                View.FocusedColumn = column;
                change = true;
                change_data_save = true;
                SendKeys.Send("{F2}");
                SendKeys.Send("{END}");
            }            
        }
        private void grdV_Image_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = (DevExpress.XtraGrid.Views.Grid.GridView)sender;
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void grdV_Data_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = (DevExpress.XtraGrid.Views.Grid.GridView)sender;
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void grdV_CheckLogic_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = (DevExpress.XtraGrid.Views.Grid.GridView)sender;
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void grdV_Data_ShowingEditor(object sender, CancelEventArgs e)
        {
            ColumnView View = (ColumnView)grd_Data.FocusedView;
            GridColumn column = View.Columns[grdV_Data.FocusedColumn.FieldName];
            if (grdV_Data.FocusedRowHandle > 0)
            {
                if (grdV_Data.FocusedColumn.FieldName == "Truong:2" || grdV_Data.FocusedColumn.FieldName == "Truong:3" || grdV_Data.FocusedColumn.FieldName == "Truong:4" || grdV_Data.FocusedColumn.FieldName == "Truong:5")
                {
                    e.Cancel = true;
                }
            }
        }

        private void btn_CheckLogic_Click(object sender, EventArgs e)
        {
            Done_batch = false;
            if (lc_info.Tb_Data_Batch.Rows.Count > 0)
            {
                lc_info.Tb_CheckLogic = new DataTable();
                lc_info.Tb_CheckLogic.Columns.Add("NameImage");
                lc_info.Tb_CheckLogic.Columns.Add("Status Error");
                lc_info.Tb_CheckLogic.Columns.Add("Index_Image");
                lc_info.Tb_CheckLogic.Columns.Add("Index_Row");
                lc_info.Tb_CheckLogic.Columns.Add("Index_Columns");
                lc_info.Tb_CheckLogic.Columns.Add("Select_Index_Error");
                if (Global.BatchTypeSelected == "AE")
                {
                    lc_info.Tb_Data_QuetLogic = new DataTable();
                    lc_info.Tb_Data_QuetLogic = lc_info.Tb_Cloumns.Clone();
                    for (int i = 0; i < lc_info.Tb_Data_Batch.Rows.Count; i++)
                    {
                        lc_info.Tb_Data_QuetLogic.Clear();
                        string nameimage = lc_info.Tb_Data_Batch.Rows[i]["NameImage"].ToString();
                        lc_info.Tb_Data_QuetLogic = Function_Data(lc_info.Tb_Data_Batch.Rows[i]["Content_LC"].ToString());
                        for (int t = 0; t < lc_info.Tb_Data_QuetLogic.Columns.Count; t++)
                        {
                            if (t < 4)
                            {
                                if(t == 0) // Check thông tin trường 2
                                {
                                    if (lc_info.Tb_Data_QuetLogic.Rows[0][t].ToString() == "")
                                    {
                                        lc_info.Tb_CheckLogic.Rows.Add(nameimage, "Dữ liệu Trường 2 trống", i, 0, t);
                                    }
                                    else if (lc_info.Tb_Data_QuetLogic.Rows[0][t].ToString().Length != 6)
                                    {
                                        lc_info.Tb_CheckLogic.Rows.Add(nameimage, "Dữ liệu Trường 2 khác 6 kí tự", i, 0, t);
                                        Done_batch = true;
                                    }
                                }
                                else if (t == 1) // Check thông tin trường 3
                                {
                                    if (lc_info.Tb_Data_QuetLogic.Rows[0][t].ToString().Length != 4 && lc_info.Tb_Data_QuetLogic.Rows[0][t].ToString().Length != 0)
                                    {
                                        lc_info.Tb_CheckLogic.Rows.Add(nameimage, "Dữ liệu Trường 3 khác 4 kí tự", i, 0, t);
                                    }
                                    if (Regex.Matches(lc_info.Tb_Data_QuetLogic.Rows[0][t].ToString(), @"[0-9]").Count != lc_info.Tb_Data_QuetLogic.Rows[0][t].ToString().Length ) //int errorCounter = Regex.Matches(test, @"[a-zA-Z]").Count;
                                    {
                                        lc_info.Tb_CheckLogic.Rows.Add(nameimage, "Dữ liệu Trường 3 có kí tự khác số", i, 0, t);
                                    }                                    
                                }
                                else if (t == 2) // Check thông tin trường 4
                                {

                                }
                                else if (t == 3) // Check thông tin trường 5
                                {

                                }
                                if (lc_info.Tb_Data_QuetLogic.Rows[0][t].ToString().Contains("?")) 
                                {
                                    lc_info.Tb_CheckLogic.Rows.Add(nameimage, "Dữ liệu chứa dấu ?", i, 0, t);
                                    Done_batch = true;
                                }
                            }
                            else // Check thông tin trường 9
                            {
                                for (int z = 0; z < lc_info.Tb_Data_QuetLogic.Rows.Count; z++)
                                {
                                    if (lc_info.Tb_Data_QuetLogic.Rows[z][t].ToString().Contains("?"))
                                    {
                                        lc_info.Tb_CheckLogic.Rows.Add(nameimage, "Dữ liệu chứa dấu ?", i, z, t);
                                        Done_batch = true;
                                    }
                                    if (lc_info.Tb_Data_QuetLogic.Rows[z][t].ToString().ToUpper() == "T")
                                    {
                                        lc_info.Tb_CheckLogic.Rows.Add(nameimage, "Dữ liệu chứa kí tự 'T'", i, z, t);
                                        Done_batch = true;
                                    }
                                }
                            }
                            
                        }
                    }
                }
                else if (Global.BatchTypeSelected == "AT")
                {
                    lc_info.Tb_Data_QuetLogic = new DataTable();
                    lc_info.Tb_Data_QuetLogic = lc_info.Tb_Cloumns.Clone();
                    for (int i = 0; i < lc_info.Tb_Data_Batch.Rows.Count; i++)
                    {
                        lc_info.Tb_Data_QuetLogic.Clear();
                        string nameimage = lc_info.Tb_Data_Batch.Rows[i]["NameImage"].ToString();
                        lc_info.Tb_Data_QuetLogic = Function_Data(lc_info.Tb_Data_Batch.Rows[i]["Content_LC"].ToString());
                        
                        for (int t = 0; t < lc_info.Tb_Data_QuetLogic.Columns.Count; t++)
                        {
                            if(t < 4)
                            {
                                if (t == 0) // Check thông tin trường 2
                                {
                                    if (lc_info.Tb_Data_QuetLogic.Rows[0][t].ToString() == "")
                                    {
                                        lc_info.Tb_CheckLogic.Rows.Add(nameimage, "Dữ liệu Trường 2 trống", i, 0, t);
                                    }
                                    else if (lc_info.Tb_Data_QuetLogic.Rows[0][t].ToString().Length != 6)
                                    {
                                        lc_info.Tb_CheckLogic.Rows.Add(nameimage, "Dữ liệu Trường 2 khác 6 kí tự", i, 0, t);
                                        Done_batch = true;
                                    }
                                }
                                else {                                    
                                    if (lc_info.Tb_Data_QuetLogic.Rows[0][t].ToString().Contains("?") == true)
                                    {
                                        lc_info.Tb_CheckLogic.Rows.Add(nameimage, "Dữ liệu Trường " + (t + 2).ToString() + " có kí tự '?'", i, 0, t);
                                    }
                                }
                                //else if (t == 1) // Check thông tin trường 3
                                //{
                                //    if (lc_info.Tb_Data_QuetLogic.Rows[0][t].ToString().Length != 4)
                                //    {
                                //        lc_info.Tb_CheckLogic.Rows.Add(nameimage, "Dữ liệu Trường 3 khác 4 kí tự", i, 0, t);
                                //    }
                                //    if (Regex.Matches(lc_info.Tb_Data_QuetLogic.Rows[0][t].ToString(), @"[0-9]").Count != lc_info.Tb_Data_QuetLogic.Rows[0][t].ToString().Length) //int errorCounter = Regex.Matches(test, @"[a-zA-Z]").Count;
                                //    {
                                //        lc_info.Tb_CheckLogic.Rows.Add(nameimage, "Dữ liệu Trường 3 có kí tự khác số", i, 0, t);
                                //    }
                                //}
                            }
                            else
                            {
                                bool number_T7 = true;
                                for (int z = 0; z < lc_info.Tb_Data_QuetLogic.Rows.Count; z++)
                                {
                                    if (lc_info.Tb_Data_QuetLogic.Columns[t].ColumnName == "Truong:7")
                                    {
                                        if (number_T7 == true)
                                        {
                                            if (lc_info.Tb_Data_QuetLogic.Rows[z][t].ToString().ToUpper() == "KAKISONJI" || lc_info.Tb_Data_QuetLogic.Rows[z][t].ToString().ToUpper() == "MISIYO")
                                            {
                                                if (lc_info.Tb_Data_QuetLogic.Rows[0][1].ToString() != "" || lc_info.Tb_Data_QuetLogic.Rows[0][2].ToString() != "" || lc_info.Tb_Data_QuetLogic.Rows[0][3].ToString() != "")
                                                {
                                                    //lc_info.Tb_CheckLogic.Rows.Add(nameimage, "Dữ liệu Trường 7 (KAKISONJI - MISIYO) và  3 4 5 có dữ liệu", i, z, t);
                                                    number_T7 = false;
                                                }
                                            }
                                        }
                                        if (lc_info.Tb_Data_QuetLogic.Rows[z][t].ToString().Contains(","))
                                        {
                                            lc_info.Tb_CheckLogic.Rows.Add(nameimage, "Dữ liệu Trường 7 có dấu phẩy ','", i, z, t);
                                        }
                                        
                                        if (lc_info.Tb_Data_QuetLogic.Rows[z][t].ToString().ToUpper() != "SAKUJYO" && lc_info.Tb_Data_QuetLogic.Rows[z][t].ToString().ToUpper() != "YOHAKU" && lc_info.Tb_Data_QuetLogic.Rows[z][t].ToString().ToUpper() != "KAKISONJI" && lc_info.Tb_Data_QuetLogic.Rows[z][t].ToString().ToUpper() != "MISIYO")
                                        {
                                            if (lc_info.Tb_Data_QuetLogic.Rows[z]["Truong:9"].ToString() == "")
                                            {
                                                lc_info.Tb_CheckLogic.Rows.Add(nameimage, "Dữ liệu Trường 7 khác quy định - Trường 9 Trống", i, z, t);
                                            }
                                        }
                                        if (lc_info.Tb_Data_QuetLogic.Rows[z][t].ToString() == "" && lc_info.Tb_Data_QuetLogic.Rows[z]["Truong:9"].ToString() != "")
                                        {
                                            lc_info.Tb_CheckLogic.Rows.Add(nameimage, "Dữ liệu Trường 7 trống - Trường 9 có giá trị", i, z, t);
                                        }
                                        if (lc_info.Tb_Data_QuetLogic.Rows[z][t].ToString() == "" && lc_info.Tb_Data_QuetLogic.Rows[z]["Truong:9"].ToString() == "")
                                        {
                                            lc_info.Tb_CheckLogic.Rows.Add(nameimage, "Dữ liệu Trường 7 và 9 cùng trống", i, z, t);
                                        }
                                        if (lc_info.Tb_Data_QuetLogic.Rows[z]["Truong:7"].ToString().Contains("?"))
                                        {
                                            lc_info.Tb_CheckLogic.Rows.Add(nameimage, "Dữ liệu Trường 7 có dấu phẩy '?'", i, z, t);
                                        }
                                    }
                                    if (lc_info.Tb_Data_QuetLogic.Columns[t].ColumnName == "Truong:10")
                                    {
                                        if (lc_info.Tb_Data_QuetLogic.Rows[z]["Truong:10"].ToString().Contains("?"))
                                        {
                                            lc_info.Tb_CheckLogic.Rows.Add(nameimage, "Dữ liệu Trường 10 có dấu phẩy '?'", i, z, t);
                                        }
                                    }
                                    else if (lc_info.Tb_Data_QuetLogic.Columns[t].ColumnName == "Truong:8")
                                    {
                                        if (lc_info.Tb_Data_QuetLogic.Rows[z]["Truong:8"].ToString().Contains("?"))
                                        {
                                            lc_info.Tb_CheckLogic.Rows.Add(nameimage, "Dữ liệu Trường 8 có dấu phẩy '?'", i, z, t);
                                        }
                                    }
                                    else if (lc_info.Tb_Data_QuetLogic.Columns[t].ColumnName == "Truong:9")
                                    {
                                        if (lc_info.Tb_Data_QuetLogic.Rows[z]["Truong:9"].ToString().Contains("?"))
                                        {
                                            lc_info.Tb_CheckLogic.Rows.Add(nameimage, "Dữ liệu Trường 9 có dấu phẩy '?'", i, z, t);
                                        }
                                    }
                                }
                                
                                if (lc_info.Tb_Data_QuetLogic.Columns[t].ColumnName == "Truong:7")
                                {
                                    if (number_T7 == true)
                                    {
                                        if (lc_info.Tb_Data_QuetLogic.Rows[0][1].ToString().Length != 4 && lc_info.Tb_Data_QuetLogic.Rows[0][1].ToString().Length != 0)
                                        {
                                            lc_info.Tb_CheckLogic.Rows.Add(nameimage, "Dữ liệu Trường 3 khác 4 kí tự", i, 0, 1);
                                        }
                                        if (Regex.Matches(lc_info.Tb_Data_QuetLogic.Rows[0][1].ToString(), @"[0-9]").Count != lc_info.Tb_Data_QuetLogic.Rows[0][1].ToString().Length) //int errorCounter = Regex.Matches(test, @"[a-zA-Z]").Count;
                                        {
                                            lc_info.Tb_CheckLogic.Rows.Add(nameimage, "Dữ liệu Trường 3 có kí tự khác số", i, 0, t);
                                        }
                                    }
                                }
                            }                            
                        }
                        bool checkJapan = true;
                        for (int z = 0; z < lc_info.Tb_Data_QuetLogic.Rows.Count; z++)
                        {
                            if (lc_info.Tb_Data_QuetLogic.Rows[z]["Truong:7"].ToString().ToUpper() == "SAKUJYO" || lc_info.Tb_Data_QuetLogic.Rows[z]["Truong:7"].ToString().ToUpper() == "YOHAKU" || lc_info.Tb_Data_QuetLogic.Rows[z]["Truong:7"].ToString().ToUpper() == "KAKISONJI" || lc_info.Tb_Data_QuetLogic.Rows[z]["Truong:7"].ToString().ToUpper() == "MISIYO")
                            {
                                checkJapan = false;
                            }
                            else
                            {
                                checkJapan = true;break;
                            }
                        }
                        if (checkJapan == true)
                        {
                            if (lc_info.Tb_Data_QuetLogic.Rows[0][1].ToString() == "")
                            {
                                lc_info.Tb_CheckLogic.Rows.Add(nameimage, "Dữ liệu Trường 3 trống", i, 0, 1);
                            }
                            if (lc_info.Tb_Data_QuetLogic.Rows[0][2].ToString() == "")
                            {
                                lc_info.Tb_CheckLogic.Rows.Add(nameimage, "Dữ liệu Trường 4 trống", i, 0, 2);
                            }
                            if (lc_info.Tb_Data_QuetLogic.Rows[0][3].ToString() == "")
                            {
                                lc_info.Tb_CheckLogic.Rows.Add(nameimage, "Dữ liệu Trường 5 trống", i, 0, 3);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Loại Batch chưa được định dạng");
                    return;
                }
                if (lc_info.Tb_CheckLogic.Rows.Count > 0)
                {
                    grd_CheckLogic.DataSource = null;
                    grd_CheckLogic.DataSource = lc_info.Tb_CheckLogic;
                    grdV_CheckLogic.Columns[2].Visible = false;
                    grdV_CheckLogic.Columns[3].Visible = false;
                    grdV_CheckLogic.Columns[4].Visible = false;
                    grdV_CheckLogic.Columns[5].Visible = false;
                    grdV_CheckLogic.Columns[0].Width = 250;
                    grdV_CheckLogic.BestFitColumns();
                    splitContainerControl3.SplitterPosition = splitContainerControl3.Height - 300;
                }
                else
                {
                    splitContainerControl3.SplitterPosition = splitContainerControl3.Height - 10;
                }
                //if (Done_batch == true)
                //{
                //    btn_start.Enabled = false;
                //}
                //else
                //{
                //    btn_start.Enabled = true;
                //}
            }
            else
            {
                MessageBox.Show("Dữ liệu Batch trống ???");return;
            }
            btn_start.Enabled = true;
        }

        private void grdV_CheckLogic_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            int index_row = e.FocusedRowHandle;
            if (index_row > -1)
            {
                lc_info.Tb_CheckLogic.Rows[index_row]["Select_Index_Error"] = "1";
                int index_Image = Convert.ToInt32(lc_info.Tb_CheckLogic.Rows[index_row]["Index_Image"]);
                grd_Image.Focus();
                grdV_Image.FocusedRowHandle = index_Image;
                grd_Data.Focus();
                grdV_Data.FocusedRowHandle = Convert.ToInt32(lc_info.Tb_CheckLogic.Rows[index_row]["Index_Row"].ToString());
                ColumnView View = (ColumnView)grd_Data.FocusedView;
                GridColumn column = View.Columns[lc_info.Tb_Cloumns.Columns[Convert.ToInt32(lc_info.Tb_CheckLogic.Rows[index_row][4].ToString())].ToString()];
                grdV_Data.FocusedColumn = column;                
            }
        }

        private void grdV_CheckLogic_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle > -1)
            {
                if (grdV_CheckLogic.GetRowCellValue(e.RowHandle, grdV_CheckLogic.Columns["Select_Index_Error"]).ToString() == "1")
                {
                    if (e.Column.FieldName == "NameImage")
                    {
                        e.Appearance.BackColor = Color.SteelBlue;
                    }
                }
            }
        }

        private void grd_Data_Leave(object sender, EventArgs e)
        {
            if(change)
            {
                if (Global.BatchTypeSelected == "AE")
                {
                    string Result_change = "";
                    string header = lc_info.Tb_LC.Rows[0][0].ToString().Trim() + "†" + lc_info.Tb_LC.Rows[0][1].ToString().Trim() + "†" + lc_info.Tb_LC.Rows[0][2].ToString().Trim() + "†" + lc_info.Tb_LC.Rows[0][3].ToString().Trim() + "†";
                    string str_body = String.Join("†", lc_info.Tb_LC.Rows.OfType<DataRow>().Select(x => x.ItemArray[4])).Trim();
                    Result_change = header + "‡" + str_body;
                    lc_info.Tb_Data_Batch.Rows[lc_info.index_Click]["Content_LC"] = Result_change;
                    lc_info.Tb_Data_Batch.Rows[lc_info.index_Click]["Changed_Data"] = "1";
                    lc_info.Tb_Data_Batch.AcceptChanges();
                    //Changed_Data
                }
                else if (Global.BatchTypeSelected == "AT")
                {
                    string Result_change = "";
                    string header = lc_info.Tb_LC.Rows[0][0].ToString().Trim() + "†" + lc_info.Tb_LC.Rows[0][1].ToString().Trim() + "†" + lc_info.Tb_LC.Rows[0][2].ToString().Trim() + "†" + lc_info.Tb_LC.Rows[0][3].ToString().Trim() + "†";
                    string str_body = String.Join("‡", lc_info.Tb_LC.Rows.OfType<DataRow>().Select(x => ( x[4].ToString() + "†" + x[5].ToString() + "†" + x[6].ToString() + "†" + x[7].ToString())));//Select("[Truong:7] and [Truong:10] and [Truong:8] and [Truong:9]").ToList().Select(x => x.ItemArray[4].ToString() s=>s.ItemArray[5].ToString(); x.ItemArray[6].ToString(); x.ItemArray[7].ToString(); })).Trim();
                    Result_change = header + "‡" + str_body;
                    lc_info.Tb_Data_Batch.Rows[lc_info.index_Click]["Content_LC"] = Result_change;
                    lc_info.Tb_Data_Batch.Rows[lc_info.index_Click]["Changed_Data"] = "1";
                    lc_info.Tb_Data_Batch.AcceptChanges();
                }
                change_data_save = true;
                change = false;
            }    
        }

        private void btn_SaveData_Click(object sender, EventArgs e)
        {
            #region Nhảy qua cell khác để thực hiện even savedata 
            int Column_GridData = grdV_Data.FocusedColumn.ColumnHandle;
            int Row_GridData = grdV_Data.FocusedRowHandle;
            grdV_Data.Focus();
            grdV_Data.FocusedRowHandle = Row_GridData;
            try
            {
                ColumnView View = (ColumnView)grd_Data.FocusedView;
                GridColumn column = View.Columns[lc_info.Tb_Cloumns.Columns[Column_GridData - 1].ToString()];
                grdV_Data.FocusedColumn = column;                
            }
            catch
            {
                ColumnView View = (ColumnView)grd_Data.FocusedView;
                GridColumn column = View.Columns[lc_info.Tb_Cloumns.Columns[Column_GridData + 1].ToString()];
                grdV_Data.FocusedColumn = column;
            }
            grdV_Data.Focus();
            grdV_Data.FocusedRowHandle = Row_GridData;
            ColumnView View1 = (ColumnView)grd_Data.FocusedView;
            GridColumn column1 = View1.Columns[lc_info.Tb_Cloumns.Columns[Column_GridData].ToString()];
            grdV_Data.FocusedColumn = column1;
            grdV_Data.Focus();
            #endregion
            btn_CheckLogic.Focus();
            if (change_data_save)
            {
                DataTable dt_update = new DataTable();
                dt_update.Columns.Add("ID");
                dt_update.Columns.Add("Content_LC");                
                for (int i = 0; i < lc_info.Tb_Data_Batch.Rows.Count; i++)
                {
                    if (lc_info.Tb_Data_Batch.Rows[i]["Changed_Data"].ToString() == "1")
                    {
                        dt_update.Rows.Add(lc_info.Tb_Data_Batch.Rows[i]["ID"].ToString(), lc_info.Tb_Data_Batch.Rows[i]["Content_LC"].ToString());
                        lc_info.Tb_Data_Batch.Rows[i]["Changed_Data"] = "";
                    }
                }
                try
                {
                    string ConnectionString = Global.ConnectionString;
                    SqlConnection con = new SqlConnection(ConnectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("LC_UpdateData_v2", con);
                    cmd.Parameters.Clear();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 60 * 60;
                    cmd.Parameters.AddWithValue("@ID_Batch", Convert.ToInt32(Global.BatchIDSelected));
                    cmd.Parameters.AddWithValue("@table_truyen", dt_update).SqlDbType = SqlDbType.Structured;
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception exx)
                {
                    MessageBox.Show("Upload Data Error --> Try Again !!! \r\n " + exx.ToString());
                    return;
                }
                MessageBox.Show("Upload Data Complete !!!");
                change_data_save = false;
            }
            else
            {
                MessageBox.Show("Bạn không sửa dữ liệu !");
                change_data_save = false;
            }
        }

        private void frm_LastCheck_KeyDown(object sender, KeyEventArgs e)
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
            }
        }

        private void grdV_Image_MouseLeave(object sender, EventArgs e)
        {

        }

        private void grdV_Data_MouseLeave(object sender, EventArgs e)
        {

        }

        private void grdV_Data_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            if (e.RowHandle > -1)
            {
                change = true;
                change_data_save = true;
            }
        }

        private void grd_Data_EditorKeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
