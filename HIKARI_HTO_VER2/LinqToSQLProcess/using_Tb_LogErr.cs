using HIKARI_HTO_VER2;
using HIKARI_HTO_VER2.LinqToSQLProcess;
using HIKARI_HTO_VER2.ProcessUtil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIKARI_HTO_VER2.LinqToSQLProcess
{
    internal class using_Tb_LogErr
    {
        public using_Tb_LogErr()
        {
        }

        public void AddLogErr(Exception error)
        {
            try
            {
                //using (var db = new DB_HIKARI_HPTEntities(""))
                //{
                GlobalDB.DBLinq.spLogErr_AddLogger_v2(error.ToString(), Global.strUsername, Global.strIP_Adress);
                //}
            }
            catch (Exception ex)
            {
                LogFile.WriteLog(ex.Message + "\r\n" + ex.StackTrace);
            }
        }
    }
}
