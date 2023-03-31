
namespace HIKARI_HTO_VER2.MyForm
{
    partial class frm_CreateBatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CreateBatch));
            this.label3 = new System.Windows.Forms.Label();
            this.txt_PathFolder = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btn_CleanMulti = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_SoLuongHinh = new DevExpress.XtraEditors.LabelControl();
            this.txt_FolderName = new DevExpress.XtraEditors.TextEdit();
            this.txt_UserCreate = new DevExpress.XtraEditors.TextEdit();
            this.txt_DateCreate = new DevExpress.XtraEditors.TextEdit();
            this.cbb_Loai = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chk_ChiaUserDESO = new System.Windows.Forms.CheckBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lb_SobatchHoanThanh = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_CreateBatch = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabSingleBatch = new DevExpress.XtraTab.XtraTabPage();
            this.txt_BatchName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_CleanSingle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_BrowserImage = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_ImagePath = new DevExpress.XtraEditors.TextEdit();
            this.tabMultipleBatch = new DevExpress.XtraTab.XtraTabPage();
            this.btn_Browser = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Location = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lb_SoImageDaHoanThanh = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::HIKARI_HTO_VER2.MyUserControl.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.txt_PathFolder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FolderName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_UserCreate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DateCreate.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tabSingleBatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ImagePath.Properties)).BeginInit();
            this.tabMultipleBatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Location.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(662, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "Số lượng hình:";
            // 
            // txt_PathFolder
            // 
            this.txt_PathFolder.Location = new System.Drawing.Point(167, 21);
            this.txt_PathFolder.Name = "txt_PathFolder";
            this.txt_PathFolder.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PathFolder.Properties.Appearance.Options.UseFont = true;
            this.txt_PathFolder.Size = new System.Drawing.Size(552, 22);
            this.txt_PathFolder.TabIndex = 45;
            this.txt_PathFolder.EditValueChanged += new System.EventHandler(this.txt_PathFolder_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(26, 24);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(121, 16);
            this.labelControl3.TabIndex = 40;
            this.labelControl3.Text = "Folder Batch (nhiều):";
            // 
            // btn_CleanMulti
            // 
            this.btn_CleanMulti.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CleanMulti.Appearance.Options.UseFont = true;
            this.btn_CleanMulti.Enabled = false;
            this.btn_CleanMulti.Location = new System.Drawing.Point(1291, 86);
            this.btn_CleanMulti.Name = "btn_CleanMulti";
            this.btn_CleanMulti.Size = new System.Drawing.Size(161, 40);
            this.btn_CleanMulti.TabIndex = 53;
            this.btn_CleanMulti.Text = "Clean";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Batch Số :";
            // 
            // lb_SoLuongHinh
            // 
            this.lb_SoLuongHinh.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lb_SoLuongHinh.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb_SoLuongHinh.Appearance.Options.UseFont = true;
            this.lb_SoLuongHinh.Appearance.Options.UseForeColor = true;
            this.lb_SoLuongHinh.Location = new System.Drawing.Point(739, 116);
            this.lb_SoLuongHinh.Name = "lb_SoLuongHinh";
            this.lb_SoLuongHinh.Size = new System.Drawing.Size(10, 19);
            this.lb_SoLuongHinh.TabIndex = 37;
            this.lb_SoLuongHinh.Text = "0";
            // 
            // txt_FolderName
            // 
            this.txt_FolderName.Location = new System.Drawing.Point(156, 84);
            this.txt_FolderName.Name = "txt_FolderName";
            this.txt_FolderName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FolderName.Properties.Appearance.Options.UseFont = true;
            this.txt_FolderName.Size = new System.Drawing.Size(687, 22);
            this.txt_FolderName.TabIndex = 74;
            // 
            // txt_UserCreate
            // 
            this.txt_UserCreate.Location = new System.Drawing.Point(156, 55);
            this.txt_UserCreate.Name = "txt_UserCreate";
            this.txt_UserCreate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserCreate.Properties.Appearance.Options.UseFont = true;
            this.txt_UserCreate.Properties.ReadOnly = true;
            this.txt_UserCreate.Size = new System.Drawing.Size(131, 22);
            this.txt_UserCreate.TabIndex = 47;
            // 
            // txt_DateCreate
            // 
            this.txt_DateCreate.Location = new System.Drawing.Point(430, 55);
            this.txt_DateCreate.Name = "txt_DateCreate";
            this.txt_DateCreate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DateCreate.Properties.Appearance.Options.UseFont = true;
            this.txt_DateCreate.Properties.ReadOnly = true;
            this.txt_DateCreate.Size = new System.Drawing.Size(147, 22);
            this.txt_DateCreate.TabIndex = 48;
            // 
            // cbb_Loai
            // 
            this.cbb_Loai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Loai.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Loai.FormattingEnabled = true;
            this.cbb_Loai.Location = new System.Drawing.Point(632, 55);
            this.cbb_Loai.Name = "cbb_Loai";
            this.cbb_Loai.Size = new System.Drawing.Size(211, 24);
            this.cbb_Loai.TabIndex = 50;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chk_ChiaUserDESO);
            this.panel2.Location = new System.Drawing.Point(719, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 25);
            this.panel2.TabIndex = 91;
            // 
            // chk_ChiaUserDESO
            // 
            this.chk_ChiaUserDESO.AutoSize = true;
            this.chk_ChiaUserDESO.Location = new System.Drawing.Point(22, 5);
            this.chk_ChiaUserDESO.Name = "chk_ChiaUserDESO";
            this.chk_ChiaUserDESO.Size = new System.Drawing.Size(105, 17);
            this.chk_ChiaUserDESO.TabIndex = 52;
            this.chk_ChiaUserDESO.Text = "Chia User DESO";
            this.chk_ChiaUserDESO.UseVisualStyleBackColor = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(337, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(235, 27);
            this.labelControl1.TabIndex = 92;
            this.labelControl1.Text = "TẠO BATCH MỚI HTO";
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(-24, 0);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(0, 13);
            this.labelControl15.TabIndex = 89;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(-24, 0);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(0, 13);
            this.labelControl14.TabIndex = 90;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(885, 13);
            this.progressBar1.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // lb_SobatchHoanThanh
            // 
            this.lb_SobatchHoanThanh.AutoSize = true;
            this.lb_SobatchHoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SobatchHoanThanh.Location = new System.Drawing.Point(269, 347);
            this.lb_SobatchHoanThanh.Name = "lb_SobatchHoanThanh";
            this.lb_SobatchHoanThanh.Size = new System.Drawing.Size(15, 16);
            this.lb_SobatchHoanThanh.TabIndex = 93;
            this.lb_SobatchHoanThanh.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 13);
            this.panel1.TabIndex = 96;
            // 
            // btn_CreateBatch
            // 
            this.btn_CreateBatch.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateBatch.Appearance.Options.UseFont = true;
            this.btn_CreateBatch.Location = new System.Drawing.Point(704, 331);
            this.btn_CreateBatch.Name = "btn_CreateBatch";
            this.btn_CreateBatch.Size = new System.Drawing.Size(164, 44);
            this.btn_CreateBatch.TabIndex = 95;
            this.btn_CreateBatch.Text = "Tạo Batch";
            this.btn_CreateBatch.Click += new System.EventHandler(this.btn_CreateBatch_Click_1);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(16, 45);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tabSingleBatch;
            this.xtraTabControl1.Size = new System.Drawing.Size(857, 107);
            this.xtraTabControl1.TabIndex = 98;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabSingleBatch,
            this.tabMultipleBatch});
            // 
            // tabSingleBatch
            // 
            this.tabSingleBatch.Appearance.PageClient.BackColor = System.Drawing.Color.Turquoise;
            this.tabSingleBatch.Appearance.PageClient.Options.UseBackColor = true;
            this.tabSingleBatch.Controls.Add(this.txt_BatchName);
            this.tabSingleBatch.Controls.Add(this.labelControl2);
            this.tabSingleBatch.Controls.Add(this.btn_CleanSingle);
            this.tabSingleBatch.Controls.Add(this.btn_BrowserImage);
            this.tabSingleBatch.Controls.Add(this.labelControl7);
            this.tabSingleBatch.Controls.Add(this.txt_ImagePath);
            this.tabSingleBatch.Name = "tabSingleBatch";
            this.tabSingleBatch.Size = new System.Drawing.Size(851, 79);
            this.tabSingleBatch.Text = "Single Batch";
            // 
            // txt_BatchName
            // 
            this.txt_BatchName.Location = new System.Drawing.Point(167, 16);
            this.txt_BatchName.Name = "txt_BatchName";
            this.txt_BatchName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BatchName.Properties.Appearance.Options.UseFont = true;
            this.txt_BatchName.Size = new System.Drawing.Size(552, 22);
            this.txt_BatchName.TabIndex = 44;
            this.txt_BatchName.EditValueChanged += new System.EventHandler(this.txt_BatchName_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(26, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(97, 16);
            this.labelControl2.TabIndex = 39;
            this.labelControl2.Text = "Tên Batch (đơn):";
            // 
            // btn_CleanSingle
            // 
            this.btn_CleanSingle.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CleanSingle.Appearance.Options.UseFont = true;
            this.btn_CleanSingle.Enabled = false;
            this.btn_CleanSingle.Location = new System.Drawing.Point(1291, 26);
            this.btn_CleanSingle.Name = "btn_CleanSingle";
            this.btn_CleanSingle.Size = new System.Drawing.Size(191, 40);
            this.btn_CleanSingle.TabIndex = 54;
            this.btn_CleanSingle.Text = "Clean";
            // 
            // btn_BrowserImage
            // 
            this.btn_BrowserImage.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BrowserImage.Appearance.Options.UseFont = true;
            this.btn_BrowserImage.Location = new System.Drawing.Point(735, 44);
            this.btn_BrowserImage.Name = "btn_BrowserImage";
            this.btn_BrowserImage.Size = new System.Drawing.Size(109, 23);
            this.btn_BrowserImage.TabIndex = 54;
            this.btn_BrowserImage.Text = "Chọn Image...";
            this.btn_BrowserImage.Click += new System.EventHandler(this.btn_BrowserImage_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(26, 48);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(108, 16);
            this.labelControl7.TabIndex = 36;
            this.labelControl7.Text = "Đường dẫn Image:";
            // 
            // txt_ImagePath
            // 
            this.txt_ImagePath.Location = new System.Drawing.Point(167, 45);
            this.txt_ImagePath.Name = "txt_ImagePath";
            this.txt_ImagePath.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ImagePath.Properties.Appearance.Options.UseFont = true;
            this.txt_ImagePath.Properties.ReadOnly = true;
            this.txt_ImagePath.Size = new System.Drawing.Size(552, 22);
            this.txt_ImagePath.TabIndex = 49;
            // 
            // tabMultipleBatch
            // 
            this.tabMultipleBatch.Controls.Add(this.txt_PathFolder);
            this.tabMultipleBatch.Controls.Add(this.labelControl3);
            this.tabMultipleBatch.Controls.Add(this.btn_CleanMulti);
            this.tabMultipleBatch.Controls.Add(this.btn_Browser);
            this.tabMultipleBatch.Name = "tabMultipleBatch";
            this.tabMultipleBatch.Size = new System.Drawing.Size(851, 79);
            this.tabMultipleBatch.Text = "Multiple Batch";
            // 
            // btn_Browser
            // 
            this.btn_Browser.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browser.Appearance.Options.UseFont = true;
            this.btn_Browser.Location = new System.Drawing.Point(745, 20);
            this.btn_Browser.Name = "btn_Browser";
            this.btn_Browser.Size = new System.Drawing.Size(92, 23);
            this.btn_Browser.TabIndex = 53;
            this.btn_Browser.Text = "Browser...";
            this.btn_Browser.Click += new System.EventHandler(this.btn_Browser_Click);
            // 
            // txt_Location
            // 
            this.txt_Location.EditValue = "X:\\SMC\\";
            this.txt_Location.Location = new System.Drawing.Point(156, 27);
            this.txt_Location.Name = "txt_Location";
            this.txt_Location.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Location.Properties.Appearance.Options.UseFont = true;
            this.txt_Location.Size = new System.Drawing.Size(687, 22);
            this.txt_Location.TabIndex = 46;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(10, 33);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(97, 16);
            this.labelControl4.TabIndex = 41;
            this.labelControl4.Text = "Đường dẫn path:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(10, 61);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(88, 16);
            this.labelControl5.TabIndex = 42;
            this.labelControl5.Text = "User tạo Batch:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(594, 58);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(32, 16);
            this.labelControl8.TabIndex = 38;
            this.labelControl8.Text = "Loại :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(319, 58);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(90, 16);
            this.labelControl6.TabIndex = 43;
            this.labelControl6.Text = "Ngày tạo Batch:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 97;
            this.label2.Text = "So Batch Hoan Thanh:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(10, 90);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(136, 16);
            this.labelControl9.TabIndex = 36;
            this.labelControl9.Text = "Tên Folder Chứa Batch:";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txt_Location);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.lb_SoLuongHinh);
            this.groupControl1.Controls.Add(this.txt_FolderName);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.txt_UserCreate);
            this.groupControl1.Controls.Add(this.txt_DateCreate);
            this.groupControl1.Controls.Add(this.cbb_Loai);
            this.groupControl1.Location = new System.Drawing.Point(18, 158);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(852, 156);
            this.groupControl1.TabIndex = 99;
            this.groupControl1.Text = "Thông tin chung của Batch";
            // 
            // lb_SoImageDaHoanThanh
            // 
            this.lb_SoImageDaHoanThanh.AutoSize = true;
            this.lb_SoImageDaHoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoImageDaHoanThanh.Location = new System.Drawing.Point(15, 348);
            this.lb_SoImageDaHoanThanh.Name = "lb_SoImageDaHoanThanh";
            this.lb_SoImageDaHoanThanh.Size = new System.Drawing.Size(26, 16);
            this.lb_SoImageDaHoanThanh.TabIndex = 94;
            this.lb_SoImageDaHoanThanh.Text = "0/0";
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // frm_CreateBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 438);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.lb_SobatchHoanThanh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_CreateBatch);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lb_SoImageDaHoanThanh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_CreateBatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateBatch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_CreateBatch_FormClosing);
            this.Load += new System.EventHandler(this.frm_CreateBatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_PathFolder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FolderName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_UserCreate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DateCreate.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tabSingleBatch.ResumeLayout(false);
            this.tabSingleBatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ImagePath.Properties)).EndInit();
            this.tabMultipleBatch.ResumeLayout(false);
            this.tabMultipleBatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Location.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txt_PathFolder;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_CleanMulti;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl lb_SoLuongHinh;
        public DevExpress.XtraEditors.TextEdit txt_FolderName;
        private DevExpress.XtraEditors.TextEdit txt_UserCreate;
        private DevExpress.XtraEditors.TextEdit txt_DateCreate;
        private System.Windows.Forms.ComboBox cbb_Loai;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.CheckBox chk_ChiaUserDESO;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lb_SobatchHoanThanh;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_CreateBatch;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tabSingleBatch;
        private DevExpress.XtraEditors.TextEdit txt_BatchName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_CleanSingle;
        private DevExpress.XtraEditors.SimpleButton btn_BrowserImage;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txt_ImagePath;
        private DevExpress.XtraTab.XtraTabPage tabMultipleBatch;
        private DevExpress.XtraEditors.SimpleButton btn_Browser;
        private DevExpress.XtraEditors.TextEdit txt_Location;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label lb_SoImageDaHoanThanh;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}