using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIKARI_HTO_VER2.ModuleProcessUtil
{
    public class Admin_info
    {
        public string dataDetail = "AE";
        public string dataTitle = "AT";
        public DataTable  dt_pfm { get; set; }
        public DataTable dt_pfm_Entry { get; set; }
        public DataTable dt_pfm_Check { get; set; }
        public DataTable dt_pfm_LastCheck { get; set; }
        public string  Time_Start { get; set; }
        public string Time_End { get; set; }

        public string Pfm_Time_inDateTime { get; set; }

        public DataTable dt_Status { get; set; }
        public string Status_Time_inDateTime { get; set; }

        public string Style_batch { get; set; }

        public string Status_info_batchChitiet { get; set; }
    }
}
