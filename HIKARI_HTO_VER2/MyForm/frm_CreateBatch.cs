using HIKARI_HTO_VER2.LinqToSQLProcess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIKARI_HTO_VER2.MyForm
{
    public partial class frm_CreateBatch : Form
    {
        private string[] _lFileNames;
        private bool _multi;
        private int soluonghinh;
        string folderBatch = string.Empty;
        string[] separators = { @"\", "/" };
        using_Tb_Batch tb_batch;
        public frm_CreateBatch()
        {
            InitializeComponent();
        }


        private void btn_BrowserImage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_BatchName.Text))
            {
                MessageBox.Show("Vui lòng điền tên batch", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Types Image|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";

            dlg.Multiselect = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _lFileNames = dlg.FileNames;
                txt_ImagePath.Text = Path.GetDirectoryName(dlg.FileName);
                btn_CleanSingle.Enabled = true;
                btn_CleanMulti.Enabled = false;
            }
            soluonghinh = 0;
            soluonghinh = dlg.FileNames.Length;
            lb_SoLuongHinh.Text = dlg.FileNames.Length + " files ";
        }

        private void btn_CreateBatch_Click(object sender, EventArgs e)
        {

        }

        private void frm_CreateBatch_Load(object sender, EventArgs e)
        {
            tb_batch = new using_Tb_Batch();
            try
            {
                chk_ChiaUserDESO.Checked = true;
                txt_UserCreate.Text = Global.strUsername;
                txt_DateCreate.Text = DateTime.Now.ToShortDateString() + "-" + DateTime.Now.ToShortTimeString();
                txt_ImagePath.ReadOnly = false;
                txt_PathFolder.ReadOnly = false;
                txt_FolderName.ReadOnly = false;
                cbb_Loai.Items.Clear();
                cbb_Loai.Items.Add(new { Text = "AE", Value = "AE" });
                cbb_Loai.Items.Add(new { Text = "AT", Value = "AT" });
                cbb_Loai.DisplayMember = "Text";
                cbb_Loai.ValueMember = "Value";
                cbb_Loai.SelectedIndex = 0;
                txt_BatchName.Focus();
            }
            catch { }
        }

        private void txt_BatchName_EditValueChanged(object sender, EventArgs e)
        {
            folderBatch = string.Empty;
            if (!string.IsNullOrEmpty(txt_BatchName.Text))
            {
                _multi = false;
                txt_PathFolder.Enabled = false;
                btn_Browser.Enabled = false;
                txt_FolderName.ReadOnly = false;
            }
            else
            {
                txt_PathFolder.Enabled = true;
                btn_Browser.Enabled = true;
                txt_FolderName.ReadOnly = true;
            }
        }

        private void btn_Browser_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_PathFolder.Text = folderBrowserDialog1.SelectedPath;
                txt_FolderName.Text = Path.GetFileName(folderBrowserDialog1.SelectedPath);
                btn_CleanSingle.Enabled = false;
                btn_CleanMulti.Enabled = true;
            }
        }

        private void txt_PathFolder_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_PathFolder.Text))
                {
                    _multi = true;
                    folderBatch = Path.GetFileName(Path.GetDirectoryName(txt_PathFolder.Text + @"\"));
                    txt_BatchName.Enabled = false;
                    txt_ImagePath.Enabled = false;
                    btn_BrowserImage.Enabled = false;
                }
                else
                {
                    folderBatch = string.Empty;
                    txt_BatchName.Enabled = true;
                    txt_ImagePath.Enabled = true;
                    btn_BrowserImage.Enabled = true;
                }
            }
            catch
            {
                folderBatch = string.Empty;
            }
        }

        private void btn_CreateBatch_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (backgroundWorker1.IsBusy)
                {
                    MessageBox.Show("Quá trình tạo batch đang diễn ra, Bạn hãy chờ quá trình tạo batch kết thúc mới tiếp tục tạo batch mới !");
                    return;
                }
                lb_SobatchHoanThanh.Text = "";
                txt_DateCreate.Text = DateTime.Now.ToShortDateString() + "-" + DateTime.Now.ToShortTimeString();
                if (_multi) // Sự kiện Muti Batch Upload
                {
                    if (txt_PathFolder.Text == "")
                    {
                        MessageBox.Show("Thiếu thông tin Folder Batch");
                        return;
                    }
                }
                else // Sự kiện Upload Single
                {
                    if (string.IsNullOrEmpty(cbb_Loai.Text) && _multi == false)
                    {
                        MessageBox.Show("Vui lòng chọn loại phiếu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (txt_ImagePath.Text == "")
                        {
                            MessageBox.Show("Thiếu thông tin: Tên Batch !"); return;
                        }
                        else if (txt_BatchName.Text == "")
                        {
                            MessageBox.Show("Thiếu thông tin: Đường dẫn Image!"); return;
                        }                        
                    }
                }
                backgroundWorker1.RunWorkerAsync();
            }
            catch(Exception exx)
            {
                MessageBox.Show(exx.ToString());
            }
        }
        private void Upload_Single_Batch()
        {            
            progressBar1.Step = 1;
            progressBar1.Value = 1;
            progressBar1.Maximum = _lFileNames.Length;
            progressBar1.Minimum = 0;
            ModifyProgressBarColor.SetState(progressBar1, 1);
            //StringBuilder sBatchID = new StringBuilder();
            //sBatchID.Append(txt_BatchName.Text + "_" + cbb_Loai.Text + "_" + Guid.NewGuid().ToString().Replace("-", ""));
            //var batch = tb_batch.GetBatchID(sBatchID.ToString());
            ///*
            // * Tạo Batch mới.
            // */
            int Id_batch = 0;
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new[] { new DataColumn("ImageName", typeof(string)) });
            for (int i = 0; i < _lFileNames.Count(); i++)
            {
                FileInfo fi = new FileInfo(_lFileNames[i]);
                dt.Rows.Add(fi.Name);
            }
            
            if (!string.IsNullOrEmpty(txt_ImagePath.Text))
            {
                var fBatch = new LinqToSQLModels.Tb_Batch
                {
                    BatchName = txt_BatchName.Text,
                    PathPicture = txt_Location.Text,
                    Location = txt_ImagePath.Text,
                    NumberImage = Convert.ToInt32(soluonghinh.ToString()),
                    BatchType = cbb_Loai.Text,
                    ChiaUser = chk_ChiaUserDESO.Checked ? true : false,
                    CongKhaiBatch = false,
                    Usercreate = txt_UserCreate.Text,
                    DateCreate = DateTime.Now,
                };
                Id_batch = tb_batch.AddBatch(fBatch);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn hình ảnh!");
                return;
            }
            string str_table_days = DateTime.Now.ToString("yyyyMM");
            try
            {
                SqlConnection con = new SqlConnection(Global.ConnectionString);
                SqlCommand cmd = new SqlCommand("Insert_Image_v2", con);
                cmd.CommandTimeout = 10 * 60;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Batch", Id_batch.ToString());
                cmd.Parameters.AddWithValue("@Name_table", str_table_days);
                cmd.Parameters.AddWithValue("@list_image", dt);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception exx)
            {
                tb_batch.Delete_Batch(Id_batch.ToString(), str_table_days);
                MessageBox.Show(exx.ToString());
                return;
            }
            
            int dem = 0;
            StringBuilder str_path_img_server = new StringBuilder();
            str_path_img_server.Append(Global.StrPath + "\\" + Id_batch + "_" + txt_BatchName.Text);
            //string str_path_img_server = Id_batch + "_" + txt_BatchName.Text;
            if (!Directory.Exists(str_path_img_server.ToString()))
                Directory.CreateDirectory(str_path_img_server.ToString());
            else
            {
                MessageBox.Show("Bị trùng tên batch!");
                return;
            }
            BackgroundWorker bgw1 = new BackgroundWorker();
            bgw1.DoWork += delegate
            {
                for (int i = 0; i < _lFileNames.Count(); i += 3)
                {
                    File.Copy(_lFileNames[i], str_path_img_server + @"\" + new FileInfo(_lFileNames[i]).Name);                    
                    progressBar1.PerformStep();
                    lb_SoImageDaHoanThanh.BeginInvoke(new Action(() => { lb_SoImageDaHoanThanh.Text = (++dem) + @"\" + _lFileNames.Count(); }));
                }
            };
            bgw1.RunWorkerAsync();
            BackgroundWorker bgw2 = new BackgroundWorker();
            bgw2.DoWork += delegate
            {
                for (int i = 1; i < _lFileNames.Count(); i += 3)
                {
                    File.Copy(_lFileNames[i], str_path_img_server + @"\" + new FileInfo(_lFileNames[i]).Name);
                    progressBar1.PerformStep();
                    lb_SoImageDaHoanThanh.BeginInvoke(new Action(() => { lb_SoImageDaHoanThanh.Text = (++dem) + @"\" + _lFileNames.Count(); }));
                }
            };
            bgw2.RunWorkerAsync();
            BackgroundWorker bgw3 = new BackgroundWorker();
            bgw3.DoWork += delegate
            {
                for (int i = 2; i < _lFileNames.Count(); i += 3)
                {
                    File.Copy(_lFileNames[i], str_path_img_server + @"\" + new FileInfo(_lFileNames[i]).Name);
                    progressBar1.PerformStep();
                    lb_SoImageDaHoanThanh.BeginInvoke(new Action(() => { lb_SoImageDaHoanThanh.Text = (++dem) + @"\" + _lFileNames.Count(); }));
                }
            };
            bgw3.RunWorkerAsync();
            while (bgw1.IsBusy || bgw2.IsBusy || bgw3.IsBusy)
            {
                Thread.Sleep(2000);
            }
            txt_DateCreate.Text = DateTime.Now.ToShortDateString() + "-" + DateTime.Now.ToShortTimeString();
            MessageBox.Show("Tạo batch mới thành công!");
            txt_BatchName.Text = "";
            txt_ImagePath.Text = "";
            lb_SoLuongHinh.Text = "";
        }
        private void Upload_Muti_Batch()
        {
            btn_Browser.Enabled = false;
            txt_PathFolder.Enabled = false;
            List<string> lStrBath = new List<string>();
            lStrBath.AddRange(Directory.GetDirectories(txt_PathFolder.Text));
            _multi = true;
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new[] { new DataColumn("ImageName", typeof(string)) });
            string batchNameEmptyImage = string.Empty;
            int CountBatchFinish = 0;
            StringBuilder strError = new StringBuilder();
            foreach (string itemBatch in lStrBath)
            {
                dt.Clear();
                StringBuilder batchId = new StringBuilder();
                CountBatchFinish++;
                batchId.Append(new DirectoryInfo(itemBatch).Name + "_" + cbb_Loai.Text + "_" + Guid.NewGuid().ToString().Replace("-", ""));
                var filters = new String[] { "jpg", "jpeg", "png", "gif", "tif", "bmp" };
                string[] pathImageLocation = GetFilesFrom(itemBatch, filters, false);
                int Id_batch = 0;
                var fBatch = new LinqToSQLModels.Tb_Batch
                {
                    BatchName = txt_BatchName.Text,
                    PathPicture = txt_Location.Text,
                    Location = txt_ImagePath.Text,
                    NumberImage = Convert.ToInt32(soluonghinh.ToString()),
                    BatchType = cbb_Loai.Text,
                    ChiaUser = chk_ChiaUserDESO.Checked ? true : false,
                    CongKhaiBatch = false,
                    Usercreate = txt_UserCreate.Text,
                    DateCreate = DateTime.Now,
                };
                Id_batch = tb_batch.AddBatch(fBatch);

                if (pathImageLocation.Count() > 0)
                {
                    progressBar1.Step = 1;
                    progressBar1.Value = 1;
                    progressBar1.Maximum = pathImageLocation.Count();
                    progressBar1.Minimum = 0;
                    ModifyProgressBarColor.SetState(progressBar1, 1);
                    string str_table_days = DateTime.Now.ToString("yyyyMM");
                    for (int i = 0; i < pathImageLocation.Count(); i++)
                    {
                        FileInfo fi = new FileInfo(pathImageLocation[i]);
                        dt.Rows.Add(fi.Name);
                    }
                    try
                    {
                        SqlConnection con = new SqlConnection(Global.ConnectionString);
                        SqlCommand cmd = new SqlCommand("Insert_Image_v2", con);
                        cmd.CommandTimeout = 10 * 60;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID_Batch", Id_batch.ToString());
                        cmd.Parameters.AddWithValue("@Name_table", str_table_days);
                        cmd.Parameters.AddWithValue("@list_image", dt);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception exx)
                    {
                        tb_batch.Delete_Batch(Id_batch.ToString(), str_table_days);
                        MessageBox.Show(exx.ToString());
                        return;
                    }
                }
                else
                { batchNameEmptyImage = batchNameEmptyImage + itemBatch + "\n"; }
                int dem = 0;
                StringBuilder str_path_img_server = new StringBuilder();
                str_path_img_server.Append(Global.StrPath + "\\" + Id_batch + "_" + txt_BatchName.Text);
                BackgroundWorker bgw1 = new BackgroundWorker();
                bgw1.DoWork += delegate
                {
                    for (int i = 0; i < _lFileNames.Count(); i += 3)
                    {
                        try
                        {
                            File.Copy(_lFileNames[i], str_path_img_server + @"\" + new FileInfo(_lFileNames[i]).Name);
                            progressBar1.PerformStep();
                            lb_SoImageDaHoanThanh.BeginInvoke(new Action(() => { lb_SoImageDaHoanThanh.Text = (++dem) + @"\" + _lFileNames.Count(); }));
                        }
                        catch (Exception ex)
                        {
                            strError.Append(ex.Message);
                        }                        
                    }
                };
                bgw1.RunWorkerAsync();
                BackgroundWorker bgw2 = new BackgroundWorker();
                bgw2.DoWork += delegate
                {
                    for (int i = 1; i < _lFileNames.Count(); i += 3)
                    {
                        try
                        {
                            File.Copy(_lFileNames[i], str_path_img_server + @"\" + new FileInfo(_lFileNames[i]).Name);
                            progressBar1.PerformStep();
                            lb_SoImageDaHoanThanh.BeginInvoke(new Action(() => { lb_SoImageDaHoanThanh.Text = (++dem) + @"\" + _lFileNames.Count(); }));
                        }
                        catch (Exception ex)
                        {
                            strError.Append(ex.Message);
                        }
                    }
                };
                bgw2.RunWorkerAsync();
                BackgroundWorker bgw3 = new BackgroundWorker();
                bgw3.DoWork += delegate
                {
                    for (int i = 2; i < _lFileNames.Count(); i += 3)
                    {
                        try
                        {
                            File.Copy(_lFileNames[i], str_path_img_server + @"\" + new FileInfo(_lFileNames[i]).Name);
                            progressBar1.PerformStep();
                            lb_SoImageDaHoanThanh.BeginInvoke(new Action(() => { lb_SoImageDaHoanThanh.Text = (++dem) + @"\" + _lFileNames.Count(); }));
                        }
                        catch (Exception ex)
                        {
                            strError.Append(ex.Message);
                        }
                    }
                };
                bgw3.RunWorkerAsync();
                while (bgw1.IsBusy || bgw2.IsBusy || bgw3.IsBusy)
                {
                    Thread.Sleep(2000);
                }
                lb_SobatchHoanThanh.BeginInvoke(new Action(() => { lb_SobatchHoanThanh.Text = CountBatchFinish + @"/" + lStrBath.Count; }));
                if (strError.Length > 0)
                    MessageBox.Show("Có lỗi trong quá trình tạo batch: " + strError);
                else if (string.IsNullOrEmpty(batchNameEmptyImage))
                    MessageBox.Show("Tạo batch mới thành công!");
                else
                    MessageBox.Show("Tạo batch mới thành công!\nNhững batch sau không có ảnh:\n" + batchNameEmptyImage);
                txt_BatchName.Text = "";
                txt_ImagePath.Text = "";
                lb_SoLuongHinh.Text = "";
                txt_PathFolder.Text = "";
                cbb_Loai.SelectedIndex = 0;
                //btn_CreateBatch.Enabled = true;
                btn_Browser.Enabled = true;
                txt_PathFolder.Enabled = true;
                txt_Location.Enabled = true;
            }
        }

        public static string[] GetFilesFrom(string searchFolder, string[] filters, bool isRecursive)
        {
            List<string> filesFound = new List<string>();
            var searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            foreach (var filter in filters)
            {
                filesFound.AddRange(Directory.GetFiles(searchFolder, $"*.{filter}", searchOption));
            }
            return filesFound.ToArray();
        }
        private void DisableControl()
        {
            txt_BatchName.Enabled = false;
            btn_CleanSingle.Enabled = false;
            txt_ImagePath.Enabled = false;
            btn_BrowserImage.Enabled = false;

            chk_ChiaUserDESO.Enabled = false;


            txt_Location.Enabled = false;
            txt_UserCreate.Enabled = false;
            txt_DateCreate.Enabled = false;
            cbb_Loai.Enabled = false;
            txt_FolderName.Enabled = false;
            btn_CreateBatch.Enabled = false;
            txt_PathFolder.Enabled = false;
            btn_Browser.Enabled = false;
            btn_CleanMulti.Enabled = false;
        }

        private void EnableControl()
        {
            txt_BatchName.Enabled = true;
            btn_CleanSingle.Enabled = true;
            txt_ImagePath.Enabled = true;
            btn_BrowserImage.Enabled = true;
            chk_ChiaUserDESO.Enabled = true;
            txt_Location.Enabled = true;
            txt_UserCreate.Enabled = true;
            txt_DateCreate.Enabled = true;
            cbb_Loai.Enabled = true;
            txt_FolderName.Enabled = true;
            btn_CreateBatch.Enabled = true;
            txt_PathFolder.Enabled = true;
            btn_Browser.Enabled = true;
            btn_CleanMulti.Enabled = true;
        }

        private void frm_CreateBatch_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backgroundWorker1.IsBusy == true)
                e.Cancel = true;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result != null)
                MessageBox.Show(e.Result.ToString());
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            #region Quá trính tính toán dữ liệu trước khi chạy  BackGroundWorker
            if (_multi) // Sự kiện Muti Batch Upload
            {
                lb_SobatchHoanThanh.Text = "";
                DisableControl();
                lb_SoImageDaHoanThanh.Text = "";
                Upload_Muti_Batch();
            }
            else // Sự kiện Upload Single
            {                
                DisableControl();
                lb_SobatchHoanThanh.Text = "1";
                lb_SoImageDaHoanThanh.Text = "";                    
                Upload_Single_Batch();                
            }
            #endregion
        }
    }
    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this System.Windows.Forms.ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}
