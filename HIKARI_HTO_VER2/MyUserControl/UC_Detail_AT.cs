using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HIKARI_HTO_VER2.LinqToSQLModels;

namespace HIKARI_HTO_VER2.MyUserControl
{
    
    public partial class UC_Detail_AT : UserControl
    {
        public  object _previous { get; set; }
        public object _next { get; set; }

        List<TextBox> Detail_AT;
        public UC_Detail_AT()
        {
            InitializeComponent();            
            Detail_AT = new List<TextBox>() { txt_Truong7, txt_truong8, txt_truong9, txt_Truong10 };
            UC_Detail_AT_Load();
        }        
        
        private void txt_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TextBox txt = (TextBox)sender;
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '?') && (e.KeyChar != 't'))
            //{
            //    e.Handled = true;
            //}
        }


        private void Txt_Truong7_GotFocus(object sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                txt.SelectAll();
            }
        }

        private void txt_MaSP_KeyDown(object sender, KeyEventArgs e)
        {
           
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (_previous is UC_Detail_AT dt)
                    {
                            if (sender == txt_Truong7)
                            {
                                dt.txt_Truong7.Focus();
                            }
                            else if (sender == txt_Truong10)
                            {
                                dt.txt_Truong10.Focus();
                            }
                            else if (sender == txt_truong8)
                            {
                                dt.txt_truong8.Focus();
                            }
                            else if (sender == txt_truong9)
                            {
                                dt.txt_truong9.Focus();
                            }
                    }
                    else if(_previous is UC_HeaderAT hd)
                    {
                        hd.txt_truong5.Focus();
                    }
                break;
                case Keys.Down: case Keys.Enter:
                    if (_next is UC_HeaderAT hd1)
                    {
                        hd1.Focus();
                    }
                    else if (_next is UC_Detail_AT dt1)
                    {
                        if (sender == txt_Truong7)
                        {
                            dt1.txt_Truong7.Focus();
                        }
                        else if (sender == txt_Truong10)
                        {
                            dt1.txt_Truong10.Focus();
                        }
                        else if (sender == txt_truong8)
                        {
                            dt1.txt_truong8.Focus();
                        }
                        else if (sender == txt_truong9)
                        {
                            dt1.txt_truong9.Focus();
                        }
                    }
                break;
                case Keys.Right:
                    if (sender == txt_truong9)
                    {
                        if (_next is UC_HeaderAT hd2)
                        {
                            hd2.Focus();
                        }
                        else if (_next is UC_Detail_AT dt1)
                        {
                            dt1.Focus();
                        }
                    }
                    else
                    {
                        if (sender == txt_Truong7)
                        {
                            txt_Truong10.Focus();
                        }
                        else if (sender == txt_Truong10)
                        {
                            txt_truong8.Focus();
                        }
                        else if (sender == txt_truong8)
                        {
                            txt_truong9.Focus();
                        }
                      
                    }
                   
                    break;
                case Keys.Tab:
                    if (sender == txt_truong9)
                    {
                        if (_next is UC_HeaderAT hd2)
                        {
                            hd2.Focus();
                        }
                        else if (_next is UC_Detail_AT dt1)
                        {
                            dt1.Focus();
                        }
                    }
                   
                    break;
                case Keys.Left:
                    if (sender == txt_Truong7)
                    {
                        if (true)
                        {
                            if (_previous is UC_HeaderAT hd3)
                            {
                                hd3.txt_truong5.Focus();
                            }
                            else if (_previous is UC_Detail_AT dt2)
                            {
                                dt2.txt_truong9.Focus();
                            }
                        }
                    }
                    else
                    {
                        if (sender == txt_truong9)
                        {
                            txt_truong8.Focus();
                        }
                        else if (sender == txt_truong8)
                        {
                            txt_Truong10.Focus();
                        }
                       else if (sender == txt_Truong10)
                        {
                            txt_Truong7.Focus();
                        }
                    }
                break;
          
            }
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            txt_Truong7.Width = 160;
            Point pt = new Point(79,2);
            txt_Truong7.Location = pt;
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            txt_Truong7.Width = 24;
            Point pt = new Point(215, 2);
            txt_Truong7.Location = pt;
        }


        private void txt_truong8_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Divide)
            {
                if (sender is TextBox txt)
                {
                    if (txt == txt_Truong7)
                    {
                        if (_previous is UC_Detail_AT at)
                        {
                            txt_Truong7.Text = at.txt_Truong7.Text;
                            txt_Truong7.SelectAll();
                        }
                    }
                    else if (txt == txt_truong8)
                    {
                        if (_previous is UC_Detail_AT at)
                        {
                            txt_truong8.Text = at.txt_truong8.Text;
                            txt_truong8.SelectAll();
                        }
                        
                    }
                    else if (txt == txt_truong9)
                    {
                        if (_previous is UC_Detail_AT at)
                        {
                            txt_truong9.Text = at.txt_truong9.Text;
                            txt_truong9.SelectAll();
                        }

                    }
                    else if (txt == txt_Truong10)
                    {
                        if (_previous is UC_Detail_AT at)
                        {
                            txt_Truong10.Text = at.txt_Truong10.Text;
                            txt_Truong10.SelectAll();
                        }
                    }
                }                
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
            }
        }
        private void txt_truong9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar!='?') && (e.KeyChar!='t'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public string getAllText()
        {
            return txt_Truong7.Text + txt_truong8.Text + txt_truong9.Text + txt_Truong10.Text;
        }

        private void txt_Truong7_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = (e.KeyChar == (char)Keys.Space || e.KeyChar == '-' || e.KeyChar == 'ｰ');
            if (e.KeyChar == 'ｰ')
            {
                e.Handled = true ;
            }
            if (e.KeyChar==' ')
            {
                e.Handled = true;
            }
        }

        private void UC_Detail_AT_Load()
        {            
            txt_Truong7.AutoCompleteCustomSource = Global.listAuto;
            txt_Truong7.GotFocus += Txt_Truong7_GotFocus;
            txt_truong8.GotFocus += Txt_Truong7_GotFocus;
            txt_truong9.GotFocus += Txt_Truong7_GotFocus;
            txt_Truong10.GotFocus += Txt_Truong7_GotFocus;
        }
    }
}
