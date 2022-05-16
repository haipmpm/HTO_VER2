using System;
using HIKARI_HTO_VER2.LinqToSQLModels;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIKARI_HTO_VER2.LinqToSQLProcess
{
    class GlobalDB
    {
        public static HTO_DataStoreDataContext DBLinq = new HTO_DataStoreDataContext(Global.ConnectionString);
    }
}
