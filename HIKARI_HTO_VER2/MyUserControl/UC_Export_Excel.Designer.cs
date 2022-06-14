
namespace HIKARI_HTO_VER2.MyUserControl
{
    partial class UC_Export_Excel
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Import_txt = new System.Windows.Forms.Button();
            this.rdb_AT = new System.Windows.Forms.RadioButton();
            this.rdb_AE = new System.Windows.Forms.RadioButton();
            this.btn_Export = new System.Windows.Forms.Button();
            this.CheckCBB_Export = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_View = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.Tab_Result = new DevExpress.XtraTab.XtraTabPage();
            this.grd_img = new DevExpress.XtraGrid.GridControl();
            this.grdV_img = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Tab_Error = new DevExpress.XtraTab.XtraTabPage();
            this.grd_Error = new DevExpress.XtraGrid.GridControl();
            this.grdV_Error = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.grd_CheckTxt = new DevExpress.XtraGrid.GridControl();
            this.grdV_CheckTxt = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rtb_txt = new System.Windows.Forms.RichTextBox();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::HIKARI_HTO_VER2.MyUserControl.WaitForm1), true, true, typeof(System.Windows.Forms.UserControl));
            this.bgw_CheckData = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckCBB_Export.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.Tab_Result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdV_img)).BeginInit();
            this.Tab_Error.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdV_Error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_CheckTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdV_CheckTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Controls.Add(this.btn_Import_txt);
            this.panel1.Controls.Add(this.rdb_AT);
            this.panel1.Controls.Add(this.rdb_AE);
            this.panel1.Controls.Add(this.btn_Export);
            this.panel1.Controls.Add(this.CheckCBB_Export);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_View);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1339, 46);
            this.panel1.TabIndex = 2;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Black;
            this.btn_Save.Location = new System.Drawing.Point(1093, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(120, 33);
            this.btn_Save.TabIndex = 14;
            this.btn_Save.Text = "Save Data";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Import_txt
            // 
            this.btn_Import_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Import_txt.ForeColor = System.Drawing.Color.Black;
            this.btn_Import_txt.Location = new System.Drawing.Point(922, 4);
            this.btn_Import_txt.Name = "btn_Import_txt";
            this.btn_Import_txt.Size = new System.Drawing.Size(120, 33);
            this.btn_Import_txt.TabIndex = 13;
            this.btn_Import_txt.Text = "Import Txt";
            this.btn_Import_txt.UseVisualStyleBackColor = true;
            this.btn_Import_txt.Click += new System.EventHandler(this.btn_Import_txt_Click);
            // 
            // rdb_AT
            // 
            this.rdb_AT.AutoSize = true;
            this.rdb_AT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_AT.ForeColor = System.Drawing.Color.White;
            this.rdb_AT.Location = new System.Drawing.Point(91, 10);
            this.rdb_AT.Name = "rdb_AT";
            this.rdb_AT.Size = new System.Drawing.Size(53, 26);
            this.rdb_AT.TabIndex = 12;
            this.rdb_AT.Text = "AT";
            this.rdb_AT.UseVisualStyleBackColor = true;
            this.rdb_AT.CheckedChanged += new System.EventHandler(this.rdb_AT_CheckedChanged);
            // 
            // rdb_AE
            // 
            this.rdb_AE.AutoSize = true;
            this.rdb_AE.Checked = true;
            this.rdb_AE.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_AE.ForeColor = System.Drawing.Color.White;
            this.rdb_AE.Location = new System.Drawing.Point(16, 10);
            this.rdb_AE.Name = "rdb_AE";
            this.rdb_AE.Size = new System.Drawing.Size(54, 26);
            this.rdb_AE.TabIndex = 11;
            this.rdb_AE.TabStop = true;
            this.rdb_AE.Text = "AE";
            this.rdb_AE.UseVisualStyleBackColor = true;
            this.rdb_AE.CheckedChanged += new System.EventHandler(this.rdb_AE_CheckedChanged);
            // 
            // btn_Export
            // 
            this.btn_Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Export.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Export.Enabled = false;
            this.btn_Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Export.ForeColor = System.Drawing.Color.Black;
            this.btn_Export.Location = new System.Drawing.Point(1219, 4);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(120, 33);
            this.btn_Export.TabIndex = 10;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = false;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // CheckCBB_Export
            // 
            this.CheckCBB_Export.Location = new System.Drawing.Point(287, 7);
            this.CheckCBB_Export.Name = "CheckCBB_Export";
            this.CheckCBB_Export.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckCBB_Export.Properties.Appearance.Options.UseFont = true;
            this.CheckCBB_Export.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CheckCBB_Export.Size = new System.Drawing.Size(406, 30);
            this.CheckCBB_Export.TabIndex = 9;
            this.CheckCBB_Export.Enter += new System.EventHandler(this.CheckCBB_Export_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(153, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name Batch:";
            // 
            // btn_View
            // 
            this.btn_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View.ForeColor = System.Drawing.Color.Black;
            this.btn_View.Location = new System.Drawing.Point(742, 4);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(120, 33);
            this.btn_View.TabIndex = 7;
            this.btn_View.Text = "View";
            this.btn_View.UseVisualStyleBackColor = true;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1339, 660);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.splitContainerControl1);
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1339, 613);
            this.panel3.TabIndex = 3;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1339, 613);
            this.splitContainerControl1.SplitterPosition = 928;
            this.splitContainerControl1.TabIndex = 3;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.Tab_Result;
            this.xtraTabControl1.Size = new System.Drawing.Size(924, 605);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.Tab_Result,
            this.Tab_Error});
            // 
            // Tab_Result
            // 
            this.Tab_Result.Controls.Add(this.grd_img);
            this.Tab_Result.Name = "Tab_Result";
            this.Tab_Result.Size = new System.Drawing.Size(918, 577);
            this.Tab_Result.Text = "Tab Result";
            // 
            // grd_img
            // 
            this.grd_img.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_img.Location = new System.Drawing.Point(0, 0);
            this.grd_img.MainView = this.grdV_img;
            this.grd_img.Name = "grd_img";
            this.grd_img.Size = new System.Drawing.Size(918, 577);
            this.grd_img.TabIndex = 0;
            this.grd_img.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdV_img});
            this.grd_img.EditorKeyDown += new System.Windows.Forms.KeyEventHandler(this.grd_img_EditorKeyDown);
            // 
            // grdV_img
            // 
            this.grdV_img.Appearance.FocusedRow.BackColor = System.Drawing.Color.SkyBlue;
            this.grdV_img.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.White;
            this.grdV_img.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdV_img.GridControl = this.grd_img;
            this.grdV_img.IndicatorWidth = 35;
            this.grdV_img.Name = "grdV_img";
            this.grdV_img.OptionsFind.AlwaysVisible = true;
            this.grdV_img.OptionsPrint.PrintHorzLines = false;
            this.grdV_img.OptionsPrint.PrintVertLines = false;
            this.grdV_img.OptionsView.ColumnAutoWidth = false;
            this.grdV_img.OptionsView.ShowGroupPanel = false;
            this.grdV_img.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.grdV_img_CustomDrawRowIndicator);
            this.grdV_img.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grdV_img_CellValueChanged);
            this.grdV_img.DoubleClick += new System.EventHandler(this.grdV_img_DoubleClick);
            // 
            // Tab_Error
            // 
            this.Tab_Error.Controls.Add(this.grd_Error);
            this.Tab_Error.Name = "Tab_Error";
            this.Tab_Error.Size = new System.Drawing.Size(918, 577);
            this.Tab_Error.Text = "Tab Error";
            // 
            // grd_Error
            // 
            this.grd_Error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Error.Location = new System.Drawing.Point(0, 0);
            this.grd_Error.MainView = this.grdV_Error;
            this.grd_Error.Name = "grd_Error";
            this.grd_Error.Size = new System.Drawing.Size(918, 577);
            this.grd_Error.TabIndex = 1;
            this.grd_Error.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdV_Error});
            // 
            // grdV_Error
            // 
            this.grdV_Error.GridControl = this.grd_Error;
            this.grdV_Error.IndicatorWidth = 30;
            this.grdV_Error.Name = "grdV_Error";
            this.grdV_Error.OptionsPrint.PrintHorzLines = false;
            this.grdV_Error.OptionsPrint.PrintVertLines = false;
            this.grdV_Error.OptionsView.ColumnAutoWidth = false;
            this.grdV_Error.OptionsView.ShowGroupPanel = false;
            this.grdV_Error.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.grdV_Error_CustomDrawRowIndicator);
            this.grdV_Error.DoubleClick += new System.EventHandler(this.grdV_Error_DoubleClick);
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.grd_CheckTxt);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.rtb_txt);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(398, 605);
            this.splitContainerControl2.SplitterPosition = 420;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // grd_CheckTxt
            // 
            this.grd_CheckTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_CheckTxt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_CheckTxt.Location = new System.Drawing.Point(0, 0);
            this.grd_CheckTxt.MainView = this.grdV_CheckTxt;
            this.grd_CheckTxt.Name = "grd_CheckTxt";
            this.grd_CheckTxt.Size = new System.Drawing.Size(394, 420);
            this.grd_CheckTxt.TabIndex = 1;
            this.grd_CheckTxt.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdV_CheckTxt});
            // 
            // grdV_CheckTxt
            // 
            this.grdV_CheckTxt.Appearance.FocusedRow.BackColor = System.Drawing.Color.SkyBlue;
            this.grdV_CheckTxt.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.White;
            this.grdV_CheckTxt.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdV_CheckTxt.GridControl = this.grd_CheckTxt;
            this.grdV_CheckTxt.IndicatorWidth = 35;
            this.grdV_CheckTxt.Name = "grdV_CheckTxt";
            this.grdV_CheckTxt.OptionsCustomization.AllowFilter = false;
            this.grdV_CheckTxt.OptionsCustomization.AllowSort = false;
            this.grdV_CheckTxt.OptionsView.ShowGroupPanel = false;
            this.grdV_CheckTxt.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.grdV_CheckTxt_CustomDrawRowIndicator);
            this.grdV_CheckTxt.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdV_CheckTxt_FocusedRowChanged);
            // 
            // rtb_txt
            // 
            this.rtb_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_txt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_txt.Location = new System.Drawing.Point(0, 0);
            this.rtb_txt.Name = "rtb_txt";
            this.rtb_txt.ReadOnly = true;
            this.rtb_txt.Size = new System.Drawing.Size(394, 176);
            this.rtb_txt.TabIndex = 0;
            this.rtb_txt.Text = "";
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // bgw_CheckData
            // 
            this.bgw_CheckData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_CheckData_DoWork);
            this.bgw_CheckData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_CheckData_RunWorkerCompleted);
            // 
            // UC_Export_Excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "UC_Export_Excel";
            this.Size = new System.Drawing.Size(1339, 660);
            this.Load += new System.EventHandler(this.UC_Export_Excel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckCBB_Export.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.Tab_Result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdV_img)).EndInit();
            this.Tab_Error.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdV_Error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_CheckTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdV_CheckTxt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Export;
        private DevExpress.XtraEditors.CheckedComboBoxEdit CheckCBB_Export;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage Tab_Result;
        private DevExpress.XtraGrid.GridControl grd_img;
        private DevExpress.XtraGrid.Views.Grid.GridView grdV_img;
        private DevExpress.XtraTab.XtraTabPage Tab_Error;
        private DevExpress.XtraGrid.GridControl grd_Error;
        private DevExpress.XtraGrid.Views.Grid.GridView grdV_Error;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdb_AT;
        private System.Windows.Forms.RadioButton rdb_AE;
        private System.Windows.Forms.Button btn_Import_txt;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        //private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private System.Windows.Forms.RichTextBox rtb_txt;
        private DevExpress.XtraGrid.GridControl grd_CheckTxt;
        private DevExpress.XtraGrid.Views.Grid.GridView grdV_CheckTxt;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private System.ComponentModel.BackgroundWorker bgw_CheckData;
        private System.Windows.Forms.Button btn_Save;
    }
}
