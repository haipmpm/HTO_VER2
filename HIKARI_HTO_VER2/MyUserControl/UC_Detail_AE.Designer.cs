
namespace HIKARI_HTO_VER2.MyUserControl
{
    partial class UC_Detail_AE
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
            this.txt_Truong9 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_STT
            // 
            this.lb_STT.AutoSize = true;
            this.lb_STT.Location = new System.Drawing.Point(3, 11);
            this.lb_STT.Name = "lb_STT";
            this.lb_STT.Size = new System.Drawing.Size(19, 13);
            this.lb_STT.TabIndex = 3;
            this.lb_STT.Text = "01";
            // 
            // txt_Truong9
            // 
            this.txt_Truong9.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_Truong9.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_Truong9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Truong9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Truong9.Location = new System.Drawing.Point(28, 3);
            this.txt_Truong9.MaxLength = 12;
            this.txt_Truong9.Name = "txt_Truong9";
            this.txt_Truong9.Size = new System.Drawing.Size(176, 31);
            this.txt_Truong9.TabIndex = 2;
            this.txt_Truong9.TextChanged += new System.EventHandler(this.txt_Truong9_TextChanged);
            this.txt_Truong9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SoLuong_KeyDown);
            this.txt_Truong9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Truong9_KeyPress);
            this.txt_Truong9.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Truong9_KeyUp);
            // 
            // UC_Detail_AE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_STT);
            this.Controls.Add(this.txt_Truong9);
            this.Name = "UC_Detail_AE";
            this.Size = new System.Drawing.Size(221, 36);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lb_STT;
        public System.Windows.Forms.TextBox txt_Truong9;
    }
}
