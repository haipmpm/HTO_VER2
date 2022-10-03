using HIKARI_HTO_VER2.MyForm;
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
    public partial class UC_HeaderAE : UserControl
    {
        public UC_Detail_AE _nextObject { get; set; }
        public object _previous { get; set; }

        public UC_HeaderAE()
        {
            InitializeComponent();
            txt_Truong2.GotFocus += Txt_GotFocus;
            txt_Truong3.GotFocus += Txt_GotFocus;
            txt_Truong4.GotFocus += Txt_GotFocus;
            txt_Truong5.GotFocus += Txt_GotFocus;

            txt_Truong2.GotFocus += Txt_Truong2_GotFocus;
            txt_Truong3.GotFocus += Txt_Truong2_GotFocus;
            txt_Truong4.GotFocus += Txt_Truong2_GotFocus;
            txt_Truong5.GotFocus += Txt_Truong2_GotFocus;
            lst_txt = new List<TextBox>() { txt_Truong2,txt_Truong3,txt_Truong4,txt_Truong5};
        }

        private void Txt_Truong2_GotFocus(object sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                txt.SelectAll();

            }

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                if (txt.Text.Contains('ｰ'))
                {
                    txt.Text = txt.Text.Replace("ｰ", "");
                }
                if (txt.Text.Contains(' '))
                {
                    txt.Text.Replace(" ", "");
                }
            }
        }
        private void Txt_GotFocus(object sender, EventArgs e)
        {
            (sender as TextBox).SelectAll();
        }

        public void ClearAllText()
        {
            txt_Truong2.Text = "";
            txt_Truong2.BackColor = System.Drawing.Color.White;
            txt_Truong2.ForeColor = System.Drawing.Color.Black;

            txt_Truong3.Text = "";
            txt_Truong3.BackColor = System.Drawing.Color.White;
            txt_Truong3.ForeColor = System.Drawing.Color.Black;

            txt_Truong4.Text = "";
            txt_Truong4.BackColor = System.Drawing.Color.White;
            txt_Truong4.ForeColor = System.Drawing.Color.Black;

            txt_Truong5.Text = "";
            txt_Truong5.BackColor = System.Drawing.Color.White;
            txt_Truong5.ForeColor = System.Drawing.Color.Black;
        }


        public void SetAllText(string txtNo, string txtCode, string txtClass, string txtShelfNum)
        {
            txt_Truong2.Text = txtNo;
            txt_Truong3.Text = txtCode;
            txt_Truong4.Text = txtClass;
            txt_Truong5.Text = txtShelfNum;

        }

        public string GetAllText()
        {
            return txt_Truong2.Text +
                   txt_Truong3.Text +
                   txt_Truong4.Text +
                   txt_Truong5.Text;
        }
        List<TextBox> lst_txt = new List<TextBox>();
        public void txt_No_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.Down:

                    _nextObject.Focus();
                    break;
                case Keys.Right:

                    if (sender == txt_Truong2)
                        txt_Truong3.Focus();
                    else if (sender == txt_Truong3)
                        txt_Truong4.Focus();
                    else if (sender == txt_Truong4)
                        txt_Truong5.Focus();
                    else if (sender == txt_Truong5)
                        _nextObject.Focus();

                    break;
                case Keys.Left:
                    if (sender == txt_Truong3)
                        txt_Truong2.Focus();
                    else if (sender == txt_Truong4)
                        txt_Truong3.Focus();
                    else if (sender == txt_Truong5)
                        txt_Truong4.Focus();
                    break;
                case Keys.Up:
                    if (_previous is UC_Detail_AE dt)
                        dt.Focus();
                    break;
                default:
                    break;
            }

        }

        private void txt_Truong2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }
    }
}
