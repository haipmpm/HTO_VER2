using HIKARI_HTO_VER2.LinqToSQLProcess;
using HIKARI_HTO_VER2.ModuleProcessUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIKARI_HTO_VER2.MyUserControl
{
    public partial class UC_CHECKER_AT : UserControl
    {
        public List<RichTextBox> lst_header_AT = new List<RichTextBox>();
        public List<RichTextBox> lst_body_AT1 = new List<RichTextBox>();
        public List<RichTextBox> lst_body_AT2 = new List<RichTextBox>();
        public List<RichTextBox> lst_body_AT3 = new List<RichTextBox>();
        public List<RichTextBox> lst_body_AT4 = new List<RichTextBox>();
        public List<RichTextBox> lst_body_AT5 = new List<RichTextBox>();
        public List<RichTextBox> lst_body_AT6 = new List<RichTextBox>();
        public List<RichTextBox> lst_body_AT7 = new List<RichTextBox>();
        public List<RichTextBox> lst_body_AT8 = new List<RichTextBox>();
        public List<RichTextBox> lst_body_AT9 = new List<RichTextBox>();
        public List<RichTextBox> lst_body_AT10 = new List<RichTextBox>();
        public List<List<RichTextBox>> lst_to_List_Rtb = new List<List<RichTextBox>>();
        Check_Info CheckInfo;
        Ham_Chung Function_tinhloi;
        List<Label> lb_header = new List<Label>();
        bool bl_Load = false;
        bool isSuggestOpened;
        bool index_User1 = true;
        public UC_CHECKER_AT()
        {
            InitializeComponent();
            lst_header_AT = new List<RichTextBox>() { rtb_truong2, rtb_truong3, rtb_truong4, rtb_truong5 };
            lst_body_AT1 = new List<RichTextBox>() { rtb_truong7_1, rtb_truong10_1, rtb_truong8_1, rtb_truong9_1 };
            lst_body_AT2 = new List<RichTextBox>() { rtb_truong7_2, rtb_truong10_2, rtb_truong8_2, rtb_truong9_2 };
            lst_body_AT3 = new List<RichTextBox>() { rtb_truong7_3, rtb_truong10_3, rtb_truong8_3, rtb_truong9_3 };
            lst_body_AT4 = new List<RichTextBox>() { rtb_truong7_4, rtb_truong10_4, rtb_truong8_4, rtb_truong9_4 };
            lst_body_AT5 = new List<RichTextBox>() { rtb_truong7_5, rtb_truong10_5, rtb_truong8_5, rtb_truong9_5 };
            lst_body_AT6 = new List<RichTextBox>() { rtb_truong7_6, rtb_truong10_6, rtb_truong8_6, rtb_truong9_6 };
            lst_body_AT7 = new List<RichTextBox>() { rtb_truong7_7, rtb_truong10_7, rtb_truong8_7, rtb_truong9_7 };
            lst_body_AT8 = new List<RichTextBox>() { rtb_truong7_8, rtb_truong10_8, rtb_truong8_8, rtb_truong9_8 };
            lst_body_AT9 = new List<RichTextBox>() { rtb_truong7_9, rtb_truong10_9, rtb_truong8_9, rtb_truong9_9 };
            lst_body_AT10 = new List<RichTextBox>() { rtb_truong7_10, rtb_truong10_10, rtb_truong8_10, rtb_truong9_10 };
            lst_to_List_Rtb = new List<List<RichTextBox>>() { lst_header_AT, lst_body_AT1, lst_body_AT2, lst_body_AT3, lst_body_AT4, lst_body_AT5, lst_body_AT6, lst_body_AT7, lst_body_AT8, lst_body_AT9, lst_body_AT10 };
            CheckInfo = new Check_Info();
            Function_tinhloi = new Ham_Chung();
            lb_header = new List<Label>() { lb_t2, lb_t3, lb_t4,lb_t5,lb_stt_1, lb_stt_2, lb_stt_3, lb_stt_4, lb_stt_5, lb_stt_6, lb_stt_7, lb_stt_8, lb_stt_9, lb_stt_10 };
            IndexDiffs = new List<int>();
        }
        
        private void UC_CHECKER_AT_Load(object sender, EventArgs e)
        {
            autocompleteMenu1.Items = Global.ListAutoComP.Items;
            autocompleteMenu1.AllowsTabKey = true;
            autocompleteMenu1.Opening += AutocompleteMenu1_Opening;
            autocompleteMenu1.Selected += AutocompleteMenu1_Selected;
            
            lst_to_List_Rtb.ForEach(x =>{
                x.ForEach(s =>
                {
                    s.MouseDown += new MouseEventHandler(this.rtb_MouseDown);
                    s.KeyPress += new KeyPressEventHandler(this.rtb_KeyPress);
                    s.TextChanged += new EventHandler(this.rtb_TextChanged);
                    s.KeyDown += new KeyEventHandler(this.rtb_KeyDown);
                    s.Enter += new EventHandler(this.rtb_Enter);
                    s.Leave += S_Leave;
                });
            });
            // Clear Toàn bộ dữ liệu
            //lst_to_List_Rtb.ForEach(x => x.Clear());
        }

        private void S_Leave(object sender, EventArgs e)
        {
            RichTextBox rtb = (RichTextBox)(sender);            
            isSuggestOpened = false;
            if (rtb.Name.Contains("rtb_truong7_"))
            {
                autocompleteMenu1.Enabled = false;
            }
        }

        private void AutocompleteMenu1_Selected(object sender, AutocompleteMenuNS.SelectedEventArgs e)
        {
            isSuggestOpened = false;
        }

        private void AutocompleteMenu1_Opening(object sender, CancelEventArgs e)
        {
            isSuggestOpened = true;
        }

        private void rtb_Enter(object sender, EventArgs e)
        {
            RichTextBox rtb = (RichTextBox)(sender);
            rtb.SelectAll();
            isSuggestOpened = false;
            if (rtb.Name.Contains("rtb_truong7_"))
            {
                autocompleteMenu1.Enabled = true;
            }
        }
        private void rtb_KeyDown(object sender, KeyEventArgs e)
        {
            RichTextBox rtb = (RichTextBox)(sender);
            if (isSuggestOpened == false)
            {
                if (e.KeyCode == Keys.Up)
                {
                    try
                    {
                        lst_to_List_Rtb[((rtb.TabIndex - 1) / 4) - 1][(rtb.TabIndex - 1) % 4].Focus();
                        e.Handled = true;
                    }
                    catch { rtb.Focus(); e.Handled = true; }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    try
                    {
                        lst_to_List_Rtb[((rtb.TabIndex - 1) / 4) + 1][(rtb.TabIndex - 1) % 4].Focus();
                        e.Handled = true;
                    }
                    catch { rtb.Focus(); e.Handled = true; }
                }
                else if (e.KeyCode == Keys.Right)
                {
                    try
                    {
                        if ((rtb.TabIndex) % 4 == 0 && rtb.TabIndex > 1)
                        {
                            lst_to_List_Rtb[((rtb.TabIndex - 1) / 4) + 1][0].Focus();
                        }
                        else
                        {
                            lst_to_List_Rtb[(rtb.TabIndex - 1) / 4][((rtb.TabIndex - 1) % 4) + 1].Focus();
                        }

                        e.Handled = true;
                    }
                    catch { rtb.Focus(); e.Handled = true; }
                }
                else if (e.KeyCode == Keys.Left)
                {
                    try
                    {
                        if ((rtb.TabIndex - 1) % 4 == 0 && rtb.TabIndex > 1)
                        {
                            lst_to_List_Rtb[((rtb.TabIndex - 2) / 4)][3].Focus();
                        }
                        else
                        {
                            lst_to_List_Rtb[(rtb.TabIndex - 1) / 4][((rtb.TabIndex - 2) % 4)].Focus();
                        }

                        e.Handled = true;
                    }
                    catch { rtb.Focus(); e.Handled = true; }
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    lst_to_List_Rtb[((rtb.TabIndex - 1) / 4) + 1][(rtb.TabIndex - 1) % 4].Focus();                    
                    e.Handled = true;
                    isSuggestOpened = false;
                }
                catch { rtb.Focus(); e.Handled = true; }
            }
        }
        private void rtb_TextChanged(object sender, EventArgs e)
        {
            RichTextBox rtb = (RichTextBox)(sender);
            if (rtb.Name.ToString().Contains("rtb_truong7_"))
            {
                int index_rtb_7_inList = Convert.ToInt32(rtb.Name.ToString().Split('_')[2].ToString());
                if (rtb.Text.ToUpper() == "SAKUJYO" || rtb.Text.ToUpper() == "YOHAKU" || rtb.Text.ToUpper() == "KAKISONJI" || rtb.Text.ToUpper() == "MISIYO")
                {
                    lst_to_List_Rtb[index_rtb_7_inList][1].Text = "";
                    lst_to_List_Rtb[index_rtb_7_inList][2].Text = "";
                    lst_to_List_Rtb[index_rtb_7_inList][3].Text = "";
                    lst_to_List_Rtb[index_rtb_7_inList][1].Enabled = false;
                    lst_to_List_Rtb[index_rtb_7_inList][2].Enabled = false;
                    lst_to_List_Rtb[index_rtb_7_inList][3].Enabled = false;
                    if (bl_Load == false)
                    {
                        if (rtb.Text.ToUpper() == "YOHAKU" || rtb.Text.ToUpper() == "KAKISONJI" || rtb.Text.ToUpper() == "MISIYO")
                        {
                            for (int i = index_rtb_7_inList + 1; i < lst_to_List_Rtb.Count; i++)
                            {
                                lst_to_List_Rtb[i][0].Text = rtb.Text.ToUpper();
                                lst_to_List_Rtb[i][1].Text = "";
                                lst_to_List_Rtb[i][2].Text = "";
                                lst_to_List_Rtb[i][3].Text = "";
                                lst_to_List_Rtb[i][0].Enabled = false;
                                lst_to_List_Rtb[i][1].Enabled = false;
                                lst_to_List_Rtb[i][2].Enabled = false;
                                lst_to_List_Rtb[i][3].Enabled = false;
                            }
                        }
                        else
                        {
                            for (int i = index_rtb_7_inList + 1; i < lst_to_List_Rtb.Count; i++)
                            {
                                lst_to_List_Rtb[i][0].Enabled = true;
                                lst_to_List_Rtb[i][1].Enabled = true;
                                lst_to_List_Rtb[i][2].Enabled = true;
                                lst_to_List_Rtb[i][3].Enabled = true;
                            }
                        }
                    }
                }
                else
                {
                    lst_to_List_Rtb[index_rtb_7_inList][0].Enabled = true;
                    lst_to_List_Rtb[index_rtb_7_inList][1].Enabled = true;
                    lst_to_List_Rtb[index_rtb_7_inList][2].Enabled = true;
                    lst_to_List_Rtb[index_rtb_7_inList][3].Enabled = true;
                    lst_header_AT[1].Enabled = true;
                    lst_header_AT[2].Enabled = true;
                    lst_header_AT[3].Enabled = true;
                }                
            }            
        }
        private void rtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            RichTextBox rtb = (RichTextBox)(sender);
            if (rtb.TabIndex == 2)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else if (rtb.TabIndex / 4 > 1 && rtb.TabIndex % 4 == 0)
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
            e.KeyChar = Char.ToUpper(e.KeyChar);

        }
        private void rtb_Click(object sender, KeyEventArgs e)
        {
            RichTextBox rtb = (RichTextBox)(sender);
        }

        private void rtb_MouseDown(object sender, MouseEventArgs e)
        {
            RichTextBox rtb = (RichTextBox)sender;
            if (e.Button == MouseButtons.Right)
            {
                if (rtb.TabIndex > 0)
                {
                    bl_Load = true;
                    if (rtb.Text == CheckInfo.Content_E1_Tam.Split('‡')[(rtb.TabIndex - 1) /4].Split('†')[(rtb.TabIndex - 1) % 4].ToString())
                    {
                        IndexDiffs = new List<int>();
                        rtb.SelectionStart = 0;
                        rtb.SelectionLength = rtb.Text.Length;
                        rtb.SelectionColor = Color.Red;
                        rtb.Text = CheckInfo.Content_E2_Tam.Split('‡')[(rtb.TabIndex - 1) / 4].Split('†')[(rtb.TabIndex - 1) % 4].ToString();
                        string s1, s2;
                        s1 = new string( CheckInfo.Content_E2_Tam.Split('‡')[(rtb.TabIndex - 1) / 4].Split('†')[(rtb.TabIndex - 1) % 4].ToString().ToArray().Reverse().ToArray());
                        s2 = new string( CheckInfo.Content_E1_Tam.Split('‡')[(rtb.TabIndex - 1) / 4].Split('†')[(rtb.TabIndex - 1) % 4].ToString().ToArray().Reverse().ToArray());
                        c = null;
                        c = new int[s1.Length + 1, s2.Length + 1];
                        LCS(s1, s2);
                        BackTrack_new(s1, s2, s1.Length, s2.Length, rtb);
                        FillColorDiff(rtb, IndexDiffs, true);
                        lb_User2.ForeColor = Color.Orange;
                        lb_User1.ForeColor = Color.Black;
                    }
                    else if (rtb.Text == CheckInfo.Content_E2_Tam.Split('‡')[(rtb.TabIndex - 1) / 4].Split('†')[(rtb.TabIndex - 1) % 4].ToString())
                    {
                        IndexDiffs = new List<int>();
                        rtb.SelectionStart = 0;
                        rtb.SelectionLength = rtb.Text.Length;
                        rtb.SelectionColor = Color.Red;
                        rtb.Text = CheckInfo.Content_E1_Tam.Split('‡')[(rtb.TabIndex - 1) / 4].Split('†')[(rtb.TabIndex - 1) % 4].ToString();
                        string s1, s2;
                        s1 = new string( CheckInfo.Content_E1_Tam.Split('‡')[(rtb.TabIndex - 1) / 4].Split('†')[(rtb.TabIndex - 1) % 4].ToString().ToArray().Reverse().ToArray());
                        s2 = new string( CheckInfo.Content_E2_Tam.Split('‡')[(rtb.TabIndex - 1) / 4].Split('†')[(rtb.TabIndex - 1) % 4].ToString().ToArray().Reverse().ToArray());
                        c = null;
                        c = new int[s1.Length + 1, s2.Length + 1];
                        LCS(s1, s2);
                        BackTrack_new(s1, s2, s1.Length, s2.Length, rtb);
                        FillColorDiff(rtb, IndexDiffs, true);
                        lb_User1.ForeColor = Color.Orange;
                        lb_User2.ForeColor = Color.Black;
                    }
                    else
                    {
                        IndexDiffs = new List<int>();
                        rtb.SelectionStart = 0;
                        rtb.SelectionLength = rtb.Text.Length;
                        rtb.SelectionColor = Color.Red;
                        rtb.Text = CheckInfo.Content_E1_Tam.Split('‡')[(rtb.TabIndex - 1) / 4].Split('†')[(rtb.TabIndex - 1) % 4].ToString();
                        string s1, s2;
                        s1 = new string( CheckInfo.Content_E1_Tam.Split('‡')[(rtb.TabIndex - 1) / 4].Split('†')[(rtb.TabIndex - 1) % 4].ToString().ToArray().Reverse().ToArray());
                        s2 = new string( CheckInfo.Content_E2_Tam.Split('‡')[(rtb.TabIndex - 1) / 4].Split('†')[(rtb.TabIndex - 1) % 4].ToString().ToArray().Reverse().ToArray());
                        c = null;
                        c = new int[s1.Length + 1, s2.Length + 1];
                        LCS(s1, s2);
                        BackTrack_new(s1, s2, s1.Length, s2.Length, rtb);
                        FillColorDiff(rtb, IndexDiffs, true);
                        lb_User1.ForeColor = Color.Orange;
                        lb_User2.ForeColor = Color.Black;
                    }
                    bl_Load = false;
                }                
            }
        }
        public void FocusUC()
        {
            this.BeginInvoke(new Action(() =>
            {
                rtb_truong2.Focus();
            }));

        }
        public bool ConfirmEmptyWarning()
        {
            string data_all = ""; data_all = String.Join("", lst_header_AT);
            for (int i = 0; i < lst_to_List_Rtb.Count; i++)
            {
                data_all += lst_to_List_Rtb[i].Select(x => x.Text.Replace("†", "").Replace("‡", "").ToString());
            }

            string data_test = String.Join("", lst_to_List_Rtb.Select(x => x.Select(s => s.Text.Replace("†", "").Replace("‡", "").ToString())));
            if (data_all == "")
                if (MessageBox.Show(Global.MsgWarning, Global.warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    return false;
            return true;
        }
        public void Add_Data_AT(Check_Info InfoCheck)
        {
            // Clear Toàn bộ dữ liệu
            lb_header.ForEach(x => x.BackColor = Color.WhiteSmoke);
            lst_to_List_Rtb.ForEach(x => x.ForEach(s=> { s.Text = ""; s.ForeColor = Color.Red; s.BackColor = Color.WhiteSmoke; }));            
            CheckInfo = InfoCheck;

            CheckInfo.Content_E1_Tam = CheckInfo.Content_E1;
            CheckInfo.Content_E2_Tam = CheckInfo.Content_E2;

            lb_User1.Text = "Name 1: " + CheckInfo.UserName_E1.ToString();
            lb_User1.ForeColor = Color.Orange;
            lb_User2.Text = "Name 2: " + CheckInfo.UserName_E2.ToString();
            lb_User2.ForeColor = Color.Black;            
            //string s1 = "", s2 = "";
            #region ADD Info cho các trường ở giao diện AT
            bl_Load = true;
            for (int i = 0; i < lst_to_List_Rtb.Count; i++)
            {
                for (int z = 0; z < lst_to_List_Rtb[i].Count; z++)
                {
                    IndexDiffs = new List<int>();
                    lst_to_List_Rtb[i][z].ForeColor =  Color.Red;
                    string s1 = "", s2 = "";
                    lst_to_List_Rtb[i][z].Text = CheckInfo.Content_E1_Tam.Split('‡')[i].Split('†')[z].ToString();
                    s1 = new string( CheckInfo.Content_E1_Tam.Split('‡')[i].Split('†')[z].ToString().ToArray().Reverse().ToArray());
                    s2 = new string( CheckInfo.Content_E2_Tam.Split('‡')[i].Split('†')[z].ToString().ToArray().Reverse().ToArray());
                    
                    if (s1 != s2)
                    {
                        lst_to_List_Rtb[i][z].BackColor = Color.SandyBrown;
                    }                        
                    c = null;
                    c = new int[s1.Length + 1, s2.Length + 1];
                    LCS(s1, s2);
                    BackTrack_new(s1, s2, s1.Length, s2.Length, lst_to_List_Rtb[i][z]);
                    FillColorDiff(lst_to_List_Rtb[i][z], IndexDiffs, true);
                }
            }
            bl_Load = false;
            index_User1 = true;
            #endregion
        }
        public int Submit_Data_Check(int ID_Batch, int ID_Image)
        {
            isSuggestOpened = false;
            if (String.IsNullOrEmpty(rtb_truong2.Text) == true)
            {
                return 1;
            }
            // Bổ sung thêm quy định của AT (7 8 9 10 trống thì không cho Submit)
            for (int i = 1; i < lst_to_List_Rtb.Count; i++)
            {
                if (lst_to_List_Rtb[i][0].Text + lst_to_List_Rtb[i][1].Text + lst_to_List_Rtb[i][2].Text + lst_to_List_Rtb[i][3].Text  == "")
                {
                    return 5;
                }
            }
            if (ID_Batch <= 0 || ID_Image <= 0)
            {
                return 0;
            }
            // Trường 7 ở mỗi dòng không được bỏ trống
            //string str_data_header_AE = String.Join("†", lst_header_AT.Select(x => x.Text.Replace("†", "").Replace("‡", "").ToString()));
            
            List<string> lst_str_data_body_AT = new List<string>();
            for (int i = 0; i < lst_to_List_Rtb.Count; i++)
            {
                if (lst_to_List_Rtb[i].ToList()[1].ToString() != "")
                {
                    lst_str_data_body_AT.Add(String.Join("†", lst_to_List_Rtb[i].Select(x => x.Text.Replace("†", "").Replace("‡", "").ToString())));
                }
                else
                {
                    if (i == 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
            string data_full = Function_tinhloi.ToHalfWidth(String.Join("‡", lst_str_data_body_AT));            
            
            int Error_E1 = 0, Error_E2 = 0;
            if (Function_tinhloi.return_error(CheckInfo.Content_E1.Split('‡')[0].ToString(), String.Join("†",lst_header_AT.Select(x => x.Text)).ToString() ) > 0)
            {
                Error_E1++;
            }
            if (Function_tinhloi.return_error(CheckInfo.Content_E2.Split('‡')[0].ToString(), String.Join("†", lst_header_AT.Select(x => x.Text)).ToString()) > 0)
            {
                Error_E2++;
            }

            if (Error_E1 == 0)
            {
                int row_E1_Create = 0;
                for (int i = 1; i < lst_to_List_Rtb.Count; i++)
                {
                    if (Function_tinhloi.return_error(CheckInfo.Content_E1.Split('‡')[i].ToString().Replace("‡", "").Replace("†", "").ToString(), String.Join("", lst_to_List_Rtb[i].Select(x => x.Text.Replace("†", "").Replace("‡", "").ToString()))) > 0)
                    {
                        Error_E1++;
                    }
                    string Data_nhap = CheckInfo.Content_E1.Split('‡')[i].ToString().Split('†')[0].ToString();
                    if (Data_nhap != "" && Data_nhap != "SAKUJYO" && Data_nhap != "YOHAKU" && Data_nhap != "KAKISONJI" && Data_nhap != "MISIYO")
                    {
                        row_E1_Create = i;
                    }
                }
                if (Error_E1 > row_E1_Create)
                {
                    Error_E1 = row_E1_Create;
                }
            }
            else
            {
                for (int i = 1; i < lst_to_List_Rtb.Count; i++)
                {
                    string Data_nhap = CheckInfo.Content_E1.Split('‡')[i].ToString().Split('†')[0].ToString();
                    if (Data_nhap != "" && Data_nhap != "SAKUJYO" && Data_nhap != "YOHAKU" && Data_nhap != "KAKISONJI" && Data_nhap != "MISIYO")
                    {
                        Error_E1 = i;
                    }
                }
            }

            if (Error_E2 == 0)
            {
                int row_E2_Create = 0;
                for (int i = 1; i < lst_to_List_Rtb.Count; i++)
                {
                    if (Function_tinhloi.return_error(CheckInfo.Content_E2.Split('‡')[i].ToString().Replace("‡", "").Replace("†", "").ToString(), String.Join("", lst_to_List_Rtb[i].Select(x => x.Text.Replace("†", "").Replace("‡", "").ToString()))) > 0)
                    {
                        Error_E2++;
                    }
                    string Data_nhap = CheckInfo.Content_E2.Split('‡')[i].ToString().Split('†')[0].ToString();
                    if (Data_nhap != "" && Data_nhap != "SAKUJYO" && Data_nhap != "YOHAKU" && Data_nhap != "KAKISONJI" && Data_nhap != "MISIYO")
                    {
                        row_E2_Create = i;
                    }
                }
                if (Error_E2 > row_E2_Create)
                {
                    Error_E2 = row_E2_Create;
                }
            }
            else
            {
                for (int i = 0; i < lst_to_List_Rtb.Count; i++)
                {
                    string Data_nhap = CheckInfo.Content_E2.Split('‡')[i].ToString().Split('†')[0].ToString();
                    if (Data_nhap != "" && Data_nhap != "SAKUJYO" && Data_nhap != "YOHAKU" && Data_nhap != "KAKISONJI" && Data_nhap != "MISIYO")
                    {
                        Error_E2 = i;
                    }
                }
            }
            try
            {
                GlobalDB.DBLinq.spData_Submit_Check_v2(ID_Batch, ID_Image, Error_E1, Error_E2, data_full,
                    Global.Level_Image);
            }
            catch
            { return 4; }
            //try
            //{
            //    string ConnectionString = Global.ConnectionString;
            //    SqlConnection con = new SqlConnection(ConnectionString);
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand("spData_Submit_Check_v2", con);
            //    cmd.Parameters.Clear();
            //    cmd.CommandTimeout = 10 * 60;
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    //SqlParameter param = new SqlParameter();
            //    //cmd.Parameters.AddWithValue("@ListDetail", takeDataTableDetail()).SqlDbType = SqlDbType.Structured;
            //    cmd.Parameters.AddWithValue("@ID_Image_Data", ID_Image.ToString());
            //    cmd.Parameters.AddWithValue("@BatchID", ID_Batch.ToString());
            //    cmd.Parameters.AddWithValue("@Data_Submit", data_full);
            //    cmd.Parameters.AddWithValue("@Error_E1", Error_E1.ToString());
            //    cmd.Parameters.AddWithValue("@Error_E2", Error_E2.ToString());
            //    cmd.Parameters.AddWithValue("@Level_Image", Global.Level_Image.ToString());
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //}
            //catch
            //{
            //    return 4;
            //}
            return 3;
        }
        #region Compare string
        static int max(int a, int b)
        {
            return (a > b) ? a : b;
        }
        static int[,] c;
        //Prints one LCS
        //private string BackTrack(string s1, string s2, int i, int j, RichTextBox rtb)
        //{
        //    if (i == 0 || j == 0)
        //        return "";
        //    if (s1[i - 1] == s2[j - 1])
        //    {
        //        rtb.SelectionStart = i - 1;
        //        rtb.SelectionLength = 1;
        //        rtb.SelectionColor = Color.Black;
        //        return BackTrack(s1, s2, i - 1, j - 1, rtb) + s1[i - 1];
        //    }
        //    else if (c[i - 1, j] > c[i, j - 1])
        //        return BackTrack(s1, s2, i - 1, j, rtb);

        //    else
        //        return BackTrack(s1, s2, i, j - 1, rtb);

        //}
        List<int> IndexDiffs;
        private string BackTrack_new(string s1, string s2, int lengs1, int lengs2, RichTextBox rtb)
        {
            if (lengs1 == 0 || lengs2 == 0)
                return "";
            if (s1[lengs1 - 1] == s2[lengs2 - 1])
            {
                IndexDiffs.Add(lengs1 - 1);
                //rtb.SelectionStart = i - 1;
                //rtb.SelectionLength = 1;
                //rtb.SelectionColor = Color.Black;
                return BackTrack_new(s1, s2, lengs1 - 1, lengs2 - 1, rtb); //+ s1[lengs1 - 1];
            }
            else if (c[lengs1 - 1, lengs2] >= c[lengs1, lengs2 - 1])
                return BackTrack_new(s1, s2, lengs1 - 1, lengs2, rtb);

            else
                return BackTrack_new(s1, s2, lengs1, lengs2 - 1, rtb);

        }
        void FillColorDiff(RichTextBox rtb, List<int> lDiff, bool isReverse)
        {
            if (isReverse)
            {
                //lDiff.Reverse();
                foreach (int diff in lDiff)
                {
                    rtb.SelectionStart = rtb.TextLength - diff - 1;
                    rtb.SelectionLength = 1;
                    rtb.SelectionColor = Color.Black;
                }
            }
            else
            {
                foreach (int diff in lDiff)
                {
                    rtb.SelectionStart = diff;
                    rtb.SelectionLength = 1;
                    rtb.SelectionColor = Color.Black;
                }
            }
        }           
        
        static int LCS(string s1, string s2)
        {
            for (int i = 1; i <= s1.Length; i++)
                c[i, 0] = 0;
            for (int i = 1; i <= s2.Length; i++)
                c[0, i] = 0;

            for (int i = 1; i <= s1.Length; i++)
                for (int j = 1; j <= s2.Length; j++)
                {
                    if (s1[i - 1] == s2[j - 1])
                        c[i, j] = c[i - 1, j - 1] + 1;
                    else
                    {
                        c[i, j] = max(c[i - 1, j], c[i, j - 1]);

                    }
                }
            return c[s1.Length, s2.Length];
        }
        #endregion

        private void rtb_truong2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void lb_User1_Click(object sender, EventArgs e)
        {
            if (!index_User1 )
            {
                List<string> lst_str_data_body_AT = new List<string>();
                for (int i = 0; i < lst_to_List_Rtb.Count; i++)
                {
                    lst_str_data_body_AT.Add(String.Join("†", lst_to_List_Rtb[i].Select(x => x.Text.Replace("†", "").Replace("‡", "").ToString())));
                }
                string data_full = Function_tinhloi.ToHalfWidth(String.Join("‡", lst_str_data_body_AT));
                CheckInfo.Content_E2_Tam = data_full;
            }
            

            lb_header.ForEach(x => x.BackColor = Color.WhiteSmoke);
            lst_to_List_Rtb.ForEach(x => x.ForEach(s => { s.Text = ""; s.ForeColor = Color.Red; s.BackColor = Color.WhiteSmoke; }));
            lb_User1.Text = "Name 1: " + CheckInfo.UserName_E1.ToString();
            lb_User1.ForeColor = Color.Orange;
            lb_User2.Text = "Name 2: " + CheckInfo.UserName_E2.ToString();
            lb_User2.ForeColor = Color.Black;            
            bl_Load = true;
            //string s1 = "", s2 = "";
            #region ADD Info cho các trường ở giao diện AT
            for (int i = 0; i < lst_to_List_Rtb.Count; i++)
            {
                for (int z = 0; z < lst_to_List_Rtb[i].Count; z++)
                {
                    IndexDiffs = new List<int>();
                    lst_to_List_Rtb[i][z].ForeColor = Color.Red;
                    string s1 = "", s2 = "";
                    lst_to_List_Rtb[i][z].Text = CheckInfo.Content_E1_Tam.Split('‡')[i].Split('†')[z].ToString();
                    s1 = new string( CheckInfo.Content_E1_Tam.Split('‡')[i].Split('†')[z].ToString().ToArray().Reverse().ToArray());
                    s2 = new string( CheckInfo.Content_E2_Tam.Split('‡')[i].Split('†')[z].ToString().ToArray().Reverse().ToArray());                    
                    if (s1 != s2)
                    {
                        lst_to_List_Rtb[i][z].BackColor = Color.SandyBrown;
                    }
                    c = null;
                    c = new int[s1.Length + 1, s2.Length + 1];
                    LCS(s1, s2);
                    BackTrack_new(s1, s2, s1.Length, s2.Length, lst_to_List_Rtb[i][z]);
                    FillColorDiff(lst_to_List_Rtb[i][z], IndexDiffs, true);
                }
            }
            bl_Load = false;
            #endregion
            index_User1 = true;
        }

        private void lb_User2_Click(object sender, EventArgs e)
        {
            if (index_User1)
            {
                List<string> lst_str_data_body_AT = new List<string>();
                for (int i = 0; i < lst_to_List_Rtb.Count; i++)
                {
                    lst_str_data_body_AT.Add(String.Join("†", lst_to_List_Rtb[i].Select(x => x.Text.Replace("†", "").Replace("‡", "").ToString())));                   
                }
                string data_full = Function_tinhloi.ToHalfWidth(String.Join("‡", lst_str_data_body_AT));
                CheckInfo.Content_E1_Tam = data_full;
            }
            lb_header.ForEach(x => x.BackColor = Color.WhiteSmoke);
            lst_to_List_Rtb.ForEach(x => x.ForEach(s => { s.Text = ""; s.ForeColor = Color.Red; s.BackColor = Color.WhiteSmoke; }));
            lb_User1.Text = "Name 1: " + CheckInfo.UserName_E1.ToString();
            lb_User1.ForeColor = Color.Black;
            lb_User2.Text = "Name 2: " + CheckInfo.UserName_E2.ToString();
            lb_User2.ForeColor = Color.Orange;
            
            bl_Load = true;
            //string s1 = "", s2 = "";
            #region ADD Info cho các trường ở giao diện AT
            for (int i = 0; i < lst_to_List_Rtb.Count; i++)
            {
                for (int z = 0; z < lst_to_List_Rtb[i].Count; z++)
                {
                    IndexDiffs = new List<int>();
                    lst_to_List_Rtb[i][z].ForeColor = Color.Red;
                    string s1 = "", s2 = "";
                    lst_to_List_Rtb[i][z].Text = CheckInfo.Content_E2_Tam.Split('‡')[i].Split('†')[z].ToString();
                    s1 = new string( CheckInfo.Content_E2_Tam.Split('‡')[i].Split('†')[z].ToString().ToArray().Reverse().ToArray());
                    s2 = new string( CheckInfo.Content_E1_Tam.Split('‡')[i].Split('†')[z].ToString().ToArray().Reverse().ToArray());                    
                    if (s1 != s2)
                    {
                        lst_to_List_Rtb[i][z].BackColor = Color.SandyBrown;
                    }
                    c = null;
                    c = new int[s1.Length + 1, s2.Length + 1];
                    LCS(s1, s2);
                    BackTrack_new(s1, s2, s1.Length, s2.Length, lst_to_List_Rtb[i][z]);
                    FillColorDiff(lst_to_List_Rtb[i][z], IndexDiffs, true);
                }
            }
            bl_Load = false;
            #endregion
            index_User1 = false;
        }

        public string getDataFull()
        {
            List<string> lst_str_data_body_AT = new List<string>();
            for (int i = 0; i < lst_to_List_Rtb.Count; i++)
            {
                lst_str_data_body_AT.Add(String.Join("†", lst_to_List_Rtb[i].Select(x => x.Text.Replace("†", "").Replace("‡", "").ToString())));
            }
            string data_full = Function_tinhloi.ToHalfWidth(String.Join("‡", lst_str_data_body_AT));
            return data_full;
        }
    }
}
