using HIKARI_HTO_VER2.MyForm;
using Hikari_LoginDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIKARI_HTO_VER2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            bool loop = true;
            while (loop)
            {
                loop = false;
                Global.isAdminGroup = false;
                Global.isCheckerVNGroup = false;
                Global.isOperatorGroup = false;
                Global.strUsername = "";

                Hikari_Login lg = new Hikari_Login();

                //Kiểm tra version. Chỉ khả dụng khi chạy ở chế độ Deployment. Chế độ debug không khả dụng.
                string strVersion = "";
                //if (ApplicationDeployment.IsNetworkDeployed)
                //{
                //    strVersion = string.Format("{0}", ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4));
                //    if (strVersion != Hikari_Login.GetVersionOfProjectCode(Global.ProjectCode))
                //    {
                //        MessageBox.Show("Version " + strVersion + Hikari_Login.GetVersionOfProjectCode(Global.ProjectCode) + " bạn dùng đã cũ, vui lòng cập nhật phiên bản mới!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        //Global.RunUpdateVersion();
                //        return;
                //    }
                //}


                if (lg.ShowLoginForm("HTO Version 2.0" + strVersion) == true)
                {
                    //Update log of login

                    Global.strUsername = Hikari_Login.strUsername;

                    var qr = Hikari_Login.GetAllGroupCodeOfProject(Global.strUsername, Global.ProjectCode);
                    if (qr == null)
                    {
                        MessageBox.Show("Bạn chưa được phân quyền cho dự án này. Vui lòng liên hệ quản lý.", "Thông báo");
                        loop = true;
                        continue;

                    }
                    if (qr.Count <= 0)
                    {
                        MessageBox.Show("Bạn chưa được phân quyền cho dự án này. Vui lòng liên hệ quản lý.", "Thông báo");
                        loop = true;
                        continue;

                    }
                    else
                    {

                        // cập nhật token 
                        Global.Strtoken = Hikari_Login.CreateNewToken(Global.strUsername);
                        Hikari_Login.updateToken(Global.ProjectCode, Global.strUsername, Global.Strtoken);
                        Global.LevelUser = Hikari_Login.GetLevelUserOfGroupProject(Global.strUsername, Global.Group_Operator_VN_Code);

                        if (qr.IndexOf(Global.GroupAdminCode) >= 0)
                            Global.isAdminGroup = true;
                        if (qr.IndexOf(Global.Group_Checker_VN_Code) >= 0)
                            Global.isCheckerVNGroup = true;
                        if (qr.IndexOf(Global.Group_Operator_VN_Code) >= 0)
                            Global.isOperatorGroup = true;
                        if (qr.IndexOf(Global.Group_LastCheck_VN_Code) >= 0)
                            Global.isLastCheck = true;

                        var firstAddress = (from address in NetworkInterface.GetAllNetworkInterfaces().Select(x => x.GetIPProperties()).SelectMany(x => x.UnicastAddresses).Select(x => x.Address)
                                            where !IPAddress.IsLoopback(address) && address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork
                                            select address).FirstOrDefault();
                        Global.strIP_Adress = firstAddress.ToString();

                        frm_Main formMain = new frm_Main();
                        formMain.lb_Title.Text = formMain.lb_Title.Text + strVersion;
                        if (formMain.ShowDialog() == DialogResult.Yes)
                        {
                            loop = true;
                        }    
                            
                    }
                }
            }
        }
            
    }
}
