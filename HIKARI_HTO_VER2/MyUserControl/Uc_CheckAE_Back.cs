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
    public partial class Uc_CheckAE_Back : UserControl
    {
        public List<RichTextBox> lst_header = new List<RichTextBox>();
        public List<RichTextBox> lst_body = new List<RichTextBox>();
        List<RichTextBox> lst_all_rtb = new List<RichTextBox>();
        Check_Info_imgBack CheckInfo;
        Ham_Chung Function_tinhloi;
        public Uc_CheckAE_Back()
        {
            InitializeComponent();
            lst_header = new List<RichTextBox>() { rtb_truong2, rtb_truong3, rtb_truong4, rtb_truong5 };
            lst_body = new List<RichTextBox>() { rtb_truong9_1, rtb_truong9_2, rtb_truong9_3, rtb_truong9_4, rtb_truong9_5, rtb_truong9_6, rtb_truong9_7, rtb_truong9_8, rtb_truong9_9, rtb_truong9_10 };
            lst_all_rtb = new List<RichTextBox>() { rtb_truong2, rtb_truong3, rtb_truong4, rtb_truong5, rtb_truong9_1, rtb_truong9_2, rtb_truong9_3, rtb_truong9_4, rtb_truong9_5, rtb_truong9_6, rtb_truong9_7, rtb_truong9_8, rtb_truong9_9, rtb_truong9_10 };
            CheckInfo = new Check_Info_imgBack();
            Function_tinhloi = new Ham_Chung();
        }

        private void Uc_CheckAE_Back_Load(object sender, EventArgs e)
        {
            lst_all_rtb.ForEach(x =>
            {
                x.KeyDown += X_KeyDown;
                x.Enter += X_Enter;
                x.KeyPress += X_KeyPress;
            });
            // Clear Toàn bộ dữ liệu
            lst_all_rtb.ForEach(x => x.Clear());           
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

        private void X_Enter(object sender, EventArgs e)
        {
            RichTextBox rtb = (RichTextBox)(sender);
            rtb.SelectAll();
        }

        private void X_KeyDown(object sender, KeyEventArgs e)
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
                catch { rtb.Focus(); e.Handled = true; }

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
                catch { rtb.Focus(); e.Handled = true; }
            }
            else if (e.KeyCode == Keys.Right)
            {
                try
                {
                    if (rtb.TabIndex <= 4)
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
                        lst_all_rtb[rtb.TabIndex - 2].Focus();
                        e.Handled = true;
                    }
                }
                catch { }
            }
        }

        public void Add_Data_Back(Check_Info_imgBack Data_Check_Back)
        {
            CheckInfo = Data_Check_Back;
            // Clear Toàn bộ dữ liệu
            lst_all_rtb.ForEach(x => { x.Text = ""; x.BackColor = Color.WhiteSmoke; x.ForeColor = Color.Red; });

            for (int i = 0; i < lst_header.Count; i++)
            {
                lst_header[i].Text = CheckInfo.Data_check.Split('‡')[0].Split('†')[i].ToString();
            }
            for (int i = 0; i < CheckInfo.Data_check.Split('‡')[1].Split('†').Length; i++)
            {
                try
                {
                    lst_body[i].Text = CheckInfo.Data_check.Split('‡')[1].Split('†')[i].ToString();
                }
                catch
                {
                    lst_body[i].Text = "";
                }
            }
        }
        public int Submit_Data_Check_Back(int ID_Batch, int ID_Image, int timeUpdate)
        {
            if (String.IsNullOrEmpty(rtb_truong2.Text) == true)
            {
                return 1;
            }
            if (ID_Batch <= 0 || ID_Image <= 0)
            {
                return 0;
            }
            int Error_E1 = 0, Error_E2 = 0;
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


            if (Error_E2 == 0)
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
            if (Global.CheckCharacterError(data_full) == true)
            {
                return 6;
            }
            try
            {
                GlobalDB.DBLinq.Check_Update_Image_Back(ID_Batch, ID_Image, Error_E1, Error_E2, data_full,
                    Global.Level_Image, timeUpdate);
            }
            catch 
            {  return 4; }
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
