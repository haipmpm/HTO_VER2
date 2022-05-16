
namespace HIKARI_HTO_VER2.MyUserControl
{
    partial class UC_ImageView
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
            this.imageBox1 = new ImageGlass.ImageBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ChangeZoom = new System.Windows.Forms.Button();
            this.btn_RotateRight = new System.Windows.Forms.Button();
            this.btn_RotateLeft = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox1.Location = new System.Drawing.Point(0, 0);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(1003, 737);
            this.imageBox1.TabIndex = 0;
            this.imageBox1.MouseLeave += new System.EventHandler(this.imageBox1_MouseLeave);
            this.imageBox1.MouseHover += new System.EventHandler(this.imageBox1_MouseHover);
            this.imageBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageBox1_MouseMove);
            this.imageBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageBox1_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ChangeZoom);
            this.panel1.Controls.Add(this.btn_RotateRight);
            this.panel1.Controls.Add(this.btn_RotateLeft);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 707);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 30);
            this.panel1.TabIndex = 1;
            // 
            // btn_ChangeZoom
            // 
            this.btn_ChangeZoom.Location = new System.Drawing.Point(521, 3);
            this.btn_ChangeZoom.Name = "btn_ChangeZoom";
            this.btn_ChangeZoom.Size = new System.Drawing.Size(105, 23);
            this.btn_ChangeZoom.TabIndex = 0;
            this.btn_ChangeZoom.Text = "Change Zoom";
            this.btn_ChangeZoom.UseVisualStyleBackColor = true;
            this.btn_ChangeZoom.Click += new System.EventHandler(this.btn_ChangeZoom_Click);
            // 
            // btn_RotateRight
            // 
            this.btn_RotateRight.Location = new System.Drawing.Point(440, 3);
            this.btn_RotateRight.Name = "btn_RotateRight";
            this.btn_RotateRight.Size = new System.Drawing.Size(75, 23);
            this.btn_RotateRight.TabIndex = 0;
            this.btn_RotateRight.Text = "Xoay Phải";
            this.btn_RotateRight.UseVisualStyleBackColor = true;
            this.btn_RotateRight.Click += new System.EventHandler(this.btn_RotateRight_Click);
            // 
            // btn_RotateLeft
            // 
            this.btn_RotateLeft.Location = new System.Drawing.Point(359, 3);
            this.btn_RotateLeft.Name = "btn_RotateLeft";
            this.btn_RotateLeft.Size = new System.Drawing.Size(75, 23);
            this.btn_RotateLeft.TabIndex = 0;
            this.btn_RotateLeft.Text = "Xoay trái";
            this.btn_RotateLeft.UseVisualStyleBackColor = true;
            this.btn_RotateLeft.Click += new System.EventHandler(this.btn_RotateLeft_Click);
            // 
            // UC_ImageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imageBox1);
            this.Name = "UC_ImageView";
            this.Size = new System.Drawing.Size(1003, 737);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ChangeZoom;
        private System.Windows.Forms.Button btn_RotateRight;
        private System.Windows.Forms.Button btn_RotateLeft;
        public ImageGlass.ImageBox imageBox1;
    }
}
