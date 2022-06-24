using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIKARI_HTO_VER2.ModuleProcessUtil
{
    public class Ham_Chung
    {
        #region Compare string
        static int max(int a, int b)
        {
            return (a > b) ? a : b;
        }
        static int[,] c;
        //Prints one LCS
        private string BackTrack(string s1, string s2, int i, int j)
        {
            if (i == 0 || j == 0)
                return "";
            if (s1[i - 1] == s2[j - 1])
            {
                //lsttxt[numbertrtxt].SelectionStart = i - 1;
                //lsttxt[numbertrtxt].SelectionLength = 1;
                //lsttxt[numbertrtxt].SelectionColor = Color.Black;
                return BackTrack(s1, s2, i - 1, j - 1) + s1[i - 1];
            }
            else if (c[i - 1, j] > c[i, j - 1])
                return BackTrack(s1, s2, i - 1, j);

            else
                return BackTrack(s1, s2, i, j - 1);

        }
        //Nghịch       
        private string BackTrack2(string s1, string s2, int i, int j)
        {
            if (i == 0 || j == 0)
                return "";
            if (s1[i - 1] == s2[j - 1])
            {
                return BackTrack2(s1, s2, i - 1, j - 1) + s1[i - 1];
            }
            else if (c[i - 1, j] > c[i, j - 1])
                return BackTrack2(s1, s2, i - 1, j);

            else
                return BackTrack2(s1, s2, i, j - 1);

        }
        static int LCS(string s1, string s2)
        {
            for (int i = 1; i <= s1.Length; i++)
                c[i, 0] = 0;
            for (int i = 1; i <= s2.Length; i++)
                c[0, i] = 0;

            for (int i = 1; i <= s1.Length; i++)
                for (int j = 1; j <= s2.Length; j++)
                {
                    if (s1[i - 1] == s2[j - 1])
                        c[i, j] = c[i - 1, j - 1] + 1;
                    else
                    {
                        c[i, j] = max(c[i - 1, j], c[i, j - 1]);

                    }

                }

            return c[s1.Length, s2.Length];

        }
        #endregion
        List<int> IndexDiffs;
        private string BackTrack_new(string s1, string s2, int lengs1, int lengs2, RichTextBox rtb)
        {
            if (lengs1 == 0 || lengs2 == 0)
                return "";
            if (s1[lengs1 - 1] == s2[lengs2 - 1])
            {
                IndexDiffs.Add(lengs1 - 1);
                //rtb.SelectionStart = i - 1;
                //rtb.SelectionLength = 1;
                //rtb.SelectionColor = Color.Black;
                return BackTrack_new(s1, s2, lengs1 - 1, lengs2 - 1, rtb); //+ s1[lengs1 - 1];
            }
            else if (c[lengs1 - 1, lengs2] >= c[lengs1, lengs2 - 1])
                return BackTrack_new(s1, s2, lengs1 - 1, lengs2, rtb);

            else
                return BackTrack_new(s1, s2, lengs1, lengs2 - 1, rtb);

        }
        void FillColorDiff(RichTextBox rtb, List<int> lDiff, bool isReverse)
        {
            if (isReverse)
            {
                //lDiff.Reverse();
                foreach (int diff in lDiff)
                {
                    rtb.SelectionStart = rtb.TextLength - diff - 1;
                    rtb.SelectionLength = 1;
                    rtb.SelectionColor = Color.Black;
                }
            }
            else
            {
                foreach (int diff in lDiff)
                {
                    rtb.SelectionStart = diff;
                    rtb.SelectionLength = 1;
                    rtb.SelectionColor = Color.Black;
                }
            }
        }
        public int return_error(string vl1, string vl2)
        {
            int eror = 0;
            c = null;
            c = new int[vl1.Length + 1, vl2.Length + 1];
            int vlLCS = LCS(vl1, vl2);
            if (vl1 == vl2)
                eror = 0;
            if (vl1.Length > vl2.Length)
                eror = vl1.Length - vlLCS;
            else
                eror = vl2.Length - vlLCS;
            return eror;
        }

        private const uint LOCALE_SYSTEM_DEFAULT = 0x0800;
        private const uint LCMAP_HALFWIDTH = 0x00400000;
        public string ToHalfWidth(string fullWidth)
        {
            StringBuilder sb = new StringBuilder(6144);
            LCMapString(LOCALE_SYSTEM_DEFAULT, LCMAP_HALFWIDTH, fullWidth, -1, sb, sb.Capacity);
            return sb.ToString();
        }
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        private static extern int LCMapString(uint Locale, uint dwMapFlags, string lpSrcStr, int cchSrc, StringBuilder lpDestStr, int cchDest);
        private const uint LCMAP_FULLWIDTH = 0x00800000;
        public string ToFullWidth(string halfWidth)
        {
            StringBuilder sb = new StringBuilder(256);
            LCMapString(LOCALE_SYSTEM_DEFAULT, LCMAP_FULLWIDTH, halfWidth, -1, sb, sb.Capacity);
            return sb.ToString();
        }
        public string getcharacter(int n, string str)
        {
            string kq = "";
            for (int i = 1; i <= n; i++)
            {
                kq = kq.Insert(kq.Length, str);
            }

            return kq;
        }

        public string ThemKyTubatKyStrPhiaSau(string input, int iByte, string str)
        {
            if (input.Length > iByte)
                return input.Substring(0, iByte);
            if (input.Length == iByte)
                return input;

            return input.Insert(input.Length, getcharacter(iByte - input.Length, str));
        }

        public string ThemKyTuPhiaTruocVaBoKyTuPhiaSau(string input, int ibyte, string str)
        {
            if (input.Length >= ibyte)
                return input.Substring(0, ibyte);
            return input.Insert(0, getcharacter(ibyte - input.Length, str));
        }
    }
}
