using DevExpress.XtraGrid.Views.Grid;
using HIKARI_HTO_VER2.LinqToSQLProcess;
using HIKARI_HTO_VER2.MyForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIKARI_HTO_VER2.MyUserControl
{
    public partial class Manager_Batch : UserControl
    {
        public Manager_Batch()
        {
            InitializeComponent();
        }
        using_Tb_Batch using_Batch;
        using_Tb_Data using_Data;
        private void btn_TaoBatch_Click(object sender, EventArgs e)
        {
            frm_CreateBatch frm = new frm_CreateBatch();
            frm.ShowDialog();
            refresh();
        }

        private void btn_TaoBatch_Click_1(object sender, EventArgs e)
        {

        }

        private void Manager_Batch_Load(object sender, EventArgs e)
        {
            cbb_City.Items.Clear();
            cbb_City.Items.Add(new { Text = "All", Value = "" });
            cbb_City.Items.Add(new { Text = "PhieuAE", Value = "PhieuAE" });
            cbb_City.Items.Add(new { Text = "PhieuAT", Value = "PhieuAT" });
            cbb_City.DisplayMember = "Text";
            cbb_City.ValueMember = "Value";
            cbb_City.SelectedText = "All";
            using_Batch = new using_Tb_Batch(); using_Data = new using_Tb_Data();
            refresh();
        }
        private void refresh()
        {
            gridControl1.DataSource = (from var in using_Batch.getBatchFull() select var).ToList();
            gridColumn7.OptionsColumn.FixedWidth = true;
            gridColumn7.Width = 22;
        }

        private void btn_congKhai_Click(object sender, EventArgs e)
        {
            List<int> selectHanle = gridView1.GetSelectedRows().ToList();
            if (selectHanle.Count > 1)
            {
                foreach (var item in selectHanle)
                {
                    gridView1.SetRowCellValue(item, "CongKhaiBatch", true);
                    using_Batch.UpdateCongKhaiBatch(gridView1.GetRowCellValue(item, "ID").ToString(), 1);
                }
            }
        }

        private void btn_TatCongKhai_Click(object sender, EventArgs e)
        {
            List<int> selectHanle = gridView1.GetSelectedRows().ToList();
            if (selectHanle.Count > 1)
            {
                foreach (var item in selectHanle)
                {
                    gridView1.SetRowCellValue(item, "CongKhaiBatch", false);
                    using_Batch.UpdateCongKhaiBatch(gridView1.GetRowCellValue(item, "ID").ToString(), 0);
                }
            }
        }

        private void btn_xoabatch_Click(object sender, EventArgs e)
        {
            int i = 0;
            string s = "";
            foreach (var rowHandle in gridView1.GetSelectedRows())
            {
                i += 1;
                string BatchID = gridView1.GetRowCellValue(rowHandle, "BatchName").ToString();
                s += BatchID + "\n";
            }
            if (i <= 0)
            {
                MessageBox.Show("Bạn chưa chọn batch. Vui lòng chọn batch trước khi xóa");
                return;
            }

            DialogResult dlr = (MessageBox.Show("Bạn đang thực hiện xóa " + i + " batch sau:\n" + s + "\nYes = xóa những batch này \nNo = không thực hiện xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2));
            if (dlr == DialogResult.Yes)
            {
                foreach (var rowHandle in gridView1.GetSelectedRows())
                {
                    string BatchID = gridView1.GetRowCellValue(rowHandle, "ID").ToString();
                    string temp = Global.StrPath + "\\" + BatchID + "_" + gridView1.GetRowCellValue(rowHandle, "BatchName").ToString();
                    string str_Table_Data = Convert.ToDateTime(gridView1.GetRowCellValue(rowHandle, "DateCreate").ToString()).ToString("yyyyMM");
                    using_Batch.Delete_Batch(BatchID.ToString(), str_Table_Data);
                    try
                    {
                        Directory.Delete(temp, true);
                    }
                    catch (Exception)
                    {
                        //  MessageBox.Show("Đường dẫn Batch: " + temp + " không tồn tại trên server.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            refresh();
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                string BatchID = gridView1.GetFocusedRowCellValue("ID") + "";
                string str_Table_Data = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("DateCreate").ToString()).ToString("yyyyMM");
                string fielname = e.Column.FieldName;
                bool check;
                int rowHandle;
                switch (fielname)
                {
                    case "CongKhaiBatch":
                        check = (bool)e.Value;
                        if (check)
                        {
                            using_Batch.UpdateCongKhaiBatch(BatchID, 1);
                        }
                        else
                        {
                            using_Batch.UpdateCongKhaiBatch(BatchID, 0);
                        }
                        rowHandle = gridView1.LocateByValue("ID", BatchID);
                        refresh();
                        if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                            gridView1.FocusedRowHandle = rowHandle;
                        break;
                    case "ChiaUser":
                        int ktDeSo = using_Data.GetIDImage(BatchID, str_Table_Data);
                        if (ktDeSo > 0)
                        {
                            MessageBox.Show("Batch này đã được nhập!");
                        }
                        else
                        {
                            check = (bool)e.Value;
                            if (check)
                            {
                                using_Batch.UpdateBatchChiaUser(BatchID, 1);
                            }
                            else
                            {
                                using_Batch.UpdateBatchChiaUser(BatchID, 0);
                            }
                        }
                        rowHandle = gridView1.LocateByValue("ID", BatchID);
                        refresh();
                        if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                            gridView1.FocusedRowHandle = rowHandle;
                        break;

                    default:
                        break;
                }
            }
            catch (Exception i)
            {
                MessageBox.Show("Lỗi : " + i.Message);
            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            GridView view1 = new GridView();
            if (e.Info.IsRowIndicator && e.RowHandle > 0)
            {
                e.Info.DisplayText = e.RowHandle.ToString();                
            }
        }
    }
}
