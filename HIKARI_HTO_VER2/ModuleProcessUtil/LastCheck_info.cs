using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIKARI_HTO_VER2.ModuleProcessUtil
{
    public class LastCheck_info
    {
        public DataTable Tb_Data_Batch { get; set; }
        public DataTable Tb_Data_QuetLogic { get; set; }
        public DataTable Tb_ContenE1 { get; set; }
        public DataTable Tb_ContenE2 { get; set; }
        public DataTable Tb_ContenCheck { get; set; }
        public DataTable Tb_LC { get; set; }
        public int SL_Img { get; set; }
        public DataTable Tb_Cloumns { get; set; }
        public DataTable Tb_CheckLogic { get; set; }

        public int index_Click { get; set; }

    }
}
