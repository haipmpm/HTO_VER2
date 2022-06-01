
namespace HIKARI_HTO_VER2.MyForm
{
    partial class frm_Admin
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Admin));
            this.Tab_Admin = new System.Windows.Forms.TabControl();
            this.Batch_Mng = new System.Windows.Forms.TabPage();
            this.manager_Batch1 = new HIKARI_HTO_VER2.MyUserControl.Manager_Batch();
            this.export_Excel = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Status = new System.Windows.Forms.TabPage();
            this.uC_Status1 = new HIKARI_HTO_VER2.MyUserControl.UC_Admin_Status();
            this.Performance = new System.Windows.Forms.TabPage();
            this.uC_PfmAdmin1 = new HIKARI_HTO_VER2.MyUserControl.UC_Admin_Pfm();
            this.btn_xoa1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btn_Xoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemButtonEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.chk_ApplyEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemButtonEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.uC_Export_Excel1 = new HIKARI_HTO_VER2.MyUserControl.UC_Export_Excel();
            this.Tab_Admin.SuspendLayout();
            this.Batch_Mng.SuspendLayout();
            this.export_Excel.SuspendLayout();
            this.Status.SuspendLayout();
            this.Performance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_xoa1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Xoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_ApplyEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit4)).BeginInit();
            this.SuspendLayout();
            // 
            // Tab_Admin
            // 
            this.Tab_Admin.Controls.Add(this.Batch_Mng);
            this.Tab_Admin.Controls.Add(this.export_Excel);
            this.Tab_Admin.Controls.Add(this.Status);
            this.Tab_Admin.Controls.Add(this.Performance);
            this.Tab_Admin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab_Admin.Location = new System.Drawing.Point(0, 0);
            this.Tab_Admin.Name = "Tab_Admin";
            this.Tab_Admin.SelectedIndex = 0;
            this.Tab_Admin.Size = new System.Drawing.Size(1434, 759);
            this.Tab_Admin.TabIndex = 0;
            this.Tab_Admin.SelectedIndexChanged += new System.EventHandler(this.Tab_Admin_SelectedIndexChanged);
            // 
            // Batch_Mng
            // 
            this.Batch_Mng.Controls.Add(this.manager_Batch1);
            this.Batch_Mng.Location = new System.Drawing.Point(4, 22);
            this.Batch_Mng.Name = "Batch_Mng";
            this.Batch_Mng.Padding = new System.Windows.Forms.Padding(3);
            this.Batch_Mng.Size = new System.Drawing.Size(1426, 733);
            this.Batch_Mng.TabIndex = 0;
            this.Batch_Mng.Text = "Batch Manager";
            this.Batch_Mng.UseVisualStyleBackColor = true;
            // 
            // manager_Batch1
            // 
            this.manager_Batch1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manager_Batch1.Location = new System.Drawing.Point(3, 3);
            this.manager_Batch1.Name = "manager_Batch1";
            this.manager_Batch1.Size = new System.Drawing.Size(1420, 727);
            this.manager_Batch1.TabIndex = 0;
            // 
            // export_Excel
            // 
            this.export_Excel.Controls.Add(this.uC_Export_Excel1);
            this.export_Excel.Controls.Add(this.progressBar1);
            this.export_Excel.Location = new System.Drawing.Point(4, 22);
            this.export_Excel.Name = "export_Excel";
            this.export_Excel.Padding = new System.Windows.Forms.Padding(3);
            this.export_Excel.Size = new System.Drawing.Size(1426, 733);
            this.export_Excel.TabIndex = 1;
            this.export_Excel.Text = "Export Excel";
            this.export_Excel.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(22, -727);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(0, 10);
            this.progressBar1.TabIndex = 11;
            // 
            // Status
            // 
            this.Status.Controls.Add(this.uC_Status1);
            this.Status.Location = new System.Drawing.Point(4, 22);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(1426, 733);
            this.Status.TabIndex = 2;
            this.Status.Text = "Status";
            this.Status.UseVisualStyleBackColor = true;
            // 
            // uC_Status1
            // 
            this.uC_Status1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Status1.Location = new System.Drawing.Point(0, 0);
            this.uC_Status1.Name = "uC_Status1";
            this.uC_Status1.Size = new System.Drawing.Size(1426, 733);
            this.uC_Status1.TabIndex = 0;
            // 
            // Performance
            // 
            this.Performance.Controls.Add(this.uC_PfmAdmin1);
            this.Performance.Location = new System.Drawing.Point(4, 22);
            this.Performance.Name = "Performance";
            this.Performance.Size = new System.Drawing.Size(1426, 733);
            this.Performance.TabIndex = 3;
            this.Performance.Text = "Performance";
            this.Performance.UseVisualStyleBackColor = true;
            // 
            // uC_PfmAdmin1
            // 
            this.uC_PfmAdmin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_PfmAdmin1.Location = new System.Drawing.Point(0, 0);
            this.uC_PfmAdmin1.Name = "uC_PfmAdmin1";
            this.uC_PfmAdmin1.Size = new System.Drawing.Size(1426, 733);
            this.uC_PfmAdmin1.TabIndex = 0;
            // 
            // btn_xoa1
            // 
            this.btn_xoa1.AutoHeight = false;
            editorButtonImageOptions1.ImageUri.Uri = "Cancel;Size16x16";
            this.btn_xoa1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btn_xoa1.ContextImageOptions.ImageUri.Uri = "Cancel;Size16x16";
            this.btn_xoa1.Name = "btn_xoa1";
            this.btn_xoa1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.AutoHeight = false;
            this.btn_Xoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemButtonEdit2
            // 
            this.repositoryItemButtonEdit2.AutoHeight = false;
            editorButtonImageOptions2.ImageUri.Uri = "Cancel;Size16x16";
            this.repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit2.ContextImageOptions.ImageUri.Uri = "Cancel;Size16x16";
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            this.repositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemButtonEdit3
            // 
            this.repositoryItemButtonEdit3.AutoHeight = false;
            this.repositoryItemButtonEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.repositoryItemButtonEdit3.Name = "repositoryItemButtonEdit3";
            this.repositoryItemButtonEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // chk_ApplyEdit
            // 
            this.chk_ApplyEdit.AutoHeight = false;
            this.chk_ApplyEdit.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.chk_ApplyEdit.Name = "chk_ApplyEdit";
            // 
            // repositoryItemButtonEdit4
            // 
            this.repositoryItemButtonEdit4.AutoHeight = false;
            editorButtonImageOptions3.ImageUri.Uri = "Cancel;Size16x16";
            this.repositoryItemButtonEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit4.ContextImageOptions.ImageUri.Uri = "Cancel;Size16x16";
            this.repositoryItemButtonEdit4.Name = "repositoryItemButtonEdit4";
            this.repositoryItemButtonEdit4.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // uC_Export_Excel1
            // 
            this.uC_Export_Excel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Export_Excel1.Location = new System.Drawing.Point(3, 3);
            this.uC_Export_Excel1.Name = "uC_Export_Excel1";
            this.uC_Export_Excel1.Size = new System.Drawing.Size(1420, 727);
            this.uC_Export_Excel1.TabIndex = 12;
            // 
            // frm_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 759);
            this.Controls.Add(this.Tab_Admin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Admin";
            this.Text = "Admin - Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Admin_Load);
            this.Tab_Admin.ResumeLayout(false);
            this.Batch_Mng.ResumeLayout(false);
            this.export_Excel.ResumeLayout(false);
            this.Status.ResumeLayout(false);
            this.Performance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_xoa1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Xoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_ApplyEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab_Admin;
        private System.Windows.Forms.TabPage Batch_Mng;
        private System.Windows.Forms.TabPage export_Excel;
        private System.Windows.Forms.TabPage Status;
        private System.Windows.Forms.TabPage Performance;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_xoa1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_Xoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chk_ApplyEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MyUserControl.Manager_Batch manager_Batch1;
        private MyUserControl.UC_Admin_Pfm uC_PfmAdmin1;
        private MyUserControl.UC_Admin_Status uC_Status1;
        private MyUserControl.UC_Export_Excel uC_Export_Excel1;
    }
}