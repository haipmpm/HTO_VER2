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
    public partial class UC_CHECKER_AE : UserControl
    {
        public List<RichTextBox> lst_header = new List<RichTextBox>();
        public List<RichTextBox> lst_body = new List<RichTextBox>();
        List<RichTextBox> lst_all_rtb = new List<RichTextBox>();
        List<Label> lb_all = new List<Label>();
        Check_Info CheckInfo;
        Ham_Chung Function_tinhloi;
        List<int> IndexDiffs;

        public UC_CHECKER_AE()
        {
            InitializeComponent();
            lst_header = new List<RichTextBox>() { rtb_truong2, rtb_truong3, rtb_truong4, rtb_truong5 };
            lst_body = new List<RichTextBox>() {rtb_truong9_1,rtb_truong9_2,rtb_truong9_3,rtb_truong9_4,rtb_truong9_5,rtb_truong9_6,rtb_truong9_7,rtb_truong9_8,rtb_truong9_9,rtb_truong9_10 };
            lst_all_rtb = new List<RichTextBox>() { rtb_truong2, rtb_truong3, rtb_truong4, rtb_truong5, rtb_truong9_1, rtb_truong9_2, rtb_truong9_3, rtb_truong9_4, rtb_truong9_5, rtb_truong9_6, rtb_truong9_7, rtb_truong9_8, rtb_truong9_9, rtb_truong9_10 };
            lb_all = new List<Label>() { lb_t2, lb_t3, lb_t4, lb_t5,lb_t9_1, lb_t9_2, lb_t9_3, lb_t9_4, lb_t9_5, lb_t9_6, lb_t9_7, lb_t9_8, lb_t9_9, lb_t9_10 };
            CheckInfo = new Check_Info();
            Function_tinhloi = new Ham_Chung();
            IndexDiffs = new List<int>();
        }
        private void UC_CHECKER_AE_Load(object sender, EventArgs e)
        {
            lst_all_rtb.ForEach(x =>
            {
                x.KeyDown += new KeyEventHandler(this.rtb_truong2_KeyDown);
                x.MouseDown += new MouseEventHandler(this.rtb_truong2_MouseDown);
                x.Enter += new EventHandler(this.rtb_Enter);
                x.KeyPress += X_KeyPress;
            });
            // Clear Toàn bộ dữ liệu
            lst_all_rtb.ForEach(x => x.Clear());
            lb_all.ForEach(x => x.BackColor = Color.WhiteSmoke);            
        }

        private void X_KeyPress(object sender, KeyPressEventArgs e)
        {
            RichTextBox rtb = (RichTextBox)sender;
            if (rtb.TabIndex > 4)
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

        public void Add_Data_AE( Check_Info  InfoCheck)
        {
            // Clear Toàn bộ dữ liệu
            lst_all_rtb.ForEach(x => { x.Text = "" ;x.BackColor = Color.WhiteSmoke;x.ForeColor = Color.Red; }) ;
            
            lb_all.ForEach(x => x.BackColor = Color.WhiteSmoke);
            CheckInfo = InfoCheck;
            lb_User1.Text = "Name 1: " + CheckInfo.UserName_E1.ToString();
            lb_User1.ForeColor = Color.Orange;
            lb_User2.Text = "Name 2: " + CheckInfo.UserName_E2.ToString();
            lb_User2.ForeColor = Color.Black;            
            #region ADD Info cho các trường ở phần Header
            for (int i = 0; i < lst_all_rtb.Count(); i++)
            {
                IndexDiffs = new List<int>();
                string s1 = "", s2 = "";
                if (i < 4)
                {
                    lst_all_rtb[i].Text = CheckInfo.Content_E1.Split('‡')[0].Split('†')[i];
                    s1 = new string(CheckInfo.Content_E1.Split('‡')[0].Split('†')[i].ToString().ToArray().Reverse().ToArray());
                    s2 = new string(CheckInfo.Content_E2.Split('‡')[0].Split('†')[i].ToString().ToArray().Reverse().ToArray());
                }
                else
                {
                    try { lst_all_rtb[i].Text = CheckInfo.Content_E1.Split('‡')[1].Split('†')[i - 4]; } catch { lst_all_rtb[i].Text = ""; }
                    try { s1 = new string(CheckInfo.Content_E1.Split('‡')[1].Split('†')[i - 4].ToString().ToArray().Reverse().ToArray()); } catch { s1 = ""; }
                    try { s2 = new string(CheckInfo.Content_E2.Split('‡')[1].Split('†')[i - 4].ToString().ToArray().Reverse().ToArray()); } catch { s2 = ""; }  
                }
                if (s1 != s2)
                {
                    lst_all_rtb[i].BackColor = Color.SandyBrown;
                }                    
                c = null;
                c = new int[s1.Length + 1, s2.Length + 1];
                LCS(s1, s2);
                BackTrack_new(s1, s2, s1.Length, s2.Length, lst_all_rtb[i]);
                FillColorDiff(lst_all_rtb[i], IndexDiffs, true);
            }
            #endregion            
        }
        public void FocusUC()
        {
            this.BeginInvoke(new Action(() =>
            {
                rtb_truong2.Focus();
            }));
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
        //Nghịch       
        //private string BackTrack2(string s1, string s2, int i, int j)
        //{
        //    if (i == 0 || j == 0)
        //        return "";
        //    if (s1[i - 1] == s2[j - 1])
        //    {
        //        return BackTrack2(s1, s2, i - 1, j - 1) + s1[i - 1];
        //    }
        //    else if (c[i - 1, j] > c[i, j - 1])
        //        return BackTrack2(s1, s2, i - 1, j);

        //    else
        //        return BackTrack2(s1, s2, i, j - 1);

        //}
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

        private void rtb_truong2_KeyDown(object sender, KeyEventArgs e)
        {
            RichTextBox rtb = (RichTextBox)(sender);
            if (e.KeyCode == Keys.Tab)
            {
                rtb.SelectAll();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                try
                {
                    if (rtb.TabIndex > 4)
                    {
                        lst_all_rtb[rtb.TabIndex - 2].Focus();
                        e.Handled = true;
                    }
                    else
                    {
                        lst_all_rtb[rtb.TabIndex - 2].Focus();
                        e.Handled = true;
                    }
                }
                catch { rtb.Focus();e.Handled = true; }
                
            }
            else if (e.KeyCode == Keys.Down)
            {
                try
                {
                    if (rtb.TabIndex <= 4)
                    {
                        lst_all_rtb[4].Focus();
                        e.Handled = true;
                    }
                    else
                    {
                        lst_all_rtb[rtb.TabIndex].Focus();
                        e.Handled = true;
                    }
                }
                catch { rtb.Focus();e.Handled = true; }
            }
            else if (e.KeyCode == Keys.Right)
            {
                try
                {
                    if (rtb.TabIndex <=4)
                    {
                        lst_all_rtb[rtb.TabIndex].Focus();
                        e.Handled = true;
                    }
                }
                catch { }
            }
            else if (e.KeyCode == Keys.Left)
            {
                try
                {
                    if (rtb.TabIndex <= 4)
                    {
                        lst_all_rtb[rtb.TabIndex -2].Focus();
                        e.Handled = true;
                    }
                }
                catch { }
            }

        }
        private void rtb_Enter(object sender, EventArgs e)
        {
            RichTextBox rtb = (RichTextBox)(sender);
            rtb.SelectAll();
        }
        private void rtb_truong2_Click(object sender, KeyEventArgs e)
        {
            RichTextBox rtb = (RichTextBox)(sender);            
        }

        private void rtb_truong2_MouseDown(object sender, MouseEventArgs e)
        {
            RichTextBox rtb = (RichTextBox)sender;
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    if (rtb.TabIndex < 5)
                    {
                        if (rtb.Text == CheckInfo.Content_E1.Split('‡')[0].Split('†')[rtb.TabIndex - 1].ToString())
                        {
                            IndexDiffs = new List<int>();
                            rtb.SelectionStart = 0;
                            rtb.SelectionLength = rtb.Text.Length;
                            rtb.SelectionColor = Color.Red;
                            rtb.Text = CheckInfo.Content_E2.Split('‡')[0].Split('†')[rtb.TabIndex - 1].ToString();
                            string s1, s2;
                            s1 = new string(CheckInfo.Content_E2.Split('‡')[0].Split('†')[rtb.TabIndex - 1].ToString().ToArray().Reverse().ToArray());
                            s2 = new string(CheckInfo.Content_E1.Split('‡')[0].Split('†')[rtb.TabIndex - 1].ToString().ToArray().Reverse().ToArray());
                            c = null;
                            c = new int[s1.Length + 1, s2.Length + 1];
                            LCS(s1, s2);
                            BackTrack_new(s1, s2, s1.Length, s2.Length, rtb);
                            FillColorDiff(rtb, IndexDiffs, true);
                            lb_User2.ForeColor = Color.Orange;
                            lb_User1.ForeColor = Color.Black;
                        }
                        else if (rtb.Text == CheckInfo.Content_E2.Split('‡')[0].Split('†')[rtb.TabIndex - 1].ToString())
                        {
                            IndexDiffs = new List<int>();
                            rtb.SelectionStart = 0;
                            rtb.SelectionLength = rtb.Text.Length;
                            rtb.SelectionColor = Color.Red;
                            rtb.Text = CheckInfo.Content_E1.Split('‡')[0].Split('†')[rtb.TabIndex - 1].ToString();
                            string s1, s2;
                            s1 = new string( CheckInfo.Content_E1.Split('‡')[0].Split('†')[rtb.TabIndex - 1].ToString().ToArray().Reverse().ToArray());
                            s2 = new string( CheckInfo.Content_E2.Split('‡')[0].Split('†')[rtb.TabIndex - 1].ToString().ToArray().Reverse().ToArray());
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
                            rtb.Text = CheckInfo.Content_E1.Split('‡')[0].Split('†')[rtb.TabIndex - 1].ToString();
                            string s1, s2;
                            s1 = new string( CheckInfo.Content_E1.Split('‡')[0].Split('†')[rtb.TabIndex - 1].ToString().ToArray().Reverse().ToArray());
                            s2 = new string( CheckInfo.Content_E2.Split('‡')[0].Split('†')[rtb.TabIndex - 1].ToString().ToArray().Reverse().ToArray());
                            c = null;
                            c = new int[s1.Length + 1, s2.Length + 1];
                            LCS(s1, s2);
                            BackTrack_new(s1, s2, s1.Length, s2.Length, rtb);
                            FillColorDiff(rtb, IndexDiffs, true);
                            lb_User1.ForeColor = Color.Orange;
                            lb_User2.ForeColor = Color.Black;
                        }
                    }
                    else
                    {
                        if (rtb.Text == CheckInfo.Content_E1.Split('‡')[1].Split('†')[rtb.TabIndex - 5].ToString())
                        {
                            IndexDiffs = new List<int>();
                            rtb.SelectionStart = 0;
                            rtb.SelectionLength = rtb.Text.Length;
                            rtb.SelectionColor = Color.Red;
                            rtb.Text = CheckInfo.Content_E2.Split('‡')[1].Split('†')[rtb.TabIndex - 5].ToString();
                            string s1, s2;
                            s1 = new string( CheckInfo.Content_E2.Split('‡')[1].Split('†')[rtb.TabIndex - 5].ToString().ToArray().Reverse().ToArray());
                            s2 = new string( CheckInfo.Content_E1.Split('‡')[1].Split('†')[rtb.TabIndex - 5].ToString().ToArray().Reverse().ToArray());
                            c = null;
                            c = new int[s1.Length + 1, s2.Length + 1];
                            LCS(s1, s2);
                            BackTrack_new(s1, s2, s1.Length, s2.Length, rtb);
                            FillColorDiff(rtb, IndexDiffs, true);
                            lb_User2.ForeColor = Color.Orange;
                            lb_User1.ForeColor = Color.Black;
                        }
                        else if (rtb.Text == CheckInfo.Content_E2.Split('‡')[1].Split('†')[rtb.TabIndex - 5].ToString())
                        {
                            IndexDiffs = new List<int>();
                            rtb.SelectionStart = 0;
                            rtb.SelectionLength = rtb.Text.Length;
                            rtb.SelectionColor = Color.Red;
                            rtb.Text = CheckInfo.Content_E1.Split('‡')[1].Split('†')[rtb.TabIndex - 5].ToString();
                            string s1, s2;
                            s1 = new string( CheckInfo.Content_E1.Split('‡')[1].Split('†')[rtb.TabIndex - 5].ToString().ToArray().Reverse().ToArray());
                            s2 = new string( CheckInfo.Content_E2.Split('‡')[1].Split('†')[rtb.TabIndex - 5].ToString().ToArray().Reverse().ToArray());
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
                            rtb.Text = CheckInfo.Content_E1.Split('‡')[1].Split('†')[rtb.TabIndex - 5].ToString();
                            string s1, s2;
                            s1 = new string(CheckInfo.Content_E1.Split('‡')[1].Split('†')[rtb.TabIndex - 5].ToString().ToArray().Reverse().ToArray());
                            s2 = new string(CheckInfo.Content_E2.Split('‡')[1].Split('†')[rtb.TabIndex - 5].ToString().ToArray().Reverse().ToArray());
                            c = null;
                            c = new int[s1.Length + 1, s2.Length + 1];
                            LCS(s1, s2);
                            BackTrack_new(s1, s2, s1.Length, s2.Length, rtb);
                            FillColorDiff(rtb, IndexDiffs, true);
                            lb_User1.ForeColor = Color.Orange;
                            lb_User2.ForeColor = Color.Black;
                        }
                    }
                }
                catch { }
            }
        }
        public bool ConfirmEmptyWarning()
        {
            if (String.Join("",lst_all_rtb.Select(x => x.Text.Replace("†", "").Replace("‡", "").ToString())) == "")
                if (MessageBox.Show(Global.MsgWarning, Global.warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    return false;
            return true;
        }
        public int Submit_Data_Check(int ID_Batch, int ID_Image)
        {
            if (String.IsNullOrEmpty(rtb_truong2.Text) == true)
            {
                return 1;
            }
            if (ID_Batch <=0 || ID_Image <= 0 )
            {
                return 0;
            }
            int Error_E1 = 0,Error_E2 = 0;
            // Tính lỗi phần Header của E1 và E2
            string str_data_header_AE = String.Join("†", lst_header.Select(x => x.Text.Replace("†", "").Replace("‡", "").ToString()));
            if (Function_tinhloi.return_error(CheckInfo.Content_E1.Split('‡')[0].ToString(), str_data_header_AE) > 0)
            {
                Error_E1++;
            }
            if (Function_tinhloi.return_error(CheckInfo.Content_E2.Split('‡')[0].ToString(), str_data_header_AE) > 0)
            {
                Error_E2++;
            }
            // Tính lỗi phần Body của AE
            //string str_data_body_AE = String.Join("†", lst_body.Select(x => x.Text.Replace("†", "").Replace("‡", "").ToString()));
            if (Error_E1 == 0)
            {
                for (int i = 0; i < lst_body.Count; i++)
                {
                    if (Function_tinhloi.return_error(CheckInfo.Content_E1.Split('‡')[1].Split('†')[i].ToString(), lst_body[i].Text.ToString()) > 0)
                    {
                        Error_E1++;
                    }
                }

                int row_E1_Create = 0;
                for (int i = 0; i < lst_body.Count; i++)
                {
                    if (CheckInfo.Content_E1.Split('‡')[1].Split('†')[i].ToString() != "")
                    {
                        row_E1_Create = i + 1;
                    }
                }

                if (Error_E1 > row_E1_Create)
                {
                    Error_E1 = row_E1_Create;
                }
            }
            else
            {
                for (int i = 0; i < lst_body.Count; i++)
                {
                    if (CheckInfo.Content_E1.Split('‡')[1].Split('†')[i].ToString() != "")
                    {
                        Error_E1 = i + 1;
                    }
                }
            }
            // TH NLV nhập thiếu dòng nhưng xử lý lỗi tối đa là số dòng Entry nhập


            if (Error_E2  == 0)
            {
                for (int i = 0; i < lst_body.Count; i++)
                {                    
                    if (Function_tinhloi.return_error(CheckInfo.Content_E2.Split('‡')[1].Split('†')[i].ToString(), lst_body[i].Text.ToString()) > 0)
                    {
                        Error_E2++;
                    }
                }

                int row_E2_Create = 0;
                for (int i = 0; i < lst_body.Count; i++)
                {
                    if (CheckInfo.Content_E2.Split('‡')[1].Split('†')[i].ToString() != "")
                    {
                        row_E2_Create = i + 1;
                    }
                }

                if (Error_E2 > row_E2_Create)
                {
                    Error_E2 = row_E2_Create;
                }
            }
            else
            {
                for (int i = 0; i < lst_body.Count; i++)
                {
                    if (CheckInfo.Content_E2.Split('‡')[1].Split('†')[i].ToString() != "")
                    {
                        Error_E2 = i + 1;
                    }
                }
            }
            
            string str_data_body_AE_last = String.Join("†", lst_body.Where(x => x.Text != "").Select(x => x.Text.Replace("†", "").Replace("‡", "").ToString()));
            string data_full = str_data_header_AE + "‡" + str_data_body_AE_last;
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

        private void rtb_truong2_Enter(object sender, EventArgs e)
        {

        }

        private void lb_User1_Click(object sender, EventArgs e)
        {
            // Clear Toàn bộ dữ liệu
            lst_all_rtb.ForEach(x => { x.Text = ""; x.BackColor = Color.WhiteSmoke; x.ForeColor = Color.Red; });
            lb_all.ForEach(x => x.BackColor = Color.WhiteSmoke);            
            lb_User1.Text = "Name 1: " + CheckInfo.UserName_E1.ToString();
            lb_User1.ForeColor = Color.Orange;
            lb_User2.Text = "Name 2: " + CheckInfo.UserName_E2.ToString();
            lb_User2.ForeColor = Color.Black;
            #region ADD Info cho các trường ở phần Header
            for (int i = 0; i < lst_all_rtb.Count(); i++)
            {
                IndexDiffs = new List<int>();
                string s1 = "", s2 = "";
                if (i < 4)
                {
                    lst_all_rtb[i].Text = CheckInfo.Content_E1.Split('‡')[0].Split('†')[i];
                    s1 = new string( CheckInfo.Content_E1.Split('‡')[0].Split('†')[i].ToString().ToArray().Reverse().ToArray());
                    s2 = new string( CheckInfo.Content_E2.Split('‡')[0].Split('†')[i].ToString().ToArray().Reverse().ToArray());
                }
                else
                {
                    try { lst_all_rtb[i].Text = CheckInfo.Content_E1.Split('‡')[1].Split('†')[i - 4]; } catch { lst_all_rtb[i].Text = ""; }
                    try { s1 = new string(CheckInfo.Content_E1.Split('‡')[1].Split('†')[i - 4].ToString().ToArray().Reverse().ToArray()); } catch { s1 = ""; }
                    try { s2 = new string(CheckInfo.Content_E2.Split('‡')[1].Split('†')[i - 4].ToString().ToArray().Reverse().ToArray()); } catch { s2 = ""; }
                }
                if (s1 != s2)
                {
                    lst_all_rtb[i].BackColor = Color.SandyBrown;
                }
                    
                c = null;
                c = new int[s1.Length + 1, s2.Length + 1];
                LCS(s1, s2);
                BackTrack_new(s1, s2, s1.Length, s2.Length, lst_all_rtb[i]);
                FillColorDiff(lst_all_rtb[i], IndexDiffs, true);
            }
            #endregion            
        }

        private void lb_User2_Click(object sender, EventArgs e)
        {
            // Clear Toàn bộ dữ liệu
            lst_all_rtb.ForEach(x => { x.Text = ""; x.BackColor = Color.WhiteSmoke; x.ForeColor = Color.Red; });
            lb_all.ForEach(x => x.BackColor = Color.WhiteSmoke);            
            lb_User1.Text = "Name 1: " + CheckInfo.UserName_E1.ToString();
            lb_User1.ForeColor = Color.Black;
            lb_User2.Text = "Name 2: " + CheckInfo.UserName_E2.ToString();
            lb_User2.ForeColor = Color.Orange;            
            #region ADD Info cho các trường ở phần Header
            for (int i = 0; i < lst_all_rtb.Count(); i++)
            {
                IndexDiffs = new List<int>();
                string s1 = "", s2 = "";
                if (i < 4)
                {
                    lst_all_rtb[i].Text = CheckInfo.Content_E2.Split('‡')[0].Split('†')[i];
                    s1 = new string( CheckInfo.Content_E2.Split('‡')[0].Split('†')[i].ToString().ToArray().Reverse().ToArray());
                    s2 = new string( CheckInfo.Content_E1.Split('‡')[0].Split('†')[i].ToString().ToArray().Reverse().ToArray());
                }
                else
                {
                    try { lst_all_rtb[i].Text = CheckInfo.Content_E2.Split('‡')[1].Split('†')[i - 4]; } catch { lst_all_rtb[i].Text = ""; }
                    try { s1 = new string(CheckInfo.Content_E2.Split('‡')[1].Split('†')[i - 4].ToString().ToArray().Reverse().ToArray()); } catch { s1 = ""; }
                    try { s2 = new string(CheckInfo.Content_E1.Split('‡')[1].Split('†')[i - 4].ToString().ToArray().Reverse().ToArray()); } catch { s2 = ""; }
                }
                if (s1 != s2)
                {
                    lst_all_rtb[i].BackColor = Color.SandyBrown;
                }
                c = null;
                c = new int[s1.Length + 1, s2.Length + 1];
                LCS(s1, s2);
                BackTrack_new(s1, s2, s1.Length, s2.Length, lst_all_rtb[i]);
                FillColorDiff(lst_all_rtb[i], IndexDiffs, true);
            }
            #endregion            
        }

        public string getDataFull()
        {
            string str_data_header_AE = String.Join("†", lst_header.Select(x => x.Text.Replace("†", "").Replace("‡", "").ToString()));
            string str_data_body_AE_last = String.Join("†", lst_body.Select(x => x.Text.Replace("†", "").Replace("‡", "").ToString()));
            string data_full = str_data_header_AE + "‡" + str_data_body_AE_last;
            return data_full;
        }
    }
}
