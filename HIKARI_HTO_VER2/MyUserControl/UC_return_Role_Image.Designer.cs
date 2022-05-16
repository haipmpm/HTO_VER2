
namespace HIKARI_HTO_VER2.MyUserControl
{
    partial class UC_return_Role_Image
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_AT = new System.Windows.Forms.CheckBox();
            this.cb_AE = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_View = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.cb_AT);
            this.panel1.Controls.Add(this.cb_AE);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_View);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 52);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1069, 611);
            this.panel2.TabIndex = 1;
            // 
            // cb_AT
            // 
            this.cb_AT.AutoSize = true;
            this.cb_AT.Checked = true;
            this.cb_AT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_AT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_AT.ForeColor = System.Drawing.Color.White;
            this.cb_AT.Location = new System.Drawing.Point(119, 15);
            this.cb_AT.Name = "cb_AT";
            this.cb_AT.Size = new System.Drawing.Size(50, 24);
            this.cb_AT.TabIndex = 15;
            this.cb_AT.Text = "AT";
            this.cb_AT.UseVisualStyleBackColor = true;
            // 
            // cb_AE
            // 
            this.cb_AE.AutoSize = true;
            this.cb_AE.Checked = true;
            this.cb_AE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_AE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_AE.ForeColor = System.Drawing.Color.White;
            this.cb_AE.Location = new System.Drawing.Point(45, 15);
            this.cb_AE.Name = "cb_AE";
            this.cb_AE.Size = new System.Drawing.Size(52, 24);
            this.cb_AE.TabIndex = 14;
            this.cb_AE.Text = "AE";
            this.cb_AE.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(254, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name Batch:";
            // 
            // btn_View
            // 
            this.btn_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View.ForeColor = System.Drawing.Color.Black;
            this.btn_View.Location = new System.Drawing.Point(838, 8);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(154, 33);
            this.btn_View.TabIndex = 11;
            this.btn_View.Text = "View Info Batch";
            this.btn_View.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(386, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(407, 32);
            this.comboBox1.TabIndex = 16;
            // 
            // UC_return_Role_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_return_Role_Image";
            this.Size = new System.Drawing.Size(1069, 663);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cb_AT;
        private System.Windows.Forms.CheckBox cb_AE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
