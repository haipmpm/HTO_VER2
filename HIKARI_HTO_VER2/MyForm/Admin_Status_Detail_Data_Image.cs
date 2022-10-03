using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIKARI_HTO_VER2.MyForm
{
    public partial class Admin_Status_Detail_Data_Image : Form
    {
        string nameimg = "", data1 = "", data2 = "",datacheck = "",datalc= "", stylebatch = "", User_1="", User_2 ="", User_Check="";

        private void btn_lc_Click(object sender, EventArgs e)
        {
            HamAdd_Data("", datalc);
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            HamAdd_Data(User_Check, datacheck);
        }

        private void btn_E2_Click(object sender, EventArgs e)
        {
            HamAdd_Data(User_2, data2);
        }

        private void btn_E1_Click(object sender, EventArgs e)
        {
            HamAdd_Data(User_1, data1);
        }
        #region
        List<RichTextBox> lst_all_rtb_AE;
        List<RichTextBox> lst_header_AT = new List<RichTextBox>();
        List<RichTextBox> lst_body_AT1 = new List<RichTextBox>();
        List<RichTextBox> lst_body_AT2 = new List<RichTextBox>();
        List<RichTextBox> lst_body_AT3 = new List<RichTextBox>();
        List<RichTextBox> lst_body_AT4 = new List<RichTextBox>();
        List<RichTextBox> lst_body_AT5 = new List<RichTextBox>();
        List<RichTextBox> lst_body_AT6 = new List<RichTextBox>();
        List<RichTextBox> lst_body_AT7 = new List<RichTextBox>();
        List<RichTextBox> lst_body_AT8 = new List<RichTextBox>();
        List<RichTextBox> lst_body_AT9 = new List<RichTextBox>();
        List<RichTextBox> lst_body_AT10 = new List<RichTextBox>();
        List<List<RichTextBox>> lst_to_List_Rtb = new List<List<RichTextBox>>();
        #endregion
        public Admin_Status_Detail_Data_Image(string style_batch , string nameimage, string data_e1, string Data_E2,string User1, string User2, string Checker,string UserCheck, string Lastcheck)
        {
            InitializeComponent();
            nameimg = nameimage;
            data1 = data_e1; User_1 = User1;
            data2 = Data_E2; User_2 = User2;
            datacheck = Checker; User_Check = UserCheck;
            datalc = Lastcheck; stylebatch = style_batch;
            lst_all_rtb_AE = new List<RichTextBox>() { rtb_truong2, rtb_truong3, rtb_truong4, rtb_truong5, rtb_truong9_1, rtb_truong9_2, rtb_truong9_3, rtb_truong9_4, rtb_truong9_5, rtb_truong9_6, rtb_truong9_7, rtb_truong9_8, rtb_truong9_9, rtb_truong9_10 };
            lst_header_AT = new List<RichTextBox>() { rtb_AT_T2, rtb_AT_T3, rtb_AT_T4, rtb_AT_T5 };
            lst_body_AT1 = new List<RichTextBox>() { rtb_truong7_1, rtb_truong10_1, rtb_truong8_1, AT_Rtb_truong9_1 };
            lst_body_AT2 = new List<RichTextBox>() { rtb_truong7_2, rtb_truong10_2, rtb_truong8_2, AT_Rtb_truong9_2 };
            lst_body_AT3 = new List<RichTextBox>() { rtb_truong7_3, rtb_truong10_3, rtb_truong8_3, AT_Rtb_truong9_3 };
            lst_body_AT4 = new List<RichTextBox>() { rtb_truong7_4, rtb_truong10_4, rtb_truong8_4, AT_Rtb_truong9_4 };
            lst_body_AT5 = new List<RichTextBox>() { rtb_truong7_5, rtb_truong10_5, rtb_truong8_5, AT_Rtb_truong9_5 };
            lst_body_AT6 = new List<RichTextBox>() { rtb_truong7_6, rtb_truong10_6, rtb_truong8_6, AT_Rtb_truong9_6 };
            lst_body_AT7 = new List<RichTextBox>() { rtb_truong7_7, rtb_truong10_7, rtb_truong8_7, AT_Rtb_truong9_7 };
            lst_body_AT8 = new List<RichTextBox>() { rtb_truong7_8, rtb_truong10_8, rtb_truong8_8, AT_Rtb_truong9_8 };
            lst_body_AT9 = new List<RichTextBox>() { rtb_truong7_9, rtb_truong10_9, rtb_truong8_9, AT_Rtb_truong9_9 };
            lst_body_AT10 = new List<RichTextBox>() { rtb_truong7_10, rtb_truong10_10, rtb_truong8_10, AT_Rtb_truong9_10 };
            lst_to_List_Rtb = new List<List<RichTextBox>>() { lst_header_AT, lst_body_AT1, lst_body_AT2, lst_body_AT3, lst_body_AT4, lst_body_AT5, lst_body_AT6, lst_body_AT7, lst_body_AT8, lst_body_AT9, lst_body_AT10 };
        }

        private void Admin_Status_Detail_Data_Image_Load(object sender, EventArgs e)
        {
            lb_tenanh.Text = "Tên Ảnh: " + nameimg;
            if (stylebatch == "AE")
            {
                tab_AE.PageVisible = true;
                tabcontrol.SelectedTabPage = tab_AE;
                tab_AT.PageVisible = false;

            }
            else if (stylebatch == "AT")
            {
                tab_AT.PageVisible = true;
                tabcontrol.SelectedTabPage = tab_AT;
                tab_AE.PageVisible = false;
            }
            else
            {
                tab_AE.PageVisible = false;
                tab_AT.PageVisible = false;
                return;
            }
            btn_E1_Click(null, null);
        }
        private void HamAdd_Data(string username,string data)
        {
            if (stylebatch == "AE")
            {
                lb_User1_AE.Text = "User Xử lý:  " + username;
                for (int i = 0; i < lst_all_rtb_AE.Count(); i++)
                { 
                    if (i < 4)
                    {
                        lst_all_rtb_AE[i].Text = data.Split('‡')[0].Split('†')[i];                        
                    }
                    else
                    {
                        try { lst_all_rtb_AE[i].Text = data.Split('‡')[1].Split('†')[i - 4]; } catch { lst_all_rtb_AE[i].Text = ""; }                        
                    }
                }
            }
            else if(stylebatch == "AT")
            {
                lb_User1_AT.Text = "User Xử lý:  " + username;
                for (int i = 0; i < lst_to_List_Rtb.Count; i++)
                {
                    for (int z = 0; z < lst_to_List_Rtb[i].Count; z++)
                    {                        
                        lst_to_List_Rtb[i][z].Text = data.Split('‡')[i].Split('†')[z];
                    }
                }
            }
        }
    }
}
