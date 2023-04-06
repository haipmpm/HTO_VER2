using HIKARI_HTO_VER2.LinqToSQLProcess;
using HIKARI_HTO_VER2.ModuleProcessUtil;
using HIKARI_HTO_VER2.MyForm;
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
    public partial class UC_PhieuAE : UserControl
    {       
        DataTable tbDetail;
        using_Tb_Data tb_Data;
        Ham_Chung ham_chung;
        DataRow dr;
        
        public List<UC_Detail_AE> lst;
        public List<int> indexLST;
        public List<TextBox> lst_texbox_Entry_AE_header = new List<TextBox>();
        public List<TextBox> lst_texbox_Entry_AE_Body = new List<TextBox>();
        public UC_PhieuAE()
        {
            InitializeComponent();
            phieuMoi();
            lst_texbox_Entry_AE_header = new List<TextBox>() { uC_HeaderAE1.txt_Truong2, uC_HeaderAE1.txt_Truong3, uC_HeaderAE1.txt_Truong4, uC_HeaderAE1.txt_Truong5 };
            lst_texbox_Entry_AE_Body = new List<TextBox>() { uC_Detail_AE1.txt_Truong9, uC_Detail_AE2.txt_Truong9, uC_Detail_AE3.txt_Truong9, uC_Detail_AE4.txt_Truong9, uC_Detail_AE5.txt_Truong9, uC_Detail_AE6.txt_Truong9, uC_Detail_AE7.txt_Truong9, uC_Detail_AE8.txt_Truong9, uC_Detail_AE9.txt_Truong9, uC_Detail_AE10.txt_Truong9 };
            ham_chung = new Ham_Chung();
            tb_Data = new using_Tb_Data();            
        }
       
        public void phieuMoi()
        {
            uC_Detail_AE1.lb_STT.Text = "01";
            uC_Detail_AE2.lb_STT.Text = "02";
            uC_Detail_AE3.lb_STT.Text = "03";
            uC_Detail_AE4.lb_STT.Text = "04";
            uC_Detail_AE5.lb_STT.Text = "05";
            uC_Detail_AE6.lb_STT.Text = "06";
            uC_Detail_AE7.lb_STT.Text = "07";
            uC_Detail_AE8.lb_STT.Text = "08";
            uC_Detail_AE9.lb_STT.Text = "09";
            uC_Detail_AE10.lb_STT.Text = "10";

            uC_HeaderAE1._nextObject = uC_Detail_AE1;
            uC_HeaderAE1._previous = uC_Detail_AE10;

            uC_Detail_AE1.previous = uC_HeaderAE1;
            uC_Detail_AE1.next = uC_Detail_AE2;

            uC_Detail_AE2.previous = uC_Detail_AE1;
            uC_Detail_AE2.next = uC_Detail_AE3;

            uC_Detail_AE3.previous = uC_Detail_AE2;
            uC_Detail_AE3.next = uC_Detail_AE4;

            uC_Detail_AE4.previous = uC_Detail_AE3;
            uC_Detail_AE4.next = uC_Detail_AE5;

            uC_Detail_AE5.previous = uC_Detail_AE4;
            uC_Detail_AE5.next = uC_Detail_AE6;

            uC_Detail_AE6.previous = uC_Detail_AE5;
            uC_Detail_AE6.next = uC_Detail_AE7;

            uC_Detail_AE7.previous = uC_Detail_AE6;
            uC_Detail_AE7.next = uC_Detail_AE8;

            uC_Detail_AE8.previous = uC_Detail_AE7;
            uC_Detail_AE8.next = uC_Detail_AE9;

            uC_Detail_AE9.previous = uC_Detail_AE8;
            uC_Detail_AE9.next = uC_Detail_AE10;
            uC_Detail_AE10.previous = uC_Detail_AE9;
            uC_Detail_AE10.next = uC_HeaderAE1;
            uC_HeaderAE1.Focus();
            lst = new List<UC_Detail_AE>();
            lst.Add(uC_Detail_AE1);
            lst.Add(uC_Detail_AE2);
            lst.Add(uC_Detail_AE3);
            lst.Add(uC_Detail_AE4);
            lst.Add(uC_Detail_AE5);
            lst.Add(uC_Detail_AE6);
            lst.Add(uC_Detail_AE7);
            lst.Add(uC_Detail_AE8);
            lst.Add(uC_Detail_AE9);
            lst.Add(uC_Detail_AE10);            
        }

        //public bool Update_Data(string idBatch, string idImage, string userNameInput, short phase)
        //{

        //    if (String.IsNullOrEmpty(uC_HeaderAE1.txt_Truong2.Text) == true)
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
        //    cmd.Parameters.AddWithValue("@Truong2", uC_HeaderAE1.txt_Truong2.Text);
        //    cmd.Parameters.AddWithValue("@Truong3", uC_HeaderAE1.txt_Truong3.Text);
        //    cmd.Parameters.AddWithValue("@Truong4", uC_HeaderAE1.txt_Truong4.Text);
        //    cmd.Parameters.AddWithValue("@Truong5", uC_HeaderAE1.txt_Truong5.Text);
        //    cmd.Parameters.AddWithValue("@ListDataDetail", takeDataTableDetail()).SqlDbType = SqlDbType.Structured;

        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //    return true;

        //}
        public void ClearAllText()
        {
            uC_HeaderAE1.ClearAllText();
            foreach (var item in lst)
            {
                item.txt_Truong9.Text = "";
                item.txt_Truong9.BackColor = System.Drawing.Color.White;
                item.txt_Truong9.ForeColor = System.Drawing.Color.Black;
            }
        }

        public bool isEmpty()
        {
            string AllText = GetAllText();
            if (string.IsNullOrEmpty(AllText) /*|| AllText == "2021"*/)
                return true;
            return false;
        }
        public string GetAllText()
        {
            return uC_Detail_AE1.txt_Truong9.Text +
                uC_Detail_AE2.txt_Truong9.Text +
                uC_Detail_AE3.txt_Truong9.Text +
                uC_Detail_AE4.txt_Truong9.Text +
                uC_Detail_AE5.txt_Truong9.Text +
                uC_Detail_AE6.txt_Truong9.Text +
                uC_Detail_AE7.txt_Truong9.Text +
                uC_Detail_AE8.txt_Truong9.Text +
                uC_Detail_AE9.txt_Truong9.Text +
                uC_Detail_AE10.txt_Truong9.Text +
                uC_HeaderAE1.txt_Truong2.Text +
                uC_HeaderAE1.txt_Truong3.Text +
                uC_HeaderAE1.txt_Truong4.Text +
                uC_HeaderAE1.txt_Truong5.Text;

        }
        public bool ConfirmEmptyWarning()
        {
            if (isEmpty())
                if (MessageBox.Show(Global.MsgWarning, Global.warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    return false;

            return true;
        }

        public string Submit(int ID_Batch, int ID_Image)
        {
            if (String.IsNullOrEmpty(uC_HeaderAE1.txt_Truong2.Text) == true)
            {
                return "1";
            }            
            

            if (ID_Batch <= 0 || ID_Image <= 0)
                return "2";
            else
            {
                string str_data_header_AE = String.Join("†", lst_texbox_Entry_AE_header.Select(x=>x.Text.Replace("†", "").Replace("‡", "").ToString()));
                string str_data_body_AE = String.Join("†", lst_texbox_Entry_AE_Body.Select(x=>x.Text.Replace("†", "").Replace("‡", "").ToString()));
                string data_full = ham_chung.ToHalfWidth(str_data_header_AE + "‡" + str_data_body_AE);
                // check dữ liệu có chứa các kí tự không cho phép hay không
                if(Global.CheckCharacterError(data_full) == true)
                {
                    return "6";
                }    
                // Dữ liệu đã được bỏ ô trống để qua LC
                string str_data_body_AE_Split = String.Join("†", lst_texbox_Entry_AE_Body.Where(x=>x.Text != "").Select(x => x.Text.Replace("†", "").Replace("‡", "").ToString()));
                string Data_Split = ham_chung.ToHalfWidth(str_data_header_AE + "‡" + str_data_body_AE_Split);                
                var type_Submit = tb_Data.Entry_insertData(ID_Image, ID_Batch, data_full, Global.Level_Pair_Entry_Nhap, Global.Level_Image, str_data_body_AE_Split.Split('†').Length, Data_Split, Global.strUsername);
                if (type_Submit.Status.ToString() == "OK")
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
            string str_data_header_AE = String.Join("†", lst_texbox_Entry_AE_header.Select(x => x.Text.Replace("†", "").Replace("‡", "").ToString()));
            string str_data_body_AE = String.Join("†", lst_texbox_Entry_AE_Body.Select(x => x.Text.Replace("†", "").Replace("‡", "").ToString()));
            string data_full = ham_chung.ToHalfWidth(str_data_header_AE + "‡" + str_data_body_AE);
            return data_full;
        }

        public void FocusUC()
        {
            this.BeginInvoke(new Action(() =>
            {
                uC_HeaderAE1.txt_Truong2.Focus();
            }));
        }
        public DataTable takeDataTableDetail()
        {
            tbDetail = new DataTable();
            indexLST = new List<int>();
            tbDetail.Columns.Add("STT", typeof(String));
            tbDetail.Columns.Add("Truong7", typeof(String));
            tbDetail.Columns.Add("Truong8", typeof(String));
            tbDetail.Columns.Add("Truong9", typeof(String));
            tbDetail.Columns.Add("Truong10", typeof(String));
            foreach (var item in lst)
            {            
                if (String.IsNullOrEmpty(item.txt_Truong9.Text)==false)
                {
                    indexLST.Add(lst.IndexOf(item));
                }
            }
            if (indexLST.Count > 0)
            {
                for (int i = 0; i <= indexLST.Last(); i++)
                {
                    dr = tbDetail.NewRow();
                    dr["STT"] = lst[i].lb_STT.Text;
                    dr["Truong7"] = "";
                    dr["Truong8"] = "";
                    dr["Truong9"] = lst[i].txt_Truong9.Text;
                    dr["Truong10"] = "";
                    tbDetail.Rows.Add(dr);
                }             
            }
            return tbDetail;
        }

        private void UC_PhieuAE_Load(object sender, EventArgs e)
        {

        }

        //public bool Save_DataChecker(string idbatch, string iDImage, string strUsername, string userNaemInputU1, string userNaemInputU2)
        //{
        //    if (String.IsNullOrEmpty(uC_HeaderAE1.txt_Truong2.Text) == true)
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
        //    cmd.Parameters.AddWithValue("@Truong_02", uC_HeaderAE1.txt_Truong2.Text);
        //    cmd.Parameters.AddWithValue("@Truong_03", uC_HeaderAE1.txt_Truong3.Text);
        //    cmd.Parameters.AddWithValue("@Truong_04", uC_HeaderAE1.txt_Truong4.Text);
        //    cmd.Parameters.AddWithValue("@Truong_05", uC_HeaderAE1.txt_Truong5.Text);
        //    cmd.Parameters.AddWithValue("@Type", "AE");
        //    cmd.Parameters.AddWithValue("@List_detail", takeDataTableDetail()).SqlDbType = SqlDbType.Structured;
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //    return true;
        //}
    }

}
