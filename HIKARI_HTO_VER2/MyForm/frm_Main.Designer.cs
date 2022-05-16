
namespace HIKARI_HTO_VER2.MyForm
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.lb_Title = new System.Windows.Forms.Label();
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Continue = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lb_Funtion = new DevExpress.XtraEditors.LabelControl();
            this.btn_Refresh = new DevExpress.XtraEditors.SimpleButton();
            this.cbb_Function = new System.Windows.Forms.ComboBox();
            this.cbb_Role = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lb_UserName = new DevExpress.XtraEditors.LabelControl();
            this.cbb_batchname = new System.Windows.Forms.ComboBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb_Title.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lb_Title.Location = new System.Drawing.Point(153, 41);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(154, 25);
            this.lb_Title.TabIndex = 1;
            this.lb_Title.Text = "HTO PROJECT";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Appearance.Options.UseFont = true;
            this.btn_thoat.Location = new System.Drawing.Point(249, 392);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(100, 28);
            this.btn_thoat.TabIndex = 20;
            this.btn_thoat.Text = "Cancel";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_Continue
            // 
            this.btn_Continue.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Continue.Appearance.Options.UseFont = true;
            this.btn_Continue.Location = new System.Drawing.Point(121, 392);
            this.btn_Continue.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.Size = new System.Drawing.Size(100, 28);
            this.btn_Continue.TabIndex = 19;
            this.btn_Continue.Text = "OK";
            this.btn_Continue.Click += new System.EventHandler(this.btn_Continue_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lb_Funtion);
            this.groupControl2.Controls.Add(this.btn_Refresh);
            this.groupControl2.Controls.Add(this.cbb_Function);
            this.groupControl2.Controls.Add(this.cbb_Role);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.lb_UserName);
            this.groupControl2.Controls.Add(this.cbb_batchname);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Location = new System.Drawing.Point(1, 87);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(457, 251);
            this.groupControl2.TabIndex = 21;
            this.groupControl2.Text = "Chọn chức năng:";
            // 
            // lb_Funtion
            // 
            this.lb_Funtion.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Funtion.Appearance.Options.UseFont = true;
            this.lb_Funtion.Location = new System.Drawing.Point(53, 164);
            this.lb_Funtion.Margin = new System.Windows.Forms.Padding(4);
            this.lb_Funtion.Name = "lb_Funtion";
            this.lb_Funtion.Size = new System.Drawing.Size(36, 16);
            this.lb_Funtion.TabIndex = 11;
            this.lb_Funtion.Text = "Menu:";
            this.lb_Funtion.Visible = false;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Appearance.Options.UseFont = true;
            this.btn_Refresh.Location = new System.Drawing.Point(380, 113);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(63, 28);
            this.btn_Refresh.TabIndex = 17;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // cbb_Function
            // 
            this.cbb_Function.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Function.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Function.FormattingEnabled = true;
            this.cbb_Function.Location = new System.Drawing.Point(105, 161);
            this.cbb_Function.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_Function.Name = "cbb_Function";
            this.cbb_Function.Size = new System.Drawing.Size(266, 24);
            this.cbb_Function.TabIndex = 10;
            this.cbb_Function.Visible = false;
            // 
            // cbb_Role
            // 
            this.cbb_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Role.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Role.FormattingEnabled = true;
            this.cbb_Role.Location = new System.Drawing.Point(105, 71);
            this.cbb_Role.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_Role.Name = "cbb_Role";
            this.cbb_Role.Size = new System.Drawing.Size(266, 24);
            this.cbb_Role.TabIndex = 9;
            this.cbb_Role.SelectedIndexChanged += new System.EventHandler(this.cbb_Role_SelectedIndexChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(26, 38);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(63, 16);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Username:";
            // 
            // lb_UserName
            // 
            this.lb_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_UserName.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UserName.Appearance.Options.UseFont = true;
            this.lb_UserName.Location = new System.Drawing.Point(105, 38);
            this.lb_UserName.Margin = new System.Windows.Forms.Padding(4);
            this.lb_UserName.Name = "lb_UserName";
            this.lb_UserName.Size = new System.Drawing.Size(8, 16);
            this.lb_UserName.TabIndex = 0;
            this.lb_UserName.Text = "_";
            // 
            // cbb_batchname
            // 
            this.cbb_batchname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_batchname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_batchname.FormattingEnabled = true;
            this.cbb_batchname.Location = new System.Drawing.Point(105, 115);
            this.cbb_batchname.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_batchname.Name = "cbb_batchname";
            this.cbb_batchname.Size = new System.Drawing.Size(266, 24);
            this.cbb_batchname.TabIndex = 7;
            this.cbb_batchname.SelectedIndexChanged += new System.EventHandler(this.cbb_batchname_SelectedIndexChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(20, 118);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(69, 16);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Chọn Batch:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(46, 75);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(43, 16);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Vai trò:";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 495);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_Continue);
            this.Controls.Add(this.lb_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HIKARI HTO LOGIN";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lb_Title;
        public DevExpress.XtraEditors.SimpleButton btn_thoat;
        public DevExpress.XtraEditors.SimpleButton btn_Continue;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl lb_Funtion;
        public DevExpress.XtraEditors.SimpleButton btn_Refresh;
        public System.Windows.Forms.ComboBox cbb_Function;
        public System.Windows.Forms.ComboBox cbb_Role;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lb_UserName;
        public System.Windows.Forms.ComboBox cbb_batchname;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}