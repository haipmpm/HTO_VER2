using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIKARI_HTO_VER2
{
    class Global
    {
        public static string strUsername = "";
        public const string Webservice = "http://10.10.1.15:8888/Hikari_HTO_2022/";
        public const string StrPath = @"\\10.10.1.15\Hikari_HTO_2022$";
        public const string ConnectionString = "Server=10.10.1.15;Database=DB_HIKARI_VER2;User id=haipm;Password=Minhhai@171192;";
        public static object ControlFocusReturn;

        public static int LevelUser = 1;

        public const string ProjectCode = "1035";
        public const string GroupAdminCode = "2098";
        public const string Group_Operator_VN_Code = "2099";
        public const string Group_Checker_VN_Code = "2100";
        public const string Group_LastCheck_VN_Code = "2101";

        public static string BatchIDSelected = "";
        public static string BatchNameSelected = "";
        public static string BatchTypeSelected = "";
        public static int BatchChiaUser = 0;
        public static int Level_Image = 1;
        public static int Level_Pair_Entry_Nhap = 1;


        public static bool isOperatorGroup = false;
        public static bool isCheckerVNGroup = false;
        public static bool isAdminGroup = false;
        public static bool isLastCheck = false;
        public const string error = "Error";
        public const string warning = "Warning";
        public const string success = "Information";
        public static string strIP_Adress = "127.0.0.1";

        public static AutocompleteMenuNS.AutocompleteMenu ListAutoComP;
        public static string Strtoken = "";

        public static string MsgWarning = " Bạn đang để trống toàn bộ trường! Bạn có muốn tiêp tục submit không?\n" +
                                            "Nếu phiếu không có thông tin (trống toàn bộ): Nhấn Yes để submit phiếu trống. \n" +
                                            "Nếu phiếu có thông tin: Nhấn No để nhập lại phiếu này.";

        public static string RegulationAE = "QUY ĐỊNH: \n - Trường 2 không được để trống \n - Có thể nhập được T và ? (Tuỳ trường hợp) \n  để LastCheck kiểm tra lại " +
            "\n - Trường 3, 4 và 5 CHỈ NHẬP GIÁ TRỊ ĐƯỢC SỬA ";

        public static string RegulationAT = "QUY ĐỊNH: \n - Trường 2 không được để trống \n - Trường 7: \n + Điền YOHAKU khi các dòng cuối phiếu không có dữ liệu \n + Điền SAKUJYO khi dữ liệu giữa phiếu bị gạch bỏ hoặc trống nguyên dòng" +
            "\n + Điền KAKISONJI khi cả phiếu gạch chéo, bỏ  \n + Điền MISIYO khi cả phiếu trống (phiếu trắng) +\n" +
            "Lưu ý Nếu mã sản phẩm bị gạch bỏ. Nhưng vẫn có giá trị trường số 8 và 9.\n số lượng SP thì Mã SP để trống. \n và dòng đó vẫn nhập bình thường \n " +
            " - Trường 9 nếu không đọc được thì có thể điền vào ? \n LastCheck kiểm tra lại ";

        public static bool checkTokenLogin()
        {
            var token = Hikari_LoginDLL.Hikari_Login.getToken(Global.ProjectCode, Global.strUsername);
            if (token != Strtoken)
            {
                return false;
            }
            return true;

        }


         public static AutoCompleteStringCollection listAuto;
       
        
    }
}
