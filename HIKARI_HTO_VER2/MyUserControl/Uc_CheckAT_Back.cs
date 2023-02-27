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
    public partial class Uc_CheckAT_Back : UserControl
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
        Check_Info_imgBack Check_back;
        Ham_Chung Function_tinhloi;
        bool isSuggestOpened ;
        bool bl_Load = false;
        public Uc_CheckAT_Back()
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
            Check_back = new Check_Info_imgBack();
            Function_tinhloi = new Ham_Chung();
        }
        public void Add_Data_Back(Check_Info_imgBack Data_Check_Back)
        {
            bl_Load = true;
            Check_back = Data_Check_Back;
            lst_to_List_Rtb.ForEach(x => x.ForEach(s => { s.Text = "";s.ForeColor = Color.Black; })) ;
            for (int i = 0; i < lst_to_List_Rtb.Count; i++)
            {
                for (int t = 0; t < lst_to_List_Rtb[i].Count; t++)
                {
                    lst_to_List_Rtb[i][t].Text = Check_back.Data_check.Split('‡')[i].Split('†')[t].ToString();
                }
            }
            bl_Load = false;
        }
        private void Uc_CheckAT_Back_Load(object sender, EventArgs e)
        {
            autocompleteMenu1.Items = Global.ListAutoComP.Items;
            autocompleteMenu1.AllowsTabKey = true;
            autocompleteMenu1.Opening += AutocompleteMenu1_Opening;
            autocompleteMenu1.Selected += AutocompleteMenu1_Selected;
            lst_to_List_Rtb.ForEach(x =>
            {
                x.ForEach(s =>
                {
                    s.KeyPress += S_KeyPress;
                    s.TextChanged += S_TextChanged;
                    s.KeyDown += S_KeyDown;
                    s.Enter += S_Enter;
                    s.Leave += S_Leave;
                });
            });
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

        private void S_Enter(object sender, EventArgs e)
        {
            RichTextBox rtb = (RichTextBox)(sender);
            rtb.SelectAll();
            isSuggestOpened = false;
            if (rtb.Name.Contains("rtb_truong7_"))
            {
                autocompleteMenu1.Enabled = true;
            }
        }

        private void S_KeyDown(object sender, KeyEventArgs e)
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

        private void S_TextChanged(object sender, EventArgs e)
        {
            RichTextBox rtb = (RichTextBox)(sender);
            if (rtb.Name.ToString().Contains("rtb_truong7_"))
            {
                int index_rtb_7_inList = Convert.ToInt32(rtb.Name.ToString().Substring(rtb.Name.ToString().Length - 1, 1));
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

        private void S_KeyPress(object sender, KeyPressEventArgs e)
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

        public int Submit_Check_Back(int ID_Batch, int ID_Image, int timeUpdate)
        {
            isSuggestOpened = false;
            if (String.IsNullOrEmpty(rtb_truong2.Text) == true)
            {
                return 1;
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
            string data_full = Function_tinhloi.ToHalfWidth(String.Join("‡", lst_str_data_body_AT)); /*str_data_header_AE + "‡" +*/
            int Error_E1 = 0, Error_E2 = 0;
            for (int i = 0; i < lst_to_List_Rtb.Count; i++)
            {
                if (Function_tinhloi.return_error(Check_back.Content_E1.Split('‡')[i].ToString().Replace("‡", "").Replace("†", "").ToString(), String.Join("", lst_to_List_Rtb[i].Select(x => x.Text.Replace("†", "").Replace("‡", "").ToString()))) > 0)
                {
                    Error_E1++;
                }
                if (Function_tinhloi.return_error(Check_back.Content_E2.Split('‡')[i].ToString().Replace("‡", "").Replace("†", "").ToString(), String.Join("", lst_to_List_Rtb[i].Select(x => x.Text.Replace("†", "").Replace("‡", "").ToString()))) > 0)
                {
                    Error_E2++;
                }
            }
            try
            {
                GlobalDB.DBLinq.Check_Update_Image_Back(ID_Batch, ID_Image, Error_E1, Error_E2, data_full,
                    Global.Level_Image, timeUpdate);
            }
            catch
            { return 4; }
            #region 
            //try
            //{
            //    string ConnectionString = Global.ConnectionString;
            //    SqlConnection con = new SqlConnection(ConnectionString);
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand("Check_Update_Image_Back", con);
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
            //    cmd.Parameters.AddWithValue("@TimeCheckUp", timeUpdate.ToString());
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //}
            //catch
            //{
            //    return 4;
            //}
            #endregion
            return 3;
        }
    }
}
