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
    public partial class UC_Detail_AE : UserControl
    {
        public object previous { get; set; }

        public object next { get; set; }
        public UC_Detail_AE()
        {
            InitializeComponent();
            txt_Truong9.GotFocus += Txt_Truong9_GotFocus;
        }

        private void Txt_Truong9_GotFocus(object sender, EventArgs e)
        {
            txt_Truong9.SelectAll();
        }

        private void txt_SoLuong_KeyDown(object sender, KeyEventArgs e)
        {
            #region // Các keys truong9 loai AE
            switch (e.KeyCode)
            {
                case Keys.Down:
                    if (next is UC_Detail_AE dt0)
                    {
                        dt0.Focus();
                    }
                    else if (next is UC_HeaderAE hd)
                    {
                        hd.Focus();
                    }
                    break;
                case Keys.Right:
                    if (next is UC_Detail_AE dt1)
                    {
                        dt1.Focus();
                    }
                    else if (next is UC_HeaderAE hd1)
                    {
                        hd1.Focus();
                    }

                    break;
                case Keys.Left:
                    if (previous is UC_Detail_AE dt2)
                    {
                        dt2.Focus();
                    }
                    else if (previous is UC_HeaderAE hd2)
                    {
                        hd2.txt_Truong5.Focus();
                    }
                    break;
                case Keys.Up:
                    if (previous is UC_Detail_AE dt3)
                    {
                        dt3.Focus();
                    }
                    else if (previous is UC_HeaderAE hd)
                    {
                        hd.txt_Truong5.Focus();
                    }
                    break;

                case Keys.Enter:
                    if (next is UC_Detail_AE dt4)
                    {
                        dt4.Focus();
                    }
                    else if (next is UC_HeaderAE hd)
                    {
                        hd.Focus();
                    }
                    break;

                default:
                    break;
            }
            #endregion
        }

        private void txt_Truong9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '?') && (e.KeyChar != 't'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }  
        }

        private void txt_Truong9_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Divide)
            {
                if (previous is UC_Detail_AE ae)
                {
                    txt_Truong9.Text = ae.txt_Truong9.Text;
                    txt_Truong9.SelectAll();
                }
            }
        }

        private void txt_Truong9_TextChanged(object sender, EventArgs e)
        {
           
                if (txt_Truong9.Text.Contains('ｰ'))
                {
                    txt_Truong9.Text = txt_Truong9.Text.Replace("ｰ","");
                }
            
        }
    }
}
