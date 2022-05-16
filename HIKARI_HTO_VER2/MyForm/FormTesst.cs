using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class FormTesst : Form
    {
        public FormTesst()
        {
            InitializeComponent();
            dt_test_aucomplete.Columns.Add("Test");
            dt_test_aucomplete.Rows.Add("1");
            dt_test_aucomplete.Rows.Add("2");
            dt_test_aucomplete.Rows.Add("3");
            dt_test_aucomplete.Rows.Add("4");
            dt_test_aucomplete.Rows.Add("5");
            dt_test_aucomplete.Rows.Add("6");
            dt_test_aucomplete.Rows.Add("7");
            dt_test_aucomplete.Rows.Add("8");
            dt_test_aucomplete.Rows.Add("9");
        }

        DataTable dt_test_aucomplete = new DataTable();

        private void gridView1_ShownEditor(object sender, EventArgs e)
        {
            TextEdit currentEditor = (sender as GridView).ActiveEditor as TextEdit;
            if (currentEditor != null)
            {
                currentEditor.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                currentEditor.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection sc = new AutoCompleteStringCollection();
                item_auto(sc);
                currentEditor.MaskBox.AutoCompleteCustomSource = sc;
            }
        }
        public void item_auto(AutoCompleteStringCollection columns)
        {
            columns.Add("111");
            columns.Add("112");
            columns.Add("113");
            columns.Add("114");
            columns.Add("115");
            columns.Add("116");
            columns.Add("117");
            columns.Add("118");
            columns.Add("119");
        }

        private void FormTesst_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = null;
            gridControl1.DataSource = dt_test_aucomplete;            
        }
    }
}
