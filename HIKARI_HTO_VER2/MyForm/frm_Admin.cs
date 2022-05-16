using HIKARI_HTO_VER2.LinqToSQLProcess;
using HIKARI_HTO_VER2.MyUserControl;
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
    public partial class frm_Admin : Form
    {
        public frm_Admin()
        {
            InitializeComponent();
        }
        using_Tb_Batch using_Batch;
        private void btn_TaoBatch_Click(object sender, EventArgs e)
        {
            
        }

        private void frm_Admin_Load(object sender, EventArgs e)
        {
            if (Tab_Admin.SelectedTab == Tab_Admin.TabPages["Batch_Mng"])
            {
                Manager_Batch mng = new Manager_Batch();
                mng.Show();
            }
        }
        
        private void Tab_Admin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Tab_Admin.SelectedTab == Tab_Admin.TabPages["Batch_Mng"])
            {
                
            }
            else if (Tab_Admin.SelectedTab == Tab_Admin.TabPages["Export_Excel"])
            {

            }
            else if (Tab_Admin.SelectedTab == Tab_Admin.TabPages["Status"])
            {

            }
            else if (Tab_Admin.SelectedTab == Tab_Admin.TabPages["Performance"])
            {

            }
            else if (Tab_Admin.SelectedTab == Tab_Admin.TabPages["Rf_img_entry"])
            {

            }
            else if (Tab_Admin.SelectedTab == Tab_Admin.TabPages["Rf_img_check"])
            {

            }
        }
    }
}
