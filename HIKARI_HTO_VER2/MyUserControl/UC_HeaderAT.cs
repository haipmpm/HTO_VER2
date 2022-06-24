using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIKARI_HTO_VER2.MyUserControl
{
    public partial class UC_HeaderAT : UserControl
    {
        public object previous { get; set; }
        public object next { get; set; }
        public UC_HeaderAT()
        {
            InitializeComponent();
        }


        public void clearAllText()
        {
            txt_Truong2.Text = "";
            txt_Truong3.Text = "";
            txt_Truong4.Text = "";
            txt_truong5.Text = "";
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                if (txt.Text.Contains('ｰ'))
                {
                    txt.Text = txt.Text.Replace("ｰ", "");
                }
            }
        }
        private void Txt_Truong2_GotFocus(object sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                txt.SelectAll();
            }
        }
        private void txt_No_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (previous is UC_Detail_AT dt)
                    {
                        dt.txt_truong9.Focus();
                    }
                    break;
                case Keys.Down: case Keys.Enter:
                    if (next is UC_Detail_AT dt1)
                    {
                        dt1.Focus();
                    }
                    
                    break;
                case Keys.Right:
                    if (sender == txt_Truong2)
                    {
                        txt_Truong3.Focus();
                    }
                    else if (sender == txt_Truong3)
                    {
                        txt_Truong4.Focus();
                    }
                    else if (sender == txt_Truong4)
                    {
                        txt_truong5.Focus();
                    }
                    else if (sender == txt_truong5)
                    {
                        if (next is UC_Detail_AT dt2)
                        {
                            dt2.Focus();
                        }
                    }
                    break;
                case Keys.Left:
                    if (sender == txt_Truong3)
                    {
                        txt_Truong2.Focus();
                    }
                    else if (sender == txt_Truong4)
                    {
                        txt_Truong3.Focus();
                    }
                    else if (sender == txt_truong5)
                    {
                        txt_Truong4.Focus();
                    }
                    break;
            }
        }

        private void txt_Truong2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }
    }
}
