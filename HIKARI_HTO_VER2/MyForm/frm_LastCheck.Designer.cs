
namespace HIKARI_HTO_VER2.MyForm
{
    partial class frm_LastCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_LastCheck));
            this.panel = new System.Windows.Forms.Panel();
            this.btn_SaveData = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lb_BatchName = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_CheckLogic = new System.Windows.Forms.Button();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ImgV = new ImageViewerTR.ImageViewerTR();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.grd_Image = new DevExpress.XtraGrid.GridControl();
            this.grdV_Image = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splitContainerControl3 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grd_Data = new DevExpress.XtraGrid.GridControl();
            this.grdV_Data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grd_CheckLogic = new DevExpress.XtraGrid.GridControl();
            this.grdV_CheckLogic = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bgw_Load_Data = new System.ComponentModel.BackgroundWorker();
            this.bgw_CheckLogic = new System.ComponentModel.BackgroundWorker();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::HIKARI_HTO_VER2.MyUserControl.WaitForm1), true, true);
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdV_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).BeginInit();
            this.splitContainerControl3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdV_Data)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_CheckLogic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdV_CheckLogic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btn_SaveData);
            this.panel.Controls.Add(this.progressBar1);
            this.panel.Controls.Add(this.lb_BatchName);
            this.panel.Controls.Add(this.btn_start);
            this.panel.Controls.Add(this.btn_CheckLogic);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1434, 31);
            this.panel.TabIndex = 0;
            // 
            // btn_SaveData
            // 
            this.btn_SaveData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SaveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveData.Location = new System.Drawing.Point(1313, 3);
            this.btn_SaveData.Name = "btn_SaveData";
            this.btn_SaveData.Size = new System.Drawing.Size(118, 29);
            this.btn_SaveData.TabIndex = 8;
            this.btn_SaveData.Text = "Save Data";
            this.btn_SaveData.UseVisualStyleBackColor = true;
            this.btn_SaveData.Click += new System.EventHandler(this.btn_SaveData_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(186, 6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(350, 19);
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Visible = false;
            // 
            // lb_BatchName
            // 
            this.lb_BatchName.AutoSize = true;
            this.lb_BatchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BatchName.Location = new System.Drawing.Point(682, 4);
            this.lb_BatchName.Name = "lb_BatchName";
            this.lb_BatchName.Size = new System.Drawing.Size(101, 20);
            this.lb_BatchName.TabIndex = 3;
            this.lb_BatchName.Text = "Batch Name:";
            // 
            // btn_start
            // 
            this.btn_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(1098, 3);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(149, 29);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start LastCheck";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_CheckLogic
            // 
            this.btn_CheckLogic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckLogic.Location = new System.Drawing.Point(3, 3);
            this.btn_CheckLogic.Name = "btn_CheckLogic";
            this.btn_CheckLogic.Size = new System.Drawing.Size(118, 29);
            this.btn_CheckLogic.TabIndex = 0;
            this.btn_CheckLogic.Text = "Check Logic";
            this.btn_CheckLogic.UseVisualStyleBackColor = true;
            this.btn_CheckLogic.Click += new System.EventHandler(this.btn_CheckLogic_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 31);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.panel2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1434, 728);
            this.splitContainerControl1.SplitterPosition = 800;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ImgV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 728);
            this.panel2.TabIndex = 0;
            // 
            // ImgV
            // 
            this.ImgV.BackColor = System.Drawing.Color.LightGray;
            this.ImgV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ImgV.CurrentZoom = 1F;
            this.ImgV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgV.Image = null;
            this.ImgV.Location = new System.Drawing.Point(0, 0);
            this.ImgV.MaxZoom = 20F;
            this.ImgV.MinZoom = 0.05F;
            this.ImgV.Name = "ImgV";
            this.ImgV.Size = new System.Drawing.Size(800, 728);
            this.ImgV.TabIndex = 6;
            this.ImgV.TabStop = false;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.grd_Image);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.splitContainerControl3);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(629, 728);
            this.splitContainerControl2.SplitterPosition = 157;
            this.splitContainerControl2.TabIndex = 1;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // grd_Image
            // 
            this.grd_Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Image.Location = new System.Drawing.Point(0, 0);
            this.grd_Image.MainView = this.grdV_Image;
            this.grd_Image.Name = "grd_Image";
            this.grd_Image.Size = new System.Drawing.Size(157, 728);
            this.grd_Image.TabIndex = 0;
            this.grd_Image.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdV_Image});
            // 
            // grdV_Image
            // 
            this.grdV_Image.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdV_Image.Appearance.Row.Options.UseFont = true;
            this.grdV_Image.GridControl = this.grd_Image;
            this.grdV_Image.IndicatorWidth = 35;
            this.grdV_Image.Name = "grdV_Image";
            this.grdV_Image.OptionsBehavior.Editable = false;
            this.grdV_Image.OptionsBehavior.ReadOnly = true;
            this.grdV_Image.OptionsCustomization.AllowFilter = false;
            this.grdV_Image.OptionsCustomization.AllowSort = false;
            this.grdV_Image.OptionsView.ShowGroupPanel = false;
            this.grdV_Image.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.grdV_Image_CustomDrawRowIndicator);
            this.grdV_Image.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.grdV_Image_RowCellStyle);
            this.grdV_Image.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdV_Image_FocusedRowChanged);
            this.grdV_Image.MouseLeave += new System.EventHandler(this.grdV_Image_MouseLeave);
            // 
            // splitContainerControl3
            // 
            this.splitContainerControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl3.Horizontal = false;
            this.splitContainerControl3.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl3.Name = "splitContainerControl3";
            this.splitContainerControl3.Panel1.AutoScroll = true;
            this.splitContainerControl3.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.splitContainerControl3.Panel1.Controls.Add(this.panel3);
            this.splitContainerControl3.Panel1.Text = "Panel1";
            this.splitContainerControl3.Panel2.AutoScroll = true;
            this.splitContainerControl3.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.splitContainerControl3.Panel2.Controls.Add(this.panel4);
            this.splitContainerControl3.Panel2.Text = "Panel2";
            this.splitContainerControl3.Size = new System.Drawing.Size(467, 728);
            this.splitContainerControl3.SplitterPosition = 539;
            this.splitContainerControl3.TabIndex = 0;
            this.splitContainerControl3.Text = "splitContainerControl3";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grd_Data);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(459, 535);
            this.panel3.TabIndex = 0;
            // 
            // grd_Data
            // 
            this.grd_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Data.Location = new System.Drawing.Point(0, 0);
            this.grd_Data.MainView = this.grdV_Data;
            this.grd_Data.Name = "grd_Data";
            this.grd_Data.Size = new System.Drawing.Size(459, 535);
            this.grd_Data.TabIndex = 1;
            this.grd_Data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdV_Data});
            this.grd_Data.EditorKeyDown += new System.Windows.Forms.KeyEventHandler(this.grd_Data_EditorKeyDown);
            this.grd_Data.Leave += new System.EventHandler(this.grd_Data_Leave);
            // 
            // grdV_Data
            // 
            this.grdV_Data.Appearance.FocusedCell.BackColor = System.Drawing.Color.Khaki;
            this.grdV_Data.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.WhiteSmoke;
            this.grdV_Data.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grdV_Data.Appearance.FocusedRow.BackColor = System.Drawing.Color.Gainsboro;
            this.grdV_Data.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.WhiteSmoke;
            this.grdV_Data.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdV_Data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdV_Data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdV_Data.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.grdV_Data.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdV_Data.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdV_Data.Appearance.Row.Options.UseFont = true;
            this.grdV_Data.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grdV_Data.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.White;
            this.grdV_Data.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grdV_Data.GridControl = this.grd_Data;
            this.grdV_Data.IndicatorWidth = 30;
            this.grdV_Data.Name = "grdV_Data";
            this.grdV_Data.OptionsCustomization.AllowFilter = false;
            this.grdV_Data.OptionsCustomization.AllowSort = false;
            this.grdV_Data.OptionsView.ShowGroupPanel = false;
            this.grdV_Data.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.grdV_Data_CustomDrawRowIndicator);
            this.grdV_Data.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.grdV_Data_RowCellStyle);
            this.grdV_Data.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.grdV_Data_ShowingEditor);
            this.grdV_Data.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grdV_Data_CellValueChanged);
            this.grdV_Data.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grdV_Data_CellValueChanging);
            this.grdV_Data.MouseLeave += new System.EventHandler(this.grdV_Data_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.grd_CheckLogic);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(459, 176);
            this.panel4.TabIndex = 1;
            // 
            // grd_CheckLogic
            // 
            this.grd_CheckLogic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_CheckLogic.Location = new System.Drawing.Point(0, 0);
            this.grd_CheckLogic.MainView = this.grdV_CheckLogic;
            this.grd_CheckLogic.Name = "grd_CheckLogic";
            this.grd_CheckLogic.Size = new System.Drawing.Size(459, 176);
            this.grd_CheckLogic.TabIndex = 2;
            this.grd_CheckLogic.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdV_CheckLogic});
            // 
            // grdV_CheckLogic
            // 
            this.grdV_CheckLogic.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdV_CheckLogic.Appearance.Row.Options.UseFont = true;
            this.grdV_CheckLogic.GridControl = this.grd_CheckLogic;
            this.grdV_CheckLogic.IndicatorWidth = 25;
            this.grdV_CheckLogic.Name = "grdV_CheckLogic";
            this.grdV_CheckLogic.OptionsBehavior.Editable = false;
            this.grdV_CheckLogic.OptionsBehavior.ReadOnly = true;
            this.grdV_CheckLogic.OptionsCustomization.AllowFilter = false;
            this.grdV_CheckLogic.OptionsCustomization.AllowSort = false;
            this.grdV_CheckLogic.OptionsView.ShowGroupPanel = false;
            this.grdV_CheckLogic.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.grdV_CheckLogic_CustomDrawRowIndicator);
            this.grdV_CheckLogic.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.grdV_CheckLogic_RowCellStyle);
            this.grdV_CheckLogic.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdV_CheckLogic_FocusedRowChanged);
            // 
            // bgw_Load_Data
            // 
            this.bgw_Load_Data.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_Load_Data_DoWork);
            this.bgw_Load_Data.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_Load_Data_RunWorkerCompleted);
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // frm_LastCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 759);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_LastCheck";
            this.Text = "LASTCHECK HTO 2022";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_LastCheck_FormClosing);
            this.Load += new System.EventHandler(this.frm_LastCheck_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_LastCheck_KeyDown);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdV_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).EndInit();
            this.splitContainerControl3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdV_Data)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_CheckLogic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdV_CheckLogic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.Panel panel2;
        private ImageViewerTR.ImageViewerTR ImgV;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraGrid.GridControl grd_Image;
        private DevExpress.XtraGrid.Views.Grid.GridView grdV_Image;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl3;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl grd_Data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdV_Data;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraGrid.GridControl grd_CheckLogic;
        private DevExpress.XtraGrid.Views.Grid.GridView grdV_CheckLogic;
        private System.Windows.Forms.Button btn_CheckLogic;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lb_BatchName;
        private System.ComponentModel.BackgroundWorker bgw_Load_Data;
        private System.ComponentModel.BackgroundWorker bgw_CheckLogic;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_SaveData;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}