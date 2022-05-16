
namespace HIKARI_HTO_VER2.MyUserControl
{
    partial class UC_Detail_AT
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
            this.lb_STT = new System.Windows.Forms.Label();
            this.txt_Truong10 = new System.Windows.Forms.TextBox();
            this.txt_truong8 = new System.Windows.Forms.TextBox();
            this.txt_truong9 = new System.Windows.Forms.TextBox();
            this.txt_Truong7 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_STT
            // 
            this.lb_STT.AutoSize = true;
            this.lb_STT.Location = new System.Drawing.Point(4, 11);
            this.lb_STT.Name = "lb_STT";
            this.lb_STT.Size = new System.Drawing.Size(19, 13);
            this.lb_STT.TabIndex = 5;
            this.lb_STT.Text = "01";
            // 
            // txt_Truong10
            // 
            this.txt_Truong10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Truong10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Truong10.Location = new System.Drawing.Point(245, 3);
            this.txt_Truong10.Name = "txt_Truong10";
            this.txt_Truong10.Size = new System.Drawing.Size(38, 26);
            this.txt_Truong10.TabIndex = 1;
            this.txt_Truong10.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txt_Truong10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_MaSP_KeyDown);
            this.txt_Truong10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Truong7_KeyPress);
            this.txt_Truong10.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_truong8_KeyUp);
            // 
            // txt_truong8
            // 
            this.txt_truong8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_truong8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_truong8.Location = new System.Drawing.Point(286, 3);
            this.txt_truong8.Name = "txt_truong8";
            this.txt_truong8.Size = new System.Drawing.Size(78, 26);
            this.txt_truong8.TabIndex = 2;
            this.txt_truong8.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txt_truong8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_MaSP_KeyDown);
            this.txt_truong8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Truong7_KeyPress);
            this.txt_truong8.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_truong8_KeyUp);
            // 
            // txt_truong9
            // 
            this.txt_truong9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_truong9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_truong9.Location = new System.Drawing.Point(367, 3);
            this.txt_truong9.Name = "txt_truong9";
            this.txt_truong9.Size = new System.Drawing.Size(133, 26);
            this.txt_truong9.TabIndex = 3;
            this.txt_truong9.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txt_truong9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_MaSP_KeyDown);
            this.txt_truong9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_truong9_KeyPress);
            this.txt_truong9.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_truong8_KeyUp);
            // 
            // txt_Truong7
            // 
            this.txt_Truong7.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.txt_Truong7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_Truong7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_Truong7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Truong7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Truong7.Location = new System.Drawing.Point(29, 3);
            this.txt_Truong7.Name = "txt_Truong7";
            this.txt_Truong7.Size = new System.Drawing.Size(210, 26);
            this.txt_Truong7.TabIndex = 0;
            this.txt_Truong7.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txt_Truong7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_MaSP_KeyDown);
            this.txt_Truong7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Truong7_KeyPress);
            this.txt_Truong7.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_truong8_KeyUp);
            // 
            // UC_Detail_AT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_Truong7);
            this.Controls.Add(this.lb_STT);
            this.Controls.Add(this.txt_truong9);
            this.Controls.Add(this.txt_truong8);
            this.Controls.Add(this.txt_Truong10);
            this.Name = "UC_Detail_AT";
            this.Size = new System.Drawing.Size(521, 33);
            //this.Load += new System.EventHandler(this.UC_Detail_AT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lb_STT;
        public System.Windows.Forms.TextBox txt_Truong10;
        public System.Windows.Forms.TextBox txt_truong8;
        public System.Windows.Forms.TextBox txt_truong9;
        public System.Windows.Forms.TextBox txt_Truong7;
    }
}
