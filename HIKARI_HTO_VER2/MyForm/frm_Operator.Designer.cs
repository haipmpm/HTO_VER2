
namespace HIKARI_HTO_VER2.MyForm
{
    partial class frm_Operator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Operator));
            this.tab_AT = new DevExpress.XtraTab.XtraTabPage();
            this.uC_PhieuAT1 = new HIKARI_HTO_VER2.MyUserControl.UC_PhieuAT();
            this.lb_IdImage = new System.Windows.Forms.Label();
            this.btn_CopyInfo = new DevExpress.XtraEditors.SimpleButton();
            this.lb_City = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lb_UserName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lb_SoPhieuNhap = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lb_quyDinh = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_BackImage = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Submit_Logout = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Submit = new DevExpress.XtraEditors.SimpleButton();
            this.lb_SoPhieuCon = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lb_TongPhieu = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lb_fBatchName = new DevExpress.XtraEditors.LabelControl();
            this.tabcontrol = new DevExpress.XtraTab.XtraTabControl();
            this.tab_AE = new DevExpress.XtraTab.XtraTabPage();
            this.uC_PhieuAE1 = new HIKARI_HTO_VER2.MyUserControl.UC_PhieuAE();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Right = new DevExpress.XtraEditors.PanelControl();
            this.btn_Review = new DevExpress.XtraEditors.SimpleButton();
            this.splitMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.ImgV = new ImageViewerTR.ImageViewerTR();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel_Top = new DevExpress.XtraEditors.PanelControl();
            this.tab_AT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabcontrol)).BeginInit();
            this.tabcontrol.SuspendLayout();
            this.tab_AE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Right)).BeginInit();
            this.panel_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Top)).BeginInit();
            this.panel_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_AT
            // 
            this.tab_AT.Controls.Add(this.uC_PhieuAT1);
            this.tab_AT.Name = "tab_AT";
            this.tab_AT.Size = new System.Drawing.Size(558, 465);
            this.tab_AT.Text = "Phiếu AT";
            // 
            // uC_PhieuAT1
            // 
            this.uC_PhieuAT1.Location = new System.Drawing.Point(10, 15);
            this.uC_PhieuAT1.Name = "uC_PhieuAT1";
            this.uC_PhieuAT1.Size = new System.Drawing.Size(537, 403);
            this.uC_PhieuAT1.TabIndex = 0;
            // 
            // lb_IdImage
            // 
            this.lb_IdImage.AutoSize = true;
            this.lb_IdImage.Location = new System.Drawing.Point(313, 5);
            this.lb_IdImage.Name = "lb_IdImage";
            this.lb_IdImage.Size = new System.Drawing.Size(13, 13);
            this.lb_IdImage.TabIndex = 13;
            this.lb_IdImage.Text = "_";
            this.toolTip1.SetToolTip(this.lb_IdImage, "Click để copy tên hình");
            // 
            // btn_CopyInfo
            // 
            this.btn_CopyInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CopyInfo.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CopyInfo.Appearance.Options.UseFont = true;
            this.btn_CopyInfo.Location = new System.Drawing.Point(1244, 1);
            this.btn_CopyInfo.Name = "btn_CopyInfo";
            this.btn_CopyInfo.Size = new System.Drawing.Size(74, 25);
            this.btn_CopyInfo.TabIndex = 1;
            this.btn_CopyInfo.Text = "Copy Info";
            this.toolTip1.SetToolTip(this.btn_CopyInfo, "Nhấn để copy Tên Batch, Tên Hình, Username");
            this.btn_CopyInfo.Click += new System.EventHandler(this.btn_CopyInfo_Click);
            // 
            // lb_City
            // 
            this.lb_City.Location = new System.Drawing.Point(625, 6);
            this.lb_City.Name = "lb_City";
            this.lb_City.Size = new System.Drawing.Size(7, 13);
            this.lb_City.TabIndex = 12;
            this.lb_City.Text = "_";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(563, 5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(53, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Loại batch:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(261, 6);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(45, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Tên hình:";
            // 
            // lb_UserName
            // 
            this.lb_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_UserName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lb_UserName.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lb_UserName.Appearance.Options.UseFont = true;
            this.lb_UserName.Appearance.Options.UseForeColor = true;
            this.lb_UserName.Location = new System.Drawing.Point(1378, 7);
            this.lb_UserName.Name = "lb_UserName";
            this.lb_UserName.Size = new System.Drawing.Size(50, 13);
            this.lb_UserName.TabIndex = 11;
            this.lb_UserName.Text = "HVC2022";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Location = new System.Drawing.Point(1324, 7);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(53, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "UserName:";
            // 
            // lb_SoPhieuNhap
            // 
            this.lb_SoPhieuNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_SoPhieuNhap.Location = new System.Drawing.Point(1182, 7);
            this.lb_SoPhieuNhap.Name = "lb_SoPhieuNhap";
            this.lb_SoPhieuNhap.Size = new System.Drawing.Size(7, 13);
            this.lb_SoPhieuNhap.TabIndex = 7;
            this.lb_SoPhieuNhap.Text = "_";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(1106, 7);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Số phiếu nhập:";
            // 
            // lb_quyDinh
            // 
            this.lb_quyDinh.AutoSize = true;
            this.lb_quyDinh.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quyDinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_quyDinh.Location = new System.Drawing.Point(3, -2);
            this.lb_quyDinh.Name = "lb_quyDinh";
            this.lb_quyDinh.Size = new System.Drawing.Size(112, 18);
            this.lb_quyDinh.TabIndex = 0;
            this.lb_quyDinh.Text = "*Quy định nhập";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_Cancel);
            this.panelControl2.Controls.Add(this.btn_Save);
            this.panelControl2.Controls.Add(this.btn_BackImage);
            this.panelControl2.Controls.Add(this.btn_Submit_Logout);
            this.panelControl2.Controls.Add(this.btn_Submit);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(2, 685);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(564, 46);
            this.panelControl2.TabIndex = 1;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Cancel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Appearance.Options.UseFont = true;
            this.btn_Cancel.Location = new System.Drawing.Point(296, 7);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(85, 37);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "Cancel";
            this.toolTip1.SetToolTip(this.btn_Cancel, "Nhấn Ctrl + Enter để submit");
            this.btn_Cancel.Visible = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Save.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Appearance.Options.UseFont = true;
            this.btn_Save.Location = new System.Drawing.Point(114, 6);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(85, 37);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Save";
            this.btn_Save.Visible = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_BackImage
            // 
            this.btn_BackImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BackImage.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BackImage.Appearance.Options.UseFont = true;
            this.btn_BackImage.Location = new System.Drawing.Point(5, 13);
            this.btn_BackImage.Name = "btn_BackImage";
            this.btn_BackImage.Size = new System.Drawing.Size(85, 25);
            this.btn_BackImage.TabIndex = 4;
            this.btn_BackImage.Text = "<< Xem lại";
            this.toolTip1.SetToolTip(this.btn_BackImage, "Nhấn Ctrl + B");
            this.btn_BackImage.Visible = false;
            this.btn_BackImage.Click += new System.EventHandler(this.btn_BackImage_Click);
            // 
            // btn_Submit_Logout
            // 
            this.btn_Submit_Logout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Submit_Logout.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit_Logout.Appearance.Options.UseFont = true;
            this.btn_Submit_Logout.Location = new System.Drawing.Point(353, 7);
            this.btn_Submit_Logout.Name = "btn_Submit_Logout";
            this.btn_Submit_Logout.Size = new System.Drawing.Size(131, 35);
            this.btn_Submit_Logout.TabIndex = 2;
            this.btn_Submit_Logout.Text = "Submit + Logout";
            this.toolTip1.SetToolTip(this.btn_Submit_Logout, "Nhấn Ctrl + L để submit và Logout");
            this.btn_Submit_Logout.Click += new System.EventHandler(this.btn_Submit_Logout_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Submit.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Appearance.Options.UseFont = true;
            this.btn_Submit.Location = new System.Drawing.Point(205, 6);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(85, 37);
            this.btn_Submit.TabIndex = 1;
            this.btn_Submit.Text = "Start";
            this.toolTip1.SetToolTip(this.btn_Submit, "Nhấn Ctrl + Enter để submit");
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lb_SoPhieuCon
            // 
            this.lb_SoPhieuCon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_SoPhieuCon.Location = new System.Drawing.Point(1049, 7);
            this.lb_SoPhieuCon.Name = "lb_SoPhieuCon";
            this.lb_SoPhieuCon.Size = new System.Drawing.Size(7, 13);
            this.lb_SoPhieuCon.TabIndex = 5;
            this.lb_SoPhieuCon.Text = "_";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(981, 7);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Số phiếu còn:";
            // 
            // lb_TongPhieu
            // 
            this.lb_TongPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_TongPhieu.Location = new System.Drawing.Point(927, 7);
            this.lb_TongPhieu.Name = "lb_TongPhieu";
            this.lb_TongPhieu.Size = new System.Drawing.Size(0, 13);
            this.lb_TongPhieu.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(866, 7);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tổng phiếu:";
            // 
            // lb_fBatchName
            // 
            this.lb_fBatchName.Location = new System.Drawing.Point(44, 7);
            this.lb_fBatchName.Name = "lb_fBatchName";
            this.lb_fBatchName.Size = new System.Drawing.Size(6, 13);
            this.lb_fBatchName.TabIndex = 1;
            this.lb_fBatchName.Text = "1";
            this.toolTip1.SetToolTip(this.lb_fBatchName, "Click để copy tên batch");
            // 
            // tabcontrol
            // 
            this.tabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrol.Location = new System.Drawing.Point(0, 0);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedTabPage = this.tab_AE;
            this.tabcontrol.Size = new System.Drawing.Size(564, 493);
            this.tabcontrol.TabIndex = 0;
            this.tabcontrol.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tab_AE,
            this.tab_AT});
            this.toolTip1.SetToolTip(this.tabcontrol, "Nhấn / để chuyển tab Phiếu Bìa và Phiếu Chi Tiết");
            // 
            // tab_AE
            // 
            this.tab_AE.Controls.Add(this.uC_PhieuAE1);
            this.tab_AE.Name = "tab_AE";
            this.tab_AE.Size = new System.Drawing.Size(558, 465);
            this.tab_AE.Text = "Phiếu AE";
            // 
            // uC_PhieuAE1
            // 
            this.uC_PhieuAE1.Location = new System.Drawing.Point(18, 10);
            this.uC_PhieuAE1.Name = "uC_PhieuAE1";
            this.uC_PhieuAE1.Size = new System.Drawing.Size(524, 420);
            this.uC_PhieuAE1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Batch:";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(2, 2);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.tabcontrol);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.label1);
            this.splitContainerControl1.Panel2.Controls.Add(this.lb_quyDinh);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(564, 683);
            this.splitContainerControl1.SplitterPosition = 493;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(3, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xoay trái: Ctrl + Left\r\nXoay phải: Ctrl+ Right\r\nZoom out: Ctrl + Up\r\nZoom in: Ctr" +
    "l + Down";
            // 
            // panel_Right
            // 
            this.panel_Right.Controls.Add(this.splitContainerControl1);
            this.panel_Right.Controls.Add(this.panelControl2);
            this.panel_Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Right.Location = new System.Drawing.Point(0, 0);
            this.panel_Right.Name = "panel_Right";
            this.panel_Right.Size = new System.Drawing.Size(568, 733);
            this.panel_Right.TabIndex = 18;
            // 
            // btn_Review
            // 
            this.btn_Review.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Review.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Review.Appearance.Options.UseFont = true;
            this.btn_Review.Location = new System.Drawing.Point(752, 703);
            this.btn_Review.Name = "btn_Review";
            this.btn_Review.Size = new System.Drawing.Size(85, 25);
            this.btn_Review.TabIndex = 3;
            this.btn_Review.Text = "<< Xem lại";
            this.toolTip1.SetToolTip(this.btn_Review, "Nhấn Ctrl + ← (mũi tên trái)");
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitMain.Location = new System.Drawing.Point(0, 26);
            this.splitMain.Name = "splitMain";
            this.splitMain.Panel1.Controls.Add(this.ImgV);
            this.splitMain.Panel1.Controls.Add(this.btn_Review);
            this.splitMain.Panel1.Text = "Panel1";
            this.splitMain.Panel2.Controls.Add(this.panel_Right);
            this.splitMain.Panel2.Text = "Panel2";
            this.splitMain.Size = new System.Drawing.Size(1434, 733);
            this.splitMain.SplitterPosition = 568;
            this.splitMain.TabIndex = 38;
            this.splitMain.Text = "splitContainerControl1";
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
            this.ImgV.Size = new System.Drawing.Size(861, 733);
            this.ImgV.TabIndex = 5;
            this.ImgV.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Gợi ý";
            // 
            // panel_Top
            // 
            this.panel_Top.Controls.Add(this.lb_IdImage);
            this.panel_Top.Controls.Add(this.btn_CopyInfo);
            this.panel_Top.Controls.Add(this.lb_City);
            this.panel_Top.Controls.Add(this.labelControl5);
            this.panel_Top.Controls.Add(this.labelControl7);
            this.panel_Top.Controls.Add(this.lb_UserName);
            this.panel_Top.Controls.Add(this.labelControl6);
            this.panel_Top.Controls.Add(this.lb_SoPhieuNhap);
            this.panel_Top.Controls.Add(this.labelControl4);
            this.panel_Top.Controls.Add(this.lb_SoPhieuCon);
            this.panel_Top.Controls.Add(this.labelControl3);
            this.panel_Top.Controls.Add(this.lb_TongPhieu);
            this.panel_Top.Controls.Add(this.labelControl2);
            this.panel_Top.Controls.Add(this.lb_fBatchName);
            this.panel_Top.Controls.Add(this.labelControl1);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1434, 26);
            this.panel_Top.TabIndex = 37;
            // 
            // frm_Operator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 759);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.panel_Top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frm_Operator";
            this.Text = "ENTRY";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Operator_FormClosing);
            this.Load += new System.EventHandler(this.frm_Operator_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_Operator_KeyDown);
            this.tab_AT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabcontrol)).EndInit();
            this.tabcontrol.ResumeLayout(false);
            this.tab_AE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_Right)).EndInit();
            this.panel_Right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_Top)).EndInit();
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabPage tab_AT;
        private System.Windows.Forms.Label lb_IdImage;
        private System.Windows.Forms.ToolTip toolTip1;
        protected DevExpress.XtraEditors.SimpleButton btn_CopyInfo;
        private DevExpress.XtraEditors.LabelControl lb_City;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl lb_UserName;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lb_SoPhieuNhap;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Label lb_quyDinh;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Submit_Logout;
        protected DevExpress.XtraEditors.SimpleButton btn_Submit;
        private DevExpress.XtraEditors.LabelControl lb_SoPhieuCon;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lb_TongPhieu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lb_fBatchName;
        private DevExpress.XtraTab.XtraTabControl tabcontrol;
        private DevExpress.XtraTab.XtraTabPage tab_AE;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl panel_Right;
        protected DevExpress.XtraEditors.SimpleButton btn_Review;
        private DevExpress.XtraEditors.SplitContainerControl splitMain;
        private DevExpress.XtraEditors.PanelControl panel_Top;
        private ImageViewerTR.ImageViewerTR ImgV;
        private System.Windows.Forms.Label label1;
        private MyUserControl.UC_PhieuAE uC_PhieuAE1;
        private MyUserControl.UC_PhieuAT uC_PhieuAT1;
        protected DevExpress.XtraEditors.SimpleButton btn_BackImage;
        protected DevExpress.XtraEditors.SimpleButton btn_Cancel;
        protected DevExpress.XtraEditors.SimpleButton btn_Save;
    }
}