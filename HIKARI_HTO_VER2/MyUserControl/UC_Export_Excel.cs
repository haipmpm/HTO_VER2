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
        public UC_Export_Excel()
        {
            InitializeComponent();
        }

        private void UC_Export_Excel_Load(object sender, EventArgs e)
        {

        }
        private void AddColumnDataAE(DataGridView dt_exportexcel)
        {
            dt_exportexcel.Columns.Add("TRƯỜNG", "TRƯỜNG");
            dt_exportexcel.Columns.Add("1. Cố định AE", "1. Cố định AE");
            dt_exportexcel.Columns.Add("2. No", "2. No");
            dt_exportexcel.Columns.Add("3. Code", "3. Code");
            dt_exportexcel.Columns.Add("4. 班", "4. 班");
            dt_exportexcel.Columns.Add("5.棚番", "5.棚番");
            dt_exportexcel.Columns.Add("6. STT", "6. STT");
            dt_exportexcel.Columns.Add("7. Mã SP", "7. Mã SP");
            dt_exportexcel.Columns.Add("8. Mã 工号", "8. Mã 工号");
            dt_exportexcel.Columns.Add("9. Số lượng", "9. Số lượng");

            dt_exportexcel.Columns.Add("10.機能Chức năng", "10.機能Chức năng");
            dt_exportexcel.Columns.Add("11. Mặc định K hoặc M", "11.Mặc định K hoặc M");
            dt_exportexcel.Columns.Add("12. Phân loại", "12. Phân loại");


            dt_exportexcel.Columns.Add("TRỐNG1", "TRỐNG1");
            dt_exportexcel.Columns.Add("TRỐNG2", "TRỐNG2");
            dt_exportexcel.Columns.Add("TRỐNG3", "TRỐNG3");
            dt_exportexcel.Columns.Add("TRỐNG4", "TRỐNG4");
            dt_exportexcel.Columns.Add("TRỐNG5", "TRỐNG5");
            dt_exportexcel.Columns.Add("TRỐNG6", "TRỐNG6");
            dt_exportexcel.Columns.Add("PATH", "PATH");
            dt_exportexcel.Columns.Add("BatchName", "BatchName");


        }

        private void AddColumnDataAT(DataGridView dt_exportexcel)
        {
            dt_exportexcel.Columns.Add("TRƯỜNG", "TRƯỜNG");
            dt_exportexcel.Columns.Add("1. Cố định AE", "1. Cố định AT");
            dt_exportexcel.Columns.Add("2. No", "2. No");
            dt_exportexcel.Columns.Add("3. Code", "3. Code");
            dt_exportexcel.Columns.Add("4. 班", "4. 班");
            dt_exportexcel.Columns.Add("5.棚番", "5.棚番");
            dt_exportexcel.Columns.Add("6. STT", "6. STT");
            dt_exportexcel.Columns.Add("7. Mã SP", "7. Mã SP");
            dt_exportexcel.Columns.Add("8. Mã 工号", "8. Mã 工号");
            dt_exportexcel.Columns.Add("9. Số lượng", "9. Số lượng");

            dt_exportexcel.Columns.Add("10.機能Chức năng", "10.機能Chức năng");
            dt_exportexcel.Columns.Add("11. Mặc định K hoặc M", "11.Mặc định K hoặc M");
            dt_exportexcel.Columns.Add("12. Phân loại", "12. Phân loại");


            dt_exportexcel.Columns.Add("TRỐNG1", "TRỐNG1");
            dt_exportexcel.Columns.Add("TRỐNG2", "TRỐNG2");
            dt_exportexcel.Columns.Add("TRỐNG3", "TRỐNG3");
            dt_exportexcel.Columns.Add("TRỐNG4", "TRỐNG4");
            dt_exportexcel.Columns.Add("TRỐNG5", "TRỐNG5");
            dt_exportexcel.Columns.Add("TRỐNG6", "TRỐNG6");
            dt_exportexcel.Columns.Add("PATH", "PATH");
            dt_exportexcel.Columns.Add("BatchName", "BatchName");

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SaveFile();
        }
        public void SaveFile()
        {
            //try
            //{
            //    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //    SaveFileDialog saveFileDialog2 = new SaveFileDialog();

            //    //thêm 1 save dialog
            //    string savePath = "";
            //    saveFileDialog1.Title = "Save Excel Files";
            //    saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx";
            //    //saveFileDialog2.Title = "Save Excel Files";
            //    //saveFileDialog2.Filter = "Excel files (*.xlsx)|*.xlsx";
            //    if (cbo_Loai.SelectedItem.ToString() == "AE")
            //    {
            //        saveFileDialog1.FileName = strnamefile + "_AE";
            //        //saveFileDialog2.FileName = strnamefile + "_AE_error";
            //    }
            //    else if (cbo_Loai.SelectedItem.ToString() == "AT")
            //    {
            //        saveFileDialog1.FileName = strnamefile + "_AT";
            //        //saveFileDialog2.FileName = strnamefile + "_AT_error";
            //    }


            //    saveFileDialog1.RestoreDirectory = true;

            //    // Có dữ liệu thì mới xuất
            //    if (dataGridView1.RowCount - 1 > 0)
            //    {
            //        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //        {
            //            DataTable dt_ex = new DataTable();
            //            DataTable dt_ex_err = new DataTable();

            //            //int i = 1;
            //            foreach (DataGridViewColumn col in dt_exportexcel.Columns)
            //            {
            //                dt_ex.Columns.Add(col.Name);
            //            }
            //            foreach (DataGridViewRow row in dt_exportexcel.Rows)
            //            {
            //                DataRow dRow = dt_ex.NewRow();
            //                foreach (DataGridViewCell cell in row.Cells)
            //                {
            //                    dRow[cell.ColumnIndex] = cell.Value;
            //                }
            //                dt_ex.Rows.Add(dRow);
            //            }
            //            ws.FirstCell().InsertTable(dt_ex, false);

            //            foreach (DataGridViewColumn col in dt_err.Columns)
            //            {
            //                dt_ex_err.Columns.Add(col.Name);
            //            }
            //            foreach (DataGridViewRow row in dt_err.Rows)
            //            {
            //                DataRow dRow = dt_ex_err.NewRow();
            //                foreach (DataGridViewCell cell in row.Cells)
            //                {
            //                    dRow[cell.ColumnIndex] = cell.Value;
            //                }
            //                dt_ex_err.Rows.Add(dRow);
            //            }
            //            ws1.FirstCell().InsertTable(dt_ex_err, false);

            //            setPropertyFileExcel(ws);
            //            setPropertyFileExcel(ws1);


            //            //setPropertyFileExcel(ws);

            //            savePath = Path.GetDirectoryName(saveFileDialog1.FileName);
            //            wb.SaveAs(saveFileDialog1.FileName);
            //            saveFileDialog2.FileName = saveFileDialog1.FileName.Split('.')[0] + "_Error.xlsx";
            //            wb_err.SaveAs(saveFileDialog2.FileName);
            //            MessageBox.Show(@"Xuất file excel thành công.");
            //            Process.Start(savePath);
            //        }
            //        else
            //        {
            //            MessageBox.Show(@"Xuất file excel không thành công!");

            //            return;
            //        }
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi xuất excel : " + ex.Message);
            //}
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
    }
}
