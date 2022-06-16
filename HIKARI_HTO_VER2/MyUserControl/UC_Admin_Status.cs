using HIKARI_HTO_VER2.LinqToSQLProcess;
using HIKARI_HTO_VER2.ModuleProcessUtil;
using HIKARI_HTO_VER2.MyForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIKARI_HTO_VER2.MyUserControl
{
    public partial class UC_Admin_Status : UserControl
    {
        Admin_info admin_info;
        public UC_Admin_Status()
        {
            InitializeComponent();
            admin_info = new Admin_info();
        }

        private void UC_Status_Load(object sender, EventArgs e)
        {
            Check_Style();
            CheckCBB_Status.Properties.Items.Clear();
            CheckCBB_Status.Properties.DataSource = GlobalDB.DBLinq.Admin_Status_GetListBacth(admin_info.Style_batch.ToString()).ToList();
            CheckCBB_Status.Properties.ValueMember = "ID";
            CheckCBB_Status.Properties.DisplayMember = "BatchName";
            CheckCBB_Status.CheckAll();
        }

        private void dtpk_status_ValueChanged(object sender, EventArgs e)
        {            

        }
        private string Check_Style()
        {
            admin_info.Style_batch = "";
            if (cb_AE.Checked && cb_AT.Checked)
            {
                admin_info.Style_batch = "ALL_AE_AT";
            }
            else if (cb_AE.Checked)
            {
                admin_info.Style_batch = "AE";
            }
            else if (cb_AT.Checked)
            {
                admin_info.Style_batch = "AT";
            }
            else
            {
                admin_info.Style_batch = "";
            }
            return admin_info.Style_batch;
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            DataTable dt_Status= new DataTable();
            dt_Status = new DataTable();
            string str_batchId = CheckCBB_Status.Properties.GetCheckedItems().ToString();            
            if (admin_info.Style_batch == "")
            {
                MessageBox.Show("Thiếu thông tin Loại AE hoặc AT !!! \r\nVui lòng chọn Loại phiếu");
                return;
            }
            if (str_batchId != "")
            {
                var Result = (from w in GlobalDB.DBLinq.Admin_View_Status_V3(admin_info.Style_batch, str_batchId) select new { w.ID, w.BatchName, w.BatchType, w.NumberImage, w.Hit_E11, w.Hit_E12, w.PhieuCheck1, w.TongPhieuCheck1, w.UserLC_1, w.Status_LC_1, w.Hit_E31, w.Hit_E32, w.PhieuCheck3, w.TongPhieuCheck3, w.UserLC_3, w.Status_LC_3, w.Ngaytao, w.User_Export, w.Hoanthanh1, w.Hoanthanh3 }).ToList();                
                grd_Status.DataSource = null;
                grd_Status.DataSource = Result;
                //// Tính toán và Add vào Footer
                grdV_Status.Columns["TongPhieuCheck1"].Width = 280;
                grdV_Status.Columns["NumberImage"].Summary.Clear();
                grdV_Status.Columns["Hit_E11"].Summary.Clear();
                grdV_Status.Columns["Hit_E12"].Summary.Clear();
                grdV_Status.Columns["PhieuCheck1"].Summary.Clear();
                grdV_Status.Columns["TongPhieuCheck1"].Summary.Clear();
                int tongSL = Result.Sum(x => Convert.ToInt32(x.NumberImage));
                grdV_Status.Columns["NumberImage"].Summary.Add(DevExpress.Data.SummaryItemType.Custom, "Count", "Tổng Ảnh");
                grdV_Status.Columns["NumberImage"].Summary.Add(DevExpress.Data.SummaryItemType.Custom, "Count", "Tổng nhập");
                grdV_Status.Columns["NumberImage"].Summary.Add(DevExpress.Data.SummaryItemType.Custom, "Count", "Còn lại");
                int Conlai_LV1 = Result.Sum(x => Convert.ToInt32(x.Hit_E11));
                int Conlai_LV2 = Result.Sum(x => Convert.ToInt32(x.Hit_E12));
                int Conlai_Check = Result.Sum(x => Convert.ToInt32(x.PhieuCheck1));
                int Tong_Check = Result.Sum(x => Convert.ToInt32(x.TongPhieuCheck1));
                int Hoanthanhlv1 = Result.Sum(x => Convert.ToInt32(x.Hoanthanh1));
                int Hoanthanhlv3 = Result.Sum(x => Convert.ToInt32(x.Hoanthanh3));

                grdV_Status.Columns["Hit_E11"].Summary.Add(DevExpress.Data.SummaryItemType.Custom, "Hit_E11", tongSL.ToString());
                grdV_Status.Columns["Hit_E11"].Summary.Add(DevExpress.Data.SummaryItemType.Custom, "Hit_E11", (tongSL - Conlai_LV1).ToString());
                grdV_Status.Columns["Hit_E11"].Summary.Add(DevExpress.Data.SummaryItemType.Custom, "Hit_E11", Conlai_LV1.ToString());

                grdV_Status.Columns["Hit_E12"].Summary.Add(DevExpress.Data.SummaryItemType.Custom, "Hit_E12", tongSL.ToString());
                grdV_Status.Columns["Hit_E12"].Summary.Add(DevExpress.Data.SummaryItemType.Custom, "Hit_E12", (tongSL - Conlai_LV2).ToString());
                grdV_Status.Columns["Hit_E12"].Summary.Add(DevExpress.Data.SummaryItemType.Custom, "Hit_E12", Conlai_LV2.ToString());

                grdV_Status.Columns["PhieuCheck1"].Summary.Add(DevExpress.Data.SummaryItemType.Custom, "PhieuCheck1", "Tổng Lỗi:  " + Conlai_Check.ToString());
                grdV_Status.Columns["PhieuCheck1"].Summary.Add(DevExpress.Data.SummaryItemType.Custom, "PhieuCheck1", "   % Lỗi:  " + Math.Round(((double)Tong_Check / (double)Hoanthanhlv1) * 100, 2).ToString() + " %");

                grdV_Status.Columns["TongPhieuCheck1"].Summary.Add(DevExpress.Data.SummaryItemType.Custom, "PhieuCheck1", " Ảnh Hoàn thành:  " + Hoanthanhlv1.ToString());
                grdV_Status.Columns["TongPhieuCheck1"].Summary.Add(DevExpress.Data.SummaryItemType.Custom, "PhieuCheck1", "   % Hoàn thành:  " + Math.Round(((double)Hoanthanhlv1 / (double)tongSL) * 100, 2).ToString() + " %");
            }
            else
            {
                MessageBox.Show("Không có Batch Name nào được chọn !!! \r\nVui lòng chọn Batch Name");
                return;
            }
        }

        private void grdV_Status_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            int r = e.RowHandle;
            string columns = e.Column.FieldName;
            if (columns == "Hit_E11" || columns == "Hit_E12" || columns == "Hit_E31" || columns == "Hit_E32" || columns == "PhieuCheck1" || columns == "PhieuCheck3")
            {
                if (grdV_Status.GetRowCellValue(e.RowHandle,columns).ToString() == "0")
                {
                    e.Appearance.BackColor = Color.LightSkyBlue;
                }
            }
            if (columns == "Status_LC_1")
            {
                if (string.IsNullOrEmpty(grdV_Status.GetRowCellValue(e.RowHandle, columns).ToString()) == false)
                {
                    if (grdV_Status.GetRowCellValue(e.RowHandle, columns).ToString() == "Run")
                    {
                        e.Appearance.BackColor = Color.SandyBrown;
                    }
                    else if (grdV_Status.GetRowCellValue(e.RowHandle, columns).ToString() == "OK")
                    {
                        e.Appearance.BackColor = Color.LightSkyBlue;
                    }
                }

            }
            if (columns == "User_Export")
            {
                if (string.IsNullOrEmpty(grdV_Status.GetRowCellValue(e.RowHandle, columns).ToString()) == false)
                {
                    if (grdV_Status.GetRowCellValue(e.RowHandle, columns).ToString() != "")
                    {
                        e.Appearance.BackColor = Color.LightSkyBlue;
                    }
                }
            }
        }

        private void grdV_Status_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = (DevExpress.XtraGrid.Views.Grid.GridView)sender;
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void grdV_Status_DoubleClick(object sender, EventArgs e)
        {
            if (grdV_Status.FocusedRowHandle >= 0)
            {
                admin_info.Status_info_batchChitiet = "";                
                int BatchID = Convert.ToInt32(grdV_Status.GetFocusedRowCellValue("ID").ToString());
                admin_info.Status_info_batchChitiet = grdV_Status.GetFocusedRowCellValue("BatchName").ToString() + "  -- Số lượng: " + grdV_Status.GetFocusedRowCellValue("NumberImage").ToString();
                string Style_batch = grdV_Status.GetFocusedRowCellValue("BatchType").ToString();
                Admin_Status_Detail_Batch frm_chitiet = new Admin_Status_Detail_Batch(BatchID, admin_info.Status_info_batchChitiet, Style_batch);
                frm_chitiet.ShowDialog();
            }
        }

        private void cb_AE_CheckedChanged(object sender, EventArgs e)
        {
            UC_Status_Load(null, null);
        }

        private void cb_AT_CheckedChanged(object sender, EventArgs e)
        {
            UC_Status_Load(null, null);
        }

        private void CheckCBB_Status_Enter(object sender, EventArgs e)
        {
            UC_Status_Load(null, null);
        }
    }
}
