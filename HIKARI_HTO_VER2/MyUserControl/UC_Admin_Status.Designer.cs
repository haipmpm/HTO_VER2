
namespace HIKARI_HTO_VER2.MyUserControl
{
    partial class UC_Admin_Status
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_AT = new System.Windows.Forms.CheckBox();
            this.cb_AE = new System.Windows.Forms.CheckBox();
            this.CheckCBB_Status = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_View = new System.Windows.Forms.Button();
            this.grd_Status = new DevExpress.XtraGrid.GridControl();
            this.grdV_Status = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BatchName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BatchType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NumberImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Hit_E11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Hit_E12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PhieuCheck1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TongPhieuCheck1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserLC_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Hit_E31 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Hit_E32 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PhieuCheck3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TongPhieuCheck3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserLC_3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.User_Export = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Hoanthanh1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Hoanthanh3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status_LC_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckCBB_Status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdV_Status)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.panel1.Controls.Add(this.cb_AT);
            this.panel1.Controls.Add(this.cb_AE);
            this.panel1.Controls.Add(this.CheckCBB_Status);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_View);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 49);
            this.panel1.TabIndex = 1;
            // 
            // cb_AT
            // 
            this.cb_AT.AutoSize = true;
            this.cb_AT.Checked = true;
            this.cb_AT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_AT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_AT.ForeColor = System.Drawing.Color.White;
            this.cb_AT.Location = new System.Drawing.Point(101, 10);
            this.cb_AT.Name = "cb_AT";
            this.cb_AT.Size = new System.Drawing.Size(50, 24);
            this.cb_AT.TabIndex = 10;
            this.cb_AT.Text = "AT";
            this.cb_AT.UseVisualStyleBackColor = true;
            this.cb_AT.CheckedChanged += new System.EventHandler(this.cb_AT_CheckedChanged);
            // 
            // cb_AE
            // 
            this.cb_AE.AutoSize = true;
            this.cb_AE.Checked = true;
            this.cb_AE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_AE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_AE.ForeColor = System.Drawing.Color.White;
            this.cb_AE.Location = new System.Drawing.Point(27, 10);
            this.cb_AE.Name = "cb_AE";
            this.cb_AE.Size = new System.Drawing.Size(52, 24);
            this.cb_AE.TabIndex = 9;
            this.cb_AE.Text = "AE";
            this.cb_AE.UseVisualStyleBackColor = true;
            this.cb_AE.CheckedChanged += new System.EventHandler(this.cb_AE_CheckedChanged);
            // 
            // CheckCBB_Status
            // 
            this.CheckCBB_Status.Location = new System.Drawing.Point(292, 5);
            this.CheckCBB_Status.Name = "CheckCBB_Status";
            this.CheckCBB_Status.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckCBB_Status.Properties.Appearance.Options.UseFont = true;
            this.CheckCBB_Status.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CheckCBB_Status.Size = new System.Drawing.Size(515, 30);
            this.CheckCBB_Status.TabIndex = 6;
            this.CheckCBB_Status.Enter += new System.EventHandler(this.CheckCBB_Status_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(174, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name Batch:";
            // 
            // btn_View
            // 
            this.btn_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View.ForeColor = System.Drawing.Color.Black;
            this.btn_View.Location = new System.Drawing.Point(878, 5);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(120, 33);
            this.btn_View.TabIndex = 1;
            this.btn_View.Text = "View Status";
            this.btn_View.UseVisualStyleBackColor = true;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // grd_Status
            // 
            this.grd_Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Status.Location = new System.Drawing.Point(0, 49);
            this.grd_Status.MainView = this.grdV_Status;
            this.grd_Status.Name = "grd_Status";
            this.grd_Status.Size = new System.Drawing.Size(1157, 508);
            this.grd_Status.TabIndex = 2;
            this.grd_Status.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdV_Status});
            // 
            // grdV_Status
            // 
            this.grdV_Status.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.grdV_Status.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdV_Status.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdV_Status.Appearance.FooterPanel.Options.UseFont = true;
            this.grdV_Status.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdV_Status.Appearance.GroupFooter.Options.UseFont = true;
            this.grdV_Status.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdV_Status.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdV_Status.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.grdV_Status.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdV_Status.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdV_Status.Appearance.Row.Options.UseFont = true;
            this.grdV_Status.Appearance.Row.Options.UseTextOptions = true;
            this.grdV_Status.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdV_Status.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.BatchName,
            this.BatchType,
            this.NumberImage,
            this.Hit_E11,
            this.Hit_E12,
            this.PhieuCheck1,
            this.TongPhieuCheck1,
            this.UserLC_1,
            this.Status_LC_1,
            this.Hit_E31,
            this.Hit_E32,
            this.PhieuCheck3,
            this.TongPhieuCheck3,
            this.UserLC_3,
            this.User_Export,
            this.Hoanthanh1,
            this.Hoanthanh3});
            this.grdV_Status.GridControl = this.grd_Status;
            this.grdV_Status.IndicatorWidth = 30;
            this.grdV_Status.Name = "grdV_Status";
            this.grdV_Status.OptionsBehavior.Editable = false;
            this.grdV_Status.OptionsBehavior.ReadOnly = true;
            this.grdV_Status.OptionsView.ShowFooter = true;
            this.grdV_Status.OptionsView.ShowGroupPanel = false;
            this.grdV_Status.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.grdV_Status_CustomDrawRowIndicator);
            this.grdV_Status.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.grdV_Status_RowCellStyle);
            this.grdV_Status.DoubleClick += new System.EventHandler(this.grdV_Status_DoubleClick);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // BatchName
            // 
            this.BatchName.Caption = "BatchName";
            this.BatchName.FieldName = "BatchName";
            this.BatchName.Name = "BatchName";
            this.BatchName.Visible = true;
            this.BatchName.VisibleIndex = 0;
            // 
            // BatchType
            // 
            this.BatchType.Caption = "Loại Batch";
            this.BatchType.FieldName = "BatchType";
            this.BatchType.Name = "BatchType";
            this.BatchType.Visible = true;
            this.BatchType.VisibleIndex = 1;
            // 
            // NumberImage
            // 
            this.NumberImage.Caption = "Số Lượng Ảnh";
            this.NumberImage.FieldName = "NumberImage";
            this.NumberImage.Name = "NumberImage";
            this.NumberImage.Visible = true;
            this.NumberImage.VisibleIndex = 2;
            // 
            // Hit_E11
            // 
            this.Hit_E11.Caption = "User LV1";
            this.Hit_E11.FieldName = "Hit_E11";
            this.Hit_E11.Name = "Hit_E11";
            this.Hit_E11.Visible = true;
            this.Hit_E11.VisibleIndex = 3;
            // 
            // Hit_E12
            // 
            this.Hit_E12.Caption = "User LV2";
            this.Hit_E12.FieldName = "Hit_E12";
            this.Hit_E12.Name = "Hit_E12";
            this.Hit_E12.Visible = true;
            this.Hit_E12.VisibleIndex = 4;
            // 
            // PhieuCheck1
            // 
            this.PhieuCheck1.Caption = "Phiếu Check 1";
            this.PhieuCheck1.FieldName = "PhieuCheck1";
            this.PhieuCheck1.Name = "PhieuCheck1";
            this.PhieuCheck1.Visible = true;
            this.PhieuCheck1.VisibleIndex = 5;
            // 
            // TongPhieuCheck1
            // 
            this.TongPhieuCheck1.Caption = "Tổng phiếu Check LV1";
            this.TongPhieuCheck1.FieldName = "TongPhieuCheck1";
            this.TongPhieuCheck1.Name = "TongPhieuCheck1";
            this.TongPhieuCheck1.Visible = true;
            this.TongPhieuCheck1.VisibleIndex = 6;
            // 
            // UserLC_1
            // 
            this.UserLC_1.Caption = "User LastCheck Lv1";
            this.UserLC_1.FieldName = "UserLC_1";
            this.UserLC_1.Name = "UserLC_1";
            this.UserLC_1.Visible = true;
            this.UserLC_1.VisibleIndex = 7;
            // 
            // Hit_E31
            // 
            this.Hit_E31.Caption = "User LV3_1";
            this.Hit_E31.FieldName = "Hit_E31";
            this.Hit_E31.Name = "Hit_E31";
            // 
            // Hit_E32
            // 
            this.Hit_E32.Caption = "User LV3_2";
            this.Hit_E32.FieldName = "Hit_E32";
            this.Hit_E32.Name = "Hit_E32";
            // 
            // PhieuCheck3
            // 
            this.PhieuCheck3.Caption = "Phiếu Check 3";
            this.PhieuCheck3.FieldName = "PhieuCheck3";
            this.PhieuCheck3.Name = "PhieuCheck3";
            // 
            // TongPhieuCheck3
            // 
            this.TongPhieuCheck3.Caption = "Tổng phiếu Check LV3";
            this.TongPhieuCheck3.FieldName = "TongPhieuCheck3";
            this.TongPhieuCheck3.Name = "TongPhieuCheck3";
            // 
            // UserLC_3
            // 
            this.UserLC_3.Caption = "User LastCheck Lv3";
            this.UserLC_3.FieldName = "UserLC_3";
            this.UserLC_3.Name = "UserLC_3";
            // 
            // User_Export
            // 
            this.User_Export.Caption = "User Export";
            this.User_Export.FieldName = "User_Export";
            this.User_Export.Name = "User_Export";
            this.User_Export.Visible = true;
            this.User_Export.VisibleIndex = 9;
            // 
            // Hoanthanh1
            // 
            this.Hoanthanh1.Caption = "Hoàn thành lv1";
            this.Hoanthanh1.FieldName = "Hoanthanh1";
            this.Hoanthanh1.Name = "Hoanthanh1";
            // 
            // Hoanthanh3
            // 
            this.Hoanthanh3.Caption = "Hoàn thành lv3";
            this.Hoanthanh3.FieldName = "Hoanthanh3";
            this.Hoanthanh3.Name = "Hoanthanh3";
            // 
            // Status_LC_1
            // 
            this.Status_LC_1.Caption = "Trạng Thái LC";
            this.Status_LC_1.FieldName = "Status_LC_1";
            this.Status_LC_1.Name = "Status_LC_1";
            this.Status_LC_1.Visible = true;
            this.Status_LC_1.VisibleIndex = 8;
            // 
            // UC_Admin_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grd_Status);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Admin_Status";
            this.Size = new System.Drawing.Size(1157, 557);
            this.Load += new System.EventHandler(this.UC_Status_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckCBB_Status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdV_Status)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit CheckCBB_Status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_View;
        private DevExpress.XtraGrid.GridControl grd_Status;
        private DevExpress.XtraGrid.Views.Grid.GridView grdV_Status;
        private System.Windows.Forms.CheckBox cb_AT;
        private System.Windows.Forms.CheckBox cb_AE;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn BatchName;
        private DevExpress.XtraGrid.Columns.GridColumn BatchType;
        private DevExpress.XtraGrid.Columns.GridColumn NumberImage;
        private DevExpress.XtraGrid.Columns.GridColumn Hit_E11;
        private DevExpress.XtraGrid.Columns.GridColumn Hit_E12;
        private DevExpress.XtraGrid.Columns.GridColumn UserLC_1;
        private DevExpress.XtraGrid.Columns.GridColumn Hit_E31;
        private DevExpress.XtraGrid.Columns.GridColumn Hit_E32;
        private DevExpress.XtraGrid.Columns.GridColumn UserLC_3;
        private DevExpress.XtraGrid.Columns.GridColumn PhieuCheck1;
        private DevExpress.XtraGrid.Columns.GridColumn PhieuCheck3;
        private DevExpress.XtraGrid.Columns.GridColumn TongPhieuCheck1;
        private DevExpress.XtraGrid.Columns.GridColumn TongPhieuCheck3;
        private DevExpress.XtraGrid.Columns.GridColumn User_Export;
        private DevExpress.XtraGrid.Columns.GridColumn Hoanthanh1;
        private DevExpress.XtraGrid.Columns.GridColumn Hoanthanh3;
        private DevExpress.XtraGrid.Columns.GridColumn Status_LC_1;
    }
}
