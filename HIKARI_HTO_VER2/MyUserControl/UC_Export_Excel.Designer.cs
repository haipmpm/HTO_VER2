
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
            this.rdb_AT = new System.Windows.Forms.RadioButton();
            this.rdb_AE = new System.Windows.Forms.RadioButton();
            this.btn_Export = new System.Windows.Forms.Button();
            this.CheckCBB_Export = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_View = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.Tab_Result = new DevExpress.XtraTab.XtraTabPage();
            this.grd_img = new DevExpress.XtraGrid.GridControl();
            this.grdV_img = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Tab_Error = new DevExpress.XtraTab.XtraTabPage();
            this.grd_Error = new DevExpress.XtraGrid.GridControl();
            this.grdV_Error = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckCBB_Export.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.Tab_Result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdV_img)).BeginInit();
            this.Tab_Error.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdV_Error)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
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
            this.panel1.Size = new System.Drawing.Size(1056, 46);
            this.panel1.TabIndex = 2;
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
            this.btn_Export.Location = new System.Drawing.Point(936, 7);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(120, 33);
            this.btn_Export.TabIndex = 10;
            this.btn_Export.Text = "Export Data";
            this.btn_Export.UseVisualStyleBackColor = false;
            // 
            // CheckCBB_Export
            // 
            this.CheckCBB_Export.Location = new System.Drawing.Point(334, 8);
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
            this.label2.Location = new System.Drawing.Point(200, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name Batch:";
            // 
            // btn_View
            // 
            this.btn_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View.ForeColor = System.Drawing.Color.Black;
            this.btn_View.Location = new System.Drawing.Point(776, 7);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(120, 33);
            this.btn_View.TabIndex = 7;
            this.btn_View.Text = "View Data";
            this.btn_View.UseVisualStyleBackColor = true;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1056, 660);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.xtraTabControl1);
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1056, 613);
            this.panel3.TabIndex = 3;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.Tab_Result;
            this.xtraTabControl1.Size = new System.Drawing.Size(1056, 613);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.Tab_Result,
            this.Tab_Error});
            // 
            // Tab_Result
            // 
            this.Tab_Result.Controls.Add(this.grd_img);
            this.Tab_Result.Name = "Tab_Result";
            this.Tab_Result.Size = new System.Drawing.Size(1050, 585);
            this.Tab_Result.Text = "Tab Result";
            // 
            // grd_img
            // 
            this.grd_img.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_img.Location = new System.Drawing.Point(0, 0);
            this.grd_img.MainView = this.grdV_img;
            this.grd_img.Name = "grd_img";
            this.grd_img.Size = new System.Drawing.Size(1050, 585);
            this.grd_img.TabIndex = 0;
            this.grd_img.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdV_img});
            // 
            // grdV_img
            // 
            this.grdV_img.GridControl = this.grd_img;
            this.grdV_img.IndicatorWidth = 30;
            this.grdV_img.Name = "grdV_img";
            this.grdV_img.OptionsView.ColumnAutoWidth = false;
            this.grdV_img.OptionsView.ShowGroupPanel = false;
            this.grdV_img.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.grdV_img_CustomDrawRowIndicator);
            // 
            // Tab_Error
            // 
            this.Tab_Error.Controls.Add(this.grd_Error);
            this.Tab_Error.Name = "Tab_Error";
            this.Tab_Error.Size = new System.Drawing.Size(1050, 585);
            this.Tab_Error.Text = "Tab Error";
            // 
            // grd_Error
            // 
            this.grd_Error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Error.Location = new System.Drawing.Point(0, 0);
            this.grd_Error.MainView = this.grdV_Error;
            this.grd_Error.Name = "grd_Error";
            this.grd_Error.Size = new System.Drawing.Size(1050, 585);
            this.grd_Error.TabIndex = 1;
            this.grd_Error.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdV_Error});
            // 
            // grdV_Error
            // 
            this.grdV_Error.GridControl = this.grd_Error;
            this.grdV_Error.IndicatorWidth = 30;
            this.grdV_Error.Name = "grdV_Error";
            this.grdV_Error.OptionsView.ColumnAutoWidth = false;
            this.grdV_Error.OptionsView.ShowGroupPanel = false;
            this.grdV_Error.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.grdV_Error_CustomDrawRowIndicator);
            // 
            // UC_Export_Excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "UC_Export_Excel";
            this.Size = new System.Drawing.Size(1056, 660);
            this.Load += new System.EventHandler(this.UC_Export_Excel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckCBB_Export.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.Tab_Result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdV_img)).EndInit();
            this.Tab_Error.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdV_Error)).EndInit();
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
    }
}
