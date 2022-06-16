
namespace HIKARI_HTO_VER2.MyUserControl
{
    partial class UC_Admin_Pfm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_SoLuong = new DevExpress.XtraEditors.LabelControl();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Time_End = new DevExpress.XtraEditors.TimeEdit();
            this.time_Start = new DevExpress.XtraEditors.TimeEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpk_pfm_2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpk_pfm_1 = new System.Windows.Forms.DateTimePicker();
            this.btn_Export = new System.Windows.Forms.Button();
            this.btn_View = new System.Windows.Forms.Button();
            this.rdb_LastCheck = new System.Windows.Forms.RadioButton();
            this.rdb_Check = new System.Windows.Forms.RadioButton();
            this.rdb_Entry = new System.Windows.Forms.RadioButton();
            this.grd_pfm_AE = new DevExpress.XtraGrid.GridControl();
            this.grdV_pfm_AE = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabcontrol = new DevExpress.XtraTab.XtraTabControl();
            this.tab_AE = new DevExpress.XtraTab.XtraTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tab_AT = new DevExpress.XtraTab.XtraTabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grd_pfm_AT = new DevExpress.XtraGrid.GridControl();
            this.grdV_pfm_AT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.ComponentLink1 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.ComponentLink2 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.compositeLink1 = new DevExpress.XtraPrintingLinks.CompositeLink(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Time_End.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_Start.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_pfm_AE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdV_pfm_AE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabcontrol)).BeginInit();
            this.tabcontrol.SuspendLayout();
            this.tab_AE.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tab_AT.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_pfm_AT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdV_pfm_AT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.panel1.Controls.Add(this.lb_SoLuong);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.Time_End);
            this.panel1.Controls.Add(this.time_Start);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpk_pfm_2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpk_pfm_1);
            this.panel1.Controls.Add(this.btn_Export);
            this.panel1.Controls.Add(this.btn_View);
            this.panel1.Controls.Add(this.rdb_LastCheck);
            this.panel1.Controls.Add(this.rdb_Check);
            this.panel1.Controls.Add(this.rdb_Entry);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 75);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lb_SoLuong
            // 
            this.lb_SoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_SoLuong.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoLuong.Appearance.ForeColor = System.Drawing.Color.White;
            this.lb_SoLuong.Appearance.Options.UseFont = true;
            this.lb_SoLuong.Appearance.Options.UseForeColor = true;
            this.lb_SoLuong.Location = new System.Drawing.Point(495, 55);
            this.lb_SoLuong.Name = "lb_SoLuong";
            this.lb_SoLuong.Size = new System.Drawing.Size(51, 16);
            this.lb_SoLuong.TabIndex = 26;
            this.lb_SoLuong.Text = "  _         ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(554, 61);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(600, 11);
            this.progressBar1.TabIndex = 14;
            this.progressBar1.Visible = false;
            // 
            // Time_End
            // 
            this.Time_End.EditValue = new System.DateTime(2017, 10, 25, 23, 59, 59, 0);
            this.Time_End.Location = new System.Drawing.Point(275, 46);
            this.Time_End.Name = "Time_End";
            this.Time_End.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_End.Properties.Appearance.Options.UseFont = true;
            this.Time_End.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Time_End.Properties.Mask.EditMask = "HH:mm";
            this.Time_End.Size = new System.Drawing.Size(88, 26);
            this.Time_End.TabIndex = 13;
            // 
            // time_Start
            // 
            this.time_Start.EditValue = new System.DateTime(2022, 5, 12, 0, 0, 0, 0);
            this.time_Start.Location = new System.Drawing.Point(275, 8);
            this.time_Start.Name = "time_Start";
            this.time_Start.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_Start.Properties.Appearance.Options.UseFont = true;
            this.time_Start.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.time_Start.Properties.Mask.EditMask = "HH:mm";
            this.time_Start.Size = new System.Drawing.Size(88, 26);
            this.time_Start.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(19, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Time End:";
            // 
            // dtpk_pfm_2
            // 
            this.dtpk_pfm_2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpk_pfm_2.Location = new System.Drawing.Point(114, 46);
            this.dtpk_pfm_2.Name = "dtpk_pfm_2";
            this.dtpk_pfm_2.Size = new System.Drawing.Size(132, 26);
            this.dtpk_pfm_2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(11, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Time Start:";
            // 
            // dtpk_pfm_1
            // 
            this.dtpk_pfm_1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpk_pfm_1.Location = new System.Drawing.Point(114, 8);
            this.dtpk_pfm_1.Name = "dtpk_pfm_1";
            this.dtpk_pfm_1.Size = new System.Drawing.Size(132, 26);
            this.dtpk_pfm_1.TabIndex = 7;
            this.dtpk_pfm_1.ValueChanged += new System.EventHandler(this.dtpk_pfm_ValueChanged);
            // 
            // btn_Export
            // 
            this.btn_Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Export.ForeColor = System.Drawing.Color.Black;
            this.btn_Export.Location = new System.Drawing.Point(1022, 8);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(132, 33);
            this.btn_Export.TabIndex = 3;
            this.btn_Export.Text = "Export Excel";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // btn_View
            // 
            this.btn_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View.ForeColor = System.Drawing.Color.Black;
            this.btn_View.Location = new System.Drawing.Point(891, 8);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(95, 33);
            this.btn_View.TabIndex = 1;
            this.btn_View.Text = "View";
            this.btn_View.UseVisualStyleBackColor = true;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // rdb_LastCheck
            // 
            this.rdb_LastCheck.AutoSize = true;
            this.rdb_LastCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdb_LastCheck.Location = new System.Drawing.Point(753, 12);
            this.rdb_LastCheck.Name = "rdb_LastCheck";
            this.rdb_LastCheck.Size = new System.Drawing.Size(103, 24);
            this.rdb_LastCheck.TabIndex = 2;
            this.rdb_LastCheck.Text = "LastCheck";
            this.rdb_LastCheck.UseVisualStyleBackColor = true;
            // 
            // rdb_Check
            // 
            this.rdb_Check.AutoSize = true;
            this.rdb_Check.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdb_Check.Location = new System.Drawing.Point(645, 12);
            this.rdb_Check.Name = "rdb_Check";
            this.rdb_Check.Size = new System.Drawing.Size(86, 24);
            this.rdb_Check.TabIndex = 1;
            this.rdb_Check.Text = "Checker";
            this.rdb_Check.UseVisualStyleBackColor = true;
            // 
            // rdb_Entry
            // 
            this.rdb_Entry.AutoSize = true;
            this.rdb_Entry.Checked = true;
            this.rdb_Entry.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdb_Entry.Location = new System.Drawing.Point(554, 12);
            this.rdb_Entry.Name = "rdb_Entry";
            this.rdb_Entry.Size = new System.Drawing.Size(64, 24);
            this.rdb_Entry.TabIndex = 0;
            this.rdb_Entry.TabStop = true;
            this.rdb_Entry.Text = "Entry";
            this.rdb_Entry.UseVisualStyleBackColor = true;
            // 
            // grd_pfm_AE
            // 
            this.grd_pfm_AE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_pfm_AE.Location = new System.Drawing.Point(0, 0);
            this.grd_pfm_AE.MainView = this.grdV_pfm_AE;
            this.grd_pfm_AE.Name = "grd_pfm_AE";
            this.grd_pfm_AE.Size = new System.Drawing.Size(1151, 454);
            this.grd_pfm_AE.TabIndex = 1;
            this.grd_pfm_AE.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdV_pfm_AE});
            // 
            // grdV_pfm_AE
            // 
            this.grdV_pfm_AE.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.grdV_pfm_AE.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdV_pfm_AE.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdV_pfm_AE.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdV_pfm_AE.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.grdV_pfm_AE.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdV_pfm_AE.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdV_pfm_AE.Appearance.Row.Options.UseFont = true;
            this.grdV_pfm_AE.Appearance.Row.Options.UseTextOptions = true;
            this.grdV_pfm_AE.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdV_pfm_AE.GridControl = this.grd_pfm_AE;
            this.grdV_pfm_AE.Name = "grdV_pfm_AE";
            this.grdV_pfm_AE.OptionsBehavior.Editable = false;
            this.grdV_pfm_AE.OptionsBehavior.ReadOnly = true;
            this.grdV_pfm_AE.OptionsView.ShowGroupPanel = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // tabcontrol
            // 
            this.tabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrol.Location = new System.Drawing.Point(0, 75);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedTabPage = this.tab_AE;
            this.tabcontrol.Size = new System.Drawing.Size(1157, 482);
            this.tabcontrol.TabIndex = 2;
            this.tabcontrol.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tab_AE,
            this.tab_AT});
            // 
            // tab_AE
            // 
            this.tab_AE.Controls.Add(this.panel2);
            this.tab_AE.Name = "tab_AE";
            this.tab_AE.Size = new System.Drawing.Size(1151, 454);
            this.tab_AE.Text = "Phiếu AE";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grd_pfm_AE);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1151, 454);
            this.panel2.TabIndex = 0;
            // 
            // tab_AT
            // 
            this.tab_AT.Controls.Add(this.panel4);
            this.tab_AT.Name = "tab_AT";
            this.tab_AT.Size = new System.Drawing.Size(1151, 454);
            this.tab_AT.Text = "Phiếu AT";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.grd_pfm_AT);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1151, 454);
            this.panel4.TabIndex = 0;
            // 
            // grd_pfm_AT
            // 
            this.grd_pfm_AT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_pfm_AT.Location = new System.Drawing.Point(0, 0);
            this.grd_pfm_AT.MainView = this.grdV_pfm_AT;
            this.grd_pfm_AT.Name = "grd_pfm_AT";
            this.grd_pfm_AT.Size = new System.Drawing.Size(1151, 454);
            this.grd_pfm_AT.TabIndex = 2;
            this.grd_pfm_AT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdV_pfm_AT});
            // 
            // grdV_pfm_AT
            // 
            this.grdV_pfm_AT.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdV_pfm_AT.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdV_pfm_AT.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.grdV_pfm_AT.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdV_pfm_AT.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdV_pfm_AT.Appearance.Row.Options.UseFont = true;
            this.grdV_pfm_AT.Appearance.Row.Options.UseTextOptions = true;
            this.grdV_pfm_AT.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdV_pfm_AT.GridControl = this.grd_pfm_AT;
            this.grdV_pfm_AT.Name = "grdV_pfm_AT";
            this.grdV_pfm_AT.OptionsBehavior.Editable = false;
            this.grdV_pfm_AT.OptionsBehavior.ReadOnly = true;
            this.grdV_pfm_AT.OptionsView.ShowGroupPanel = false;
            // 
            // printingSystem1
            // 
            this.printingSystem1.Links.AddRange(new object[] {
            this.ComponentLink1,
            this.ComponentLink2,
            this.compositeLink1});
            // 
            // ComponentLink1
            // 
            this.ComponentLink1.Component = this.grd_pfm_AE;
            this.ComponentLink1.PaperName = "AE";
            this.ComponentLink1.PrintingSystemBase = this.printingSystem1;
            // 
            // ComponentLink2
            // 
            this.ComponentLink2.Component = this.grd_pfm_AT;
            this.ComponentLink2.PaperName = "AT";
            this.ComponentLink2.PrintingSystemBase = this.printingSystem1;
            // 
            // compositeLink1
            // 
            this.compositeLink1.Links.AddRange(new object[] {
            this.ComponentLink1,
            this.ComponentLink2});
            this.compositeLink1.PrintingSystemBase = this.printingSystem1;
            // 
            // UC_Admin_Pfm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabcontrol);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Admin_Pfm";
            this.Size = new System.Drawing.Size(1157, 557);
            this.Load += new System.EventHandler(this.UC_PfmAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Time_End.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_Start.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_pfm_AE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdV_pfm_AE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabcontrol)).EndInit();
            this.tabcontrol.ResumeLayout(false);
            this.tab_AE.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tab_AT.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_pfm_AT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdV_pfm_AT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdb_LastCheck;
        private System.Windows.Forms.RadioButton rdb_Check;
        private System.Windows.Forms.RadioButton rdb_Entry;
        private System.Windows.Forms.Button btn_View;
        private DevExpress.XtraGrid.GridControl grd_pfm_AE;
        private DevExpress.XtraGrid.Views.Grid.GridView grdV_pfm_AE;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.DateTimePicker dtpk_pfm_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpk_pfm_2;
        private DevExpress.XtraEditors.TimeEdit time_Start;
        private DevExpress.XtraEditors.TimeEdit Time_End;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private DevExpress.XtraTab.XtraTabControl tabcontrol;
        private DevExpress.XtraTab.XtraTabPage tab_AE;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraTab.XtraTabPage tab_AT;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraGrid.GridControl grd_pfm_AT;
        private DevExpress.XtraGrid.Views.Grid.GridView grdV_pfm_AT;
        private DevExpress.XtraEditors.LabelControl lb_SoLuong;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem1;
        private DevExpress.XtraPrinting.PrintableComponentLink ComponentLink1;
        private DevExpress.XtraPrinting.PrintableComponentLink ComponentLink2;
        private DevExpress.XtraPrintingLinks.CompositeLink compositeLink1;
    }
}
