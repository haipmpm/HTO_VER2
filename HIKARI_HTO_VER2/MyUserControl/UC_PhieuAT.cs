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
    public partial class UC_PhieuAT : UserControl
    {
        using_Tb_Data tb_Data;
        public List<UC_Detail_AT> lst;
        DataTable tbDetail = new DataTable();
        DataRow dr;
        public List<TextBox> lst_header_AT = new List<TextBox>();
        public List<TextBox> lst_body_AT1 = new List<TextBox>();
        public List<TextBox> lst_body_AT2 = new List<TextBox>();
        public List<TextBox> lst_body_AT3 = new List<TextBox>();
        public List<TextBox> lst_body_AT4 = new List<TextBox>();
        public List<TextBox> lst_body_AT5 = new List<TextBox>();
        public List<TextBox> lst_body_AT6 = new List<TextBox>();
        public List<TextBox> lst_body_AT7 = new List<TextBox>();
        public List<TextBox> lst_body_AT8 = new List<TextBox>();
        public List<TextBox> lst_body_AT9 = new List<TextBox>();
        public List<TextBox> lst_body_AT10 = new List<TextBox>();
        public List<List<TextBox>> lst_to_List_body = new List<List<TextBox>>();
        Ham_Chung ham_chung;
        public UC_PhieuAT()
        {
            InitializeComponent();
            PhieuMoi();
            lst_header_AT = new List<TextBox>() { uC_HeaderAT1.txt_Truong2, uC_HeaderAT1.txt_Truong3, uC_HeaderAT1.txt_Truong4, uC_HeaderAT1.txt_truong5 };
            lst_body_AT1 = new List<TextBox>() { uC_Detail_AT1.txt_Truong7, uC_Detail_AT1.txt_Truong10, uC_Detail_AT1.txt_truong8, uC_Detail_AT1.txt_truong9 };
            lst_body_AT2 = new List<TextBox>() { uC_Detail_AT2.txt_Truong7, uC_Detail_AT2.txt_Truong10, uC_Detail_AT2.txt_truong8, uC_Detail_AT2.txt_truong9 };
            lst_body_AT3 = new List<TextBox>() { uC_Detail_AT3.txt_Truong7, uC_Detail_AT3.txt_Truong10, uC_Detail_AT3.txt_truong8, uC_Detail_AT3.txt_truong9 };
            lst_body_AT4 = new List<TextBox>() { uC_Detail_AT4.txt_Truong7, uC_Detail_AT4.txt_Truong10, uC_Detail_AT4.txt_truong8, uC_Detail_AT4.txt_truong9 };
            lst_body_AT5 = new List<TextBox>() { uC_Detail_AT5.txt_Truong7, uC_Detail_AT5.txt_Truong10, uC_Detail_AT5.txt_truong8, uC_Detail_AT5.txt_truong9 };
            lst_body_AT6 = new List<TextBox>() { uC_Detail_AT6.txt_Truong7, uC_Detail_AT6.txt_Truong10, uC_Detail_AT6.txt_truong8, uC_Detail_AT6.txt_truong9 };
            lst_body_AT7 = new List<TextBox>() { uC_Detail_AT7.txt_Truong7, uC_Detail_AT7.txt_Truong10, uC_Detail_AT7.txt_truong8, uC_Detail_AT7.txt_truong9 };
            lst_body_AT8 = new List<TextBox>() { uC_Detail_AT8.txt_Truong7, uC_Detail_AT8.txt_Truong10, uC_Detail_AT8.txt_truong8, uC_Detail_AT8.txt_truong9 };
            lst_body_AT9 = new List<TextBox>() { uC_Detail_AT9.txt_Truong7, uC_Detail_AT9.txt_Truong10, uC_Detail_AT9.txt_truong8, uC_Detail_AT9.txt_truong9 };
            lst_body_AT10 = new List<TextBox>() { uC_Detail_AT10.txt_Truong7, uC_Detail_AT10.txt_Truong10, uC_Detail_AT10.txt_truong8, uC_Detail_AT10.txt_truong9 };
            lst_to_List_body = new List<List<TextBox>>() { lst_body_AT1, lst_body_AT2, lst_body_AT3, lst_body_AT4, lst_body_AT5, lst_body_AT6, lst_body_AT7, lst_body_AT8, lst_body_AT9, lst_body_AT10 };
            ham_chung = new Ham_Chung();
            tb_Data = new using_Tb_Data();
        }

        public void PhieuMoi()
        {

            uC_Detail_AT1.lb_STT.Text = "01";
            uC_Detail_AT2.lb_STT.Text = "02";
            uC_Detail_AT3.lb_STT.Text = "03";
            uC_Detail_AT4.lb_STT.Text = "04";
            uC_Detail_AT5.lb_STT.Text = "05";
            uC_Detail_AT6.lb_STT.Text = "06";
            uC_Detail_AT7.lb_STT.Text = "07";
            uC_Detail_AT8.lb_STT.Text = "08";
            uC_Detail_AT9.lb_STT.Text = "09";
            uC_Detail_AT10.lb_STT.Text = "10";


            uC_HeaderAT1.previous = uC_Detail_AT10;
            uC_HeaderAT1.next = uC_Detail_AT1;

            uC_Detail_AT1._previous = uC_HeaderAT1;
            uC_Detail_AT1._next = uC_Detail_AT2;

            uC_Detail_AT2._previous = uC_Detail_AT1;
            uC_Detail_AT2._next = uC_Detail_AT3;

            uC_Detail_AT3._previous = uC_Detail_AT2;
            uC_Detail_AT3._next = uC_Detail_AT4;

            uC_Detail_AT4._previous = uC_Detail_AT3;
            uC_Detail_AT4._next = uC_Detail_AT5;

            uC_Detail_AT5._previous = uC_Detail_AT4;
            uC_Detail_AT5._next = uC_Detail_AT6;

            uC_Detail_AT6._previous = uC_Detail_AT5;
            uC_Detail_AT6._next = uC_Detail_AT7;

            uC_Detail_AT7._previous = uC_Detail_AT6;
            uC_Detail_AT7._next = uC_Detail_AT8;

            uC_Detail_AT8._previous = uC_Detail_AT7;
            uC_Detail_AT8._next = uC_Detail_AT9;

            uC_Detail_AT9._previous = uC_Detail_AT8;
            uC_Detail_AT9._next = uC_Detail_AT10;

            uC_Detail_AT10._previous = uC_Detail_AT9;
            uC_Detail_AT10._next = uC_HeaderAT1;
            lst = new List<UC_Detail_AT>();
            lst.Add(uC_Detail_AT1);
            lst.Add(uC_Detail_AT2);
            lst.Add(uC_Detail_AT3);
            lst.Add(uC_Detail_AT4);
            lst.Add(uC_Detail_AT5);
            lst.Add(uC_Detail_AT6);
            lst.Add(uC_Detail_AT7);
            lst.Add(uC_Detail_AT8);
            lst.Add(uC_Detail_AT9);
            lst.Add(uC_Detail_AT10);

            
            uC_Detail_AT1.txt_Truong7.TextChanged += Txt_Truong7_TextChanged;
            uC_Detail_AT2.txt_Truong7.TextChanged += Txt_Truong7_TextChanged;
            uC_Detail_AT3.txt_Truong7.TextChanged += Txt_Truong7_TextChanged;
            uC_Detail_AT4.txt_Truong7.TextChanged += Txt_Truong7_TextChanged;
            uC_Detail_AT5.txt_Truong7.TextChanged += Txt_Truong7_TextChanged;
            uC_Detail_AT6.txt_Truong7.TextChanged += Txt_Truong7_TextChanged;
            uC_Detail_AT7.txt_Truong7.TextChanged += Txt_Truong7_TextChanged;
            uC_Detail_AT8.txt_Truong7.TextChanged += Txt_Truong7_TextChanged;
            uC_Detail_AT9.txt_Truong7.TextChanged += Txt_Truong7_TextChanged;
            uC_Detail_AT10.txt_Truong7.TextChanged += Txt_Truong7_TextChanged;

        }

        public void FocusUC()
        {
            this.BeginInvoke(new Action(() =>
            {
                uC_HeaderAT1.txt_Truong2.Focus();
            }));

        }


        //public bool Update_Data(string idBatch, string idImage, string userNameInput, short phase)
        //{

        //    foreach (var item in lst)
        //    {
        //        if (String.IsNullOrEmpty(item.getAllText()))
        //        {
        //            return false;
        //        }
        //    }

        //    if (String.IsNullOrEmpty(uC_HeaderAT1.txt_Truong2.Text) == true)
        //    {
        //        return false;
        //    }

        //    if (idBatch == "" || idImage == "")
        //        return false;

        //    string ConnectionString = Global.ConnectionString;
        //    SqlConnection con = new SqlConnection(ConnectionString);
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("sp_Data_DataDetail_UpdateDataPrevious", con);
        //    cmd.Parameters.Clear();
        //    cmd.CommandTimeout = 10 * 60;
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.Parameters.AddWithValue("@BatchID", idBatch);
        //    cmd.Parameters.AddWithValue("@IDImage", idImage);
        //    cmd.Parameters.AddWithValue("@NameInput", userNameInput);
        //    cmd.Parameters.AddWithValue("@Phase", phase);
        //    cmd.Parameters.AddWithValue("@Truong2", uC_HeaderAT1.txt_Truong2.Text);
        //    cmd.Parameters.AddWithValue("@Truong3", uC_HeaderAT1.txt_Truong3.Text);
        //    cmd.Parameters.AddWithValue("@Truong4", uC_HeaderAT1.txt_Truong4.Text);
        //    cmd.Parameters.AddWithValue("@Truong5", uC_HeaderAT1.txt_truong5.Text);
        //    cmd.Parameters.AddWithValue("@ListDataDetail", takeDataTableDetail()).SqlDbType = SqlDbType.Structured;

        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //    return true;

        //}
        public void ClearAllText()
        {
            uC_HeaderAT1.clearAllText();
            foreach (var item in lst)
            {
                item.txt_Truong7.Text = "";
                item.txt_truong8.Text = "";
                item.txt_truong9.Text = "";
                item.txt_Truong10.Text = "";
            }
            uC_HeaderAT1.txt_Truong2.Focus();
        }
        private void Txt_Truong7_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                UC_Detail_AT s = (UC_Detail_AT)txt.Parent;

                int index1 = lst.IndexOf(s) + 1;

                if (txt.Text == "SAKUJYO" || txt.Text == "YOHAKU" || txt.Text == "KAKISONJI" || txt.Text == "MISIYO")
                {
                    s.txt_truong8.Text = "";
                    s.txt_truong8.Enabled = false;
                    s.txt_truong9.Text = "";
                    s.txt_truong9.Enabled = false;
                    s.txt_Truong10.Text = "";
                    s.txt_Truong10.Enabled = false;
                }
                else
                {
                    s.txt_truong8.Enabled = true;
                    s.txt_truong9.Enabled = true;
                    s.txt_Truong10.Enabled = true;
                }

                if (txt.Text == "YOHAKU" || txt.Text == "KAKISONJI" || txt.Text == "MISIYO")
                {

                    for (int i = index1; i < lst.Count; i++)
                    {
                        lst[i].txt_Truong7.Text = txt.Text;
                        lst[i].txt_Truong7.Enabled = false;

                        lst[i].txt_truong8.Text = "";
                        lst[i].txt_truong8.Enabled = false;

                        lst[i].txt_truong9.Text = "";
                        lst[i].txt_truong9.Enabled = false;

                        lst[i].txt_Truong10.Text = "";
                        lst[i].txt_Truong10.Enabled = false;
                    }
                }
                else
                {
                    if (s != lst[9])
                    {
                        lst[index1].txt_Truong7.Enabled = true;
                        lst[index1].txt_truong8.Enabled = true;
                        lst[index1].txt_truong9.Enabled = true;
                        lst[index1].txt_Truong10.Enabled = true;
                    }
                }
            }
        }

        public bool ConfirmEmptyWarning()
        {
            if (isEmpty())
                if (MessageBox.Show(Global.MsgWarning, Global.warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    return false;
            return true;
        }
        public bool isEmpty()
        {
            string AllText = GetAllText();
            if (string.IsNullOrEmpty(AllText))
                return true;
            return false;
        }

        public string GetAllText()
        {
            string rs = uC_HeaderAT1.txt_Truong2.Text +
            uC_HeaderAT1.txt_Truong3.Text +
            uC_HeaderAT1.txt_Truong4.Text +
            uC_HeaderAT1.txt_truong5.Text;

            foreach (var item in lst)
            {
                rs += item.txt_Truong7.Text +
                    item.txt_truong8.Text +
                    item.txt_truong9.Text +
                    item.txt_Truong10.Text;
            }

            return rs;
        }
        public string Submit(string ID_Batch, string ID_Image)
        {
            if (String.IsNullOrEmpty(uC_HeaderAT1.txt_Truong2.Text) == true)
            {
                return "1";
            }
            foreach (var item in lst)
            {
                if (String.IsNullOrEmpty(item.getAllText()))
                {
                    return "5";
                }
            }
            if (ID_Batch == "" || ID_Image == "")
            { return "2"; }
            else
            {
                int RowLenght_Nhap = 0;
                string str_data_header_AE = String.Join("†", lst_header_AT.Select(x => x.Text.Replace("†", "").Replace("‡", "").ToString()));
                List<string> lst_str_data_body_AE = new List<string>();
                for (int i = 0; i < lst_to_List_body.Count; i++)
                {
                    if (lst_to_List_body[i][0].ToString() != "")
                    {
                        lst_str_data_body_AE.Add(String.Join("†", lst_to_List_body[i].Select(x => x.Text.Replace("†", "").Replace("‡", "").ToString())));
                    }
                    string DatarowAT = lst_to_List_body[i][0].Text.ToString();
                    if (DatarowAT != "SAKUJYO" && DatarowAT != "YOHAKU" && DatarowAT != "KAKISONJI" && DatarowAT != "MISIYO")
                    {
                        RowLenght_Nhap++;
                    }
                }
                string data_full = ham_chung.ToHalfWidth(str_data_header_AE + "‡" + String.Join("‡", lst_str_data_body_AE));
                var type_Submit = tb_Data.Entry_insertData(ID_Image, ID_Batch, data_full, Global.Level_Pair_Entry_Nhap.ToString(), Global.Level_Image.ToString(), RowLenght_Nhap.ToString(), data_full, Global.strUsername);
                if (type_Submit.Column1.ToString() == "OK")
                {
                    return "3";
                }
                else
                {
                    return "4";
                }
            }
        }
        public string getDataFull()
        {
            string str_data_header_AE = String.Join("†", lst_header_AT.Select(x => x.Text.Replace("†", "").Replace("‡", "").ToString()));
            List<string> lst_str_data_body_AE = new List<string>();
            for (int i = 0; i < lst_to_List_body.Count; i++)
            {
                if (lst_to_List_body[i].ToList()[1].ToString() != "")
                {
                    lst_str_data_body_AE.Add(String.Join("†", lst_to_List_body[i].Select(x => x.Text.Replace("†", "").Replace("‡", "").ToString())));
                }
            }
            string data_full = ham_chung.ToHalfWidth(str_data_header_AE + "‡" + String.Join("‡", lst_str_data_body_AE));
            return data_full;
        }

        private void UC_PhieuAT_Load(object sender, EventArgs e)
        {

        }
        //public DataTable takeDataTableDetail()
        //{
        //    tbDetail = new DataTable();
        //    tbDetail.Columns.Add("STT");
        //    tbDetail.Columns.Add("Truong7");
        //    tbDetail.Columns.Add("Truong8");
        //    tbDetail.Columns.Add("Truong9");
        //    tbDetail.Columns.Add("Truong10");
        //    foreach (var item in lst)
        //    {

        //        dr = tbDetail.NewRow();
        //        dr["STT"] = item.lb_STT.Text;
        //        dr["Truong7"] = item.txt_Truong7.Text;
        //        dr["Truong8"] = item.txt_truong8.Text;
        //        dr["Truong9"] = item.txt_truong9.Text;
        //        dr["Truong10"] = item.txt_Truong10.Text;
        //        tbDetail.Rows.Add(dr);
        //    }
        //    return tbDetail;

        //}
        //public bool Save_DataChecker(string idbatch, string iDImage, string strUsername, string userNaemInputU1, string userNaemInputU2)
        //{
        //    foreach (var item in lst)
        //    {
        //        if (String.IsNullOrEmpty(item.getAllText()))
        //        {
        //            return false;
        //        }
        //    }

        //    if (String.IsNullOrEmpty(uC_HeaderAT1.txt_Truong2.Text) == true)
        //    {
        //        return false;
        //    }

        //    if (idbatch == "" || iDImage == "")
        //        return false;

        //    string ConnectionString = Global.ConnectionString;
        //    SqlConnection con = new SqlConnection(ConnectionString);
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("spData_Save_DataChecker", con);
        //    cmd.CommandTimeout = 10 * 60;
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@BatchID", idbatch);
        //    cmd.Parameters.AddWithValue("@IDImage", iDImage);
        //    cmd.Parameters.AddWithValue("@UserNameChecker", strUsername);
        //    cmd.Parameters.AddWithValue("@UserNameInput1", userNaemInputU1);
        //    cmd.Parameters.AddWithValue("@UserNameInput2", userNaemInputU2);
        //    cmd.Parameters.AddWithValue("@Truong_02", uC_HeaderAT1.txt_Truong2.Text);
        //    cmd.Parameters.AddWithValue("@Truong_03", uC_HeaderAT1.txt_Truong3.Text);
        //    cmd.Parameters.AddWithValue("@Truong_04", uC_HeaderAT1.txt_Truong4.Text);
        //    cmd.Parameters.AddWithValue("@Truong_05", uC_HeaderAT1.txt_truong5.Text);
        //    cmd.Parameters.AddWithValue("@Type", "AT");
        //    cmd.Parameters.AddWithValue("@List_detail", takeDataTableDetail()).SqlDbType = SqlDbType.Structured;
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //    return true;
        //}
    }
}
