
namespace HIKARI_HTO_VER2.MyForm
{
    partial class Admin_Status_Detail_Batch
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Status_Detail_Batch));
            this.grd_Chitiet = new DevExpress.XtraGrid.GridControl();
            this.grdV_Chitiet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ImageName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Level_Image = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Content_E1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserName_E1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Content_E2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserName_E2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Content_Check = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserName_Check = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Content_LC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_hienthi = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_backImage = new System.Windows.Forms.Button();
            this.btn_BackEntry_2 = new System.Windows.Forms.Button();
            this.btn_BackCheck = new System.Windows.Forms.Button();
            this.btn_BackEntry_1 = new System.Windows.Forms.Button();
            this.btn_rt_batchLC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Chitiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdV_Chitiet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd_Chitiet
            // 
            this.grd_Chitiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Chitiet.Location = new System.Drawing.Point(0, 0);
            this.grd_Chitiet.MainView = this.grdV_Chitiet;
            this.grd_Chitiet.Name = "grd_Chitiet";
            this.grd_Chitiet.Size = new System.Drawing.Size(1167, 601);
            this.grd_Chitiet.TabIndex = 0;
            this.grd_Chitiet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdV_Chitiet});
            // 
            // grdV_Chitiet
            // 
            this.grdV_Chitiet.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdV_Chitiet.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdV_Chitiet.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.grdV_Chitiet.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdV_Chitiet.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdV_Chitiet.Appearance.Row.Options.UseFont = true;
            this.grdV_Chitiet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.ImageName,
            this.Level_Image,
            this.Content_E1,
            this.UserName_E1,
            this.Content_E2,
            this.UserName_E2,
            this.Content_Check,
            this.UserName_Check,
            this.Content_LC});
            this.grdV_Chitiet.GridControl = this.grd_Chitiet;
            this.grdV_Chitiet.IndicatorWidth = 30;
            this.grdV_Chitiet.Name = "grdV_Chitiet";
            this.grdV_Chitiet.OptionsBehavior.Editable = false;
            this.grdV_Chitiet.OptionsBehavior.KeepGroupExpandedOnSorting = false;
            this.grdV_Chitiet.OptionsView.ShowGroupPanel = false;
            this.grdV_Chitiet.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.grdV_Chitiet_CustomDrawRowIndicator);
            this.grdV_Chitiet.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdV_Chitiet_FocusedRowChanged);
            this.grdV_Chitiet.DoubleClick += new System.EventHandler(this.grdV_Chitiet_DoubleClick);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // ImageName
            // 
            this.ImageName.Caption = "Tên Ảnh";
            this.ImageName.FieldName = "ImageName";
            this.ImageName.Name = "ImageName";
            this.ImageName.Visible = true;
            this.ImageName.VisibleIndex = 0;
            // 
            // Level_Image
            // 
            this.Level_Image.Caption = "Level Ảnh Nhập";
            this.Level_Image.FieldName = "Level_Image";
            this.Level_Image.Name = "Level_Image";
            // 
            // Content_E1
            // 
            this.Content_E1.Caption = "Dữ liệu LV1";
            this.Content_E1.FieldName = "Content_E1";
            this.Content_E1.Name = "Content_E1";
            this.Content_E1.Visible = true;
            this.Content_E1.VisibleIndex = 1;
            // 
            // UserName_E1
            // 
            this.UserName_E1.Caption = "UserName Nhập LV1";
            this.UserName_E1.FieldName = "UserName_E1";
            this.UserName_E1.Name = "UserName_E1";
            this.UserName_E1.Visible = true;
            this.UserName_E1.VisibleIndex = 2;
            // 
            // Content_E2
            // 
            this.Content_E2.Caption = "Dữ liệu LV2";
            this.Content_E2.FieldName = "Content_E2";
            this.Content_E2.Name = "Content_E2";
            this.Content_E2.Visible = true;
            this.Content_E2.VisibleIndex = 3;
            // 
            // UserName_E2
            // 
            this.UserName_E2.Caption = "User Name Nhập LV2";
            this.UserName_E2.FieldName = "UserName_E2";
            this.UserName_E2.Name = "UserName_E2";
            this.UserName_E2.Visible = true;
            this.UserName_E2.VisibleIndex = 4;
            // 
            // Content_Check
            // 
            this.Content_Check.Caption = "Dữ liệu Checker";
            this.Content_Check.FieldName = "Content_Check";
            this.Content_Check.Name = "Content_Check";
            this.Content_Check.Visible = true;
            this.Content_Check.VisibleIndex = 5;
            // 
            // UserName_Check
            // 
            this.UserName_Check.Caption = "UserName Checker";
            this.UserName_Check.FieldName = "UserName_Check";
            this.UserName_Check.Name = "UserName_Check";
            this.UserName_Check.Visible = true;
            this.UserName_Check.VisibleIndex = 6;
            // 
            // Content_LC
            // 
            this.Content_LC.Caption = "Dữ liệu LastCheck";
            this.Content_LC.FieldName = "Content_LC";
            this.Content_LC.Name = "Content_LC";
            this.Content_LC.Visible = true;
            this.Content_LC.VisibleIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lb_hienthi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 41);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(685, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhấn đúp chuột để xem Dữ liệu chi tiết của hình được chọn";
            // 
            // lb_hienthi
            // 
            this.lb_hienthi.AutoSize = true;
            this.lb_hienthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hienthi.ForeColor = System.Drawing.Color.White;
            this.lb_hienthi.Location = new System.Drawing.Point(3, 9);
            this.lb_hienthi.Name = "lb_hienthi";
            this.lb_hienthi.Size = new System.Drawing.Size(57, 20);
            this.lb_hienthi.TabIndex = 0;
            this.lb_hienthi.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grd_Chitiet);
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1167, 601);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.panel3.Controls.Add(this.btn_rt_batchLC);
            this.panel3.Controls.Add(this.btn_backImage);
            this.panel3.Controls.Add(this.btn_BackEntry_2);
            this.panel3.Controls.Add(this.btn_BackCheck);
            this.panel3.Controls.Add(this.btn_BackEntry_1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 645);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1167, 41);
            this.panel3.TabIndex = 3;
            // 
            // btn_backImage
            // 
            this.btn_backImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backImage.Location = new System.Drawing.Point(28, 3);
            this.btn_backImage.Name = "btn_backImage";
            this.btn_backImage.Size = new System.Drawing.Size(157, 35);
            this.btn_backImage.TabIndex = 3;
            this.btn_backImage.Text = "Return Image";
            this.btn_backImage.UseVisualStyleBackColor = true;
            this.btn_backImage.Click += new System.EventHandler(this.btn_backImage_Click);
            // 
            // btn_BackEntry_2
            // 
            this.btn_BackEntry_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BackEntry_2.Location = new System.Drawing.Point(502, 3);
            this.btn_BackEntry_2.Name = "btn_BackEntry_2";
            this.btn_BackEntry_2.Size = new System.Drawing.Size(157, 35);
            this.btn_BackEntry_2.TabIndex = 2;
            this.btn_BackEntry_2.Text = "Return Entry LV2";
            this.btn_BackEntry_2.UseVisualStyleBackColor = true;
            this.btn_BackEntry_2.Click += new System.EventHandler(this.btn_BackEntry_2_Click);
            // 
            // btn_BackCheck
            // 
            this.btn_BackCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BackCheck.Location = new System.Drawing.Point(763, 3);
            this.btn_BackCheck.Name = "btn_BackCheck";
            this.btn_BackCheck.Size = new System.Drawing.Size(157, 35);
            this.btn_BackCheck.TabIndex = 1;
            this.btn_BackCheck.Text = "Return Checker";
            this.btn_BackCheck.UseVisualStyleBackColor = true;
            this.btn_BackCheck.Click += new System.EventHandler(this.btn_BackCheck_Click);
            // 
            // btn_BackEntry_1
            // 
            this.btn_BackEntry_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BackEntry_1.Location = new System.Drawing.Point(256, 3);
            this.btn_BackEntry_1.Name = "btn_BackEntry_1";
            this.btn_BackEntry_1.Size = new System.Drawing.Size(157, 35);
            this.btn_BackEntry_1.TabIndex = 0;
            this.btn_BackEntry_1.Text = "Return Entry LV1";
            this.btn_BackEntry_1.UseVisualStyleBackColor = true;
            this.btn_BackEntry_1.Click += new System.EventHandler(this.btn_BackEntry_1_Click);
            // 
            // btn_rt_batchLC
            // 
            this.btn_rt_batchLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rt_batchLC.Location = new System.Drawing.Point(1007, 3);
            this.btn_rt_batchLC.Name = "btn_rt_batchLC";
            this.btn_rt_batchLC.Size = new System.Drawing.Size(157, 35);
            this.btn_rt_batchLC.TabIndex = 5;
            this.btn_rt_batchLC.Text = "Return LC";
            this.btn_rt_batchLC.UseVisualStyleBackColor = true;
            this.btn_rt_batchLC.Click += new System.EventHandler(this.btn_rt_batchLC_Click);
            // 
            // Admin_Status_Detail_Batch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 686);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_Status_Detail_Batch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn Hình Chi Tiết Dữ Liệu Batch";
            this.Load += new System.EventHandler(this.Admin_Status_Detail_Batch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Chitiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdV_Chitiet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd_Chitiet;
        private DevExpress.XtraGrid.Views.Grid.GridView grdV_Chitiet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_hienthi;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn ImageName;
        private DevExpress.XtraGrid.Columns.GridColumn Level_Image;
        private DevExpress.XtraGrid.Columns.GridColumn Content_E1;
        private DevExpress.XtraGrid.Columns.GridColumn UserName_E1;
        private DevExpress.XtraGrid.Columns.GridColumn Content_E2;
        private DevExpress.XtraGrid.Columns.GridColumn UserName_E2;
        private DevExpress.XtraGrid.Columns.GridColumn Content_Check;
        private DevExpress.XtraGrid.Columns.GridColumn UserName_Check;
        private DevExpress.XtraGrid.Columns.GridColumn Content_LC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_BackCheck;
        private System.Windows.Forms.Button btn_BackEntry_1;
        private System.Windows.Forms.Button btn_BackEntry_2;
        private System.Windows.Forms.Button btn_backImage;
        private System.Windows.Forms.Button btn_rt_batchLC;
    }
}