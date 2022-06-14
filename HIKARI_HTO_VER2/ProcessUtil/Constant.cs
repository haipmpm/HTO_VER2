using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIKARI_HTO_VER2.ProcessUtil
{
    public class Constant
    {
        public static readonly Color colorBgrDanger = Color.Tomato;
        public static readonly Color colorBgrDangerForCompare = Color.PaleVioletRed;
        public static readonly Color colorBgrNomal = System.Drawing.SystemColors.Window;
        public static readonly List<int> ListMonth = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        public static readonly List<int> ListDate = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };

        public const string CHECKDESO = "Checker";
        public const string DESO = "DataEntry";
        public const string ADMIN = "Admin";
        public const string LASTCHECK = "LastCheck";

        public const int ImageName = 0;
        public const int Truong01 = 1;
        public const int Truong02 = 2;
        public const int Truong03 = 3;
        public const int Truong04 = 4;
        public const int Truong05 = 5;
        public const int Truong06 = 6;
        public const int Truong07 = 7;
        public const int Truong08 = 8;
        public const int Truong09 = 9;
        public const int Truong10 = 10;
        public const int Truong11 = 11;
        public const int Truong12 = 12;
        public const int path = 19;
        public const int BatchName = 20;
        public const int BatchID = 21;

        public static string Columns_ConTentLC = "";
        public static string Columns_ChangeData = "";
    }
}
