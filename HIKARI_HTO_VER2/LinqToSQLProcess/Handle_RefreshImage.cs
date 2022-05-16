using HIKARI_HTO_VER2.LinqToSQLModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIKARI_HTO_VER2.LinqToSQLProcess
{
    class Handle_RefreshImage
    {
        //public List<spMissImage_spBatch_GetImageNotSubmitInputResult> spMissImage_spBatch_GetImageNotSubmitInput(int Miniute)
        //{
        //    try
        //    {
        //        List<spMissImage_spBatch_GetImageNotSubmitInputResult> result = new List<spMissImage_spBatch_GetImageNotSubmitInputResult>();
        //        result = GlobalDB.DBLinq.spMissImage_spBatch_GetImageNotSubmitInput(Miniute).ToList();
        //        return result;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        public void spData_Refresh_Image_Entry_Check(string batchID,string level,string ID_Data, string status)
        {
            try
            {
                GlobalDB.DBLinq.spData_Refresh_Image_Entry_Check_v2(batchID, status, level, ID_Data);
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.ToString());
                throw;
            }
        }

        //public List<spMissCheck_GetImageNotSubmitCheckerResult> spMissCheck_GetImageNotSubmitChecker()
        //{
        //    try
        //    {
        //        List<spMissCheck_GetImageNotSubmitCheckerResult> result = new List<spMissCheck_GetImageNotSubmitCheckerResult>();
        //        result = GlobalDB.DBLinq.spMissCheck_GetImageNotSubmitChecker().ToList();
        //        return result;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        //public void spMissCheck_RefreshPhieuForOnceChecker(string userNameNewChecker, int ID)
        //{
        //    try
        //    {
        //        GlobalDB.DBLinq.spMissCheck_RefreshPhieuForOnceChecker(userNameNewChecker,ID);
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        //public void spMissCheck_RefreshPhieuForAllChecker( int ID)
        //{
        //    try
        //    {
        //        GlobalDB.DBLinq.spMissCheck_RefreshPhieuForAllChecker( ID);
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        //public List<spMissCheck_getListCheckerOnlineResult> spMissCheck_getListCheckerOnline(string BatchID)
        //{
        //    try
        //    {
        //        List<spMissCheck_getListCheckerOnlineResult> result = new List<spMissCheck_getListCheckerOnlineResult>();
        //        result = GlobalDB.DBLinq.spMissCheck_getListCheckerOnline(BatchID).ToList();
        //        return result;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
    }
}
