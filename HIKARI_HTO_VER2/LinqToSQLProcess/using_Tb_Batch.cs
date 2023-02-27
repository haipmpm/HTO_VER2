using HIKARI_HTO_VER2.LinqToSQLModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIKARI_HTO_VER2.LinqToSQLProcess
{
    internal class using_Tb_Batch
    {
        using_Tb_LogErr logErr;
        public string getBatNotFinishChecker = "GetBatNotFinishChecker";
        public string getBatNotFinish = "GetBatNotFinish";
        public string getBatch_FULL = "GetBatch_FULL";
        public string getBatch_Single = "GetBatch_Single";
        public using_Tb_Batch()
        {
            logErr = new using_Tb_LogErr();
        }        
        //public List<spBatch_GetListBatch_Entry_v2Result> Get_ListBatch_Entry(int level_image, string ID_Batch, string level_User, string UserName)
        //{
        //    try 
        //    {
        //        return GlobalDB.DBLinq.spBatch_GetListBatch_Entry_v2(level_image.ToString(), ID_Batch, level_User, UserName).ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        logErr.AddLogErr(ex);
        //    }
        //    return null;
        //}
        public List<spEntryGetListBatch_v4Result> Get_ListBatch_Entry_2023(int level_image, int ID_Batch, int level_User, string UserName)
        {
            try
            {
                return GlobalDB.DBLinq.spEntryGetListBatch_v4(level_image, ID_Batch, level_User, UserName).ToList();
            }
            catch (Exception ex)
            {
                logErr.AddLogErr(ex);
            }
            return null;
        }
        public List<spCheck_GetLishCheck_v3Result> Get_ListBatch_Checker(int level_image, int ID_Batch)
        {
            try
            {
                return GlobalDB.DBLinq.spCheck_GetLishCheck_v3(ID_Batch,level_image).ToList();
            }
            catch (Exception ex)
            {
                logErr.AddLogErr(ex);
            }
            return null;
        }
        //public List<Main_GetListBatch_Check_NewResult> Get_ListBatch_Checker_New0806(int level_image, string ID_Batch)
        //{
        //    try
        //    {
        //        return GlobalDB.DBLinq.Main_GetListBatch_Check_New(ID_Batch, level_image.ToString()).ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        logErr.AddLogErr(ex);
        //    }
        //    return null;
        //}
        public List<spBatch_getListbatch_LC_v2Result> get_batch_LastCheck(string UserName)
        {
            try
            {
                return GlobalDB.DBLinq.spBatch_getListbatch_LC_v2(UserName,Global.Level_Image.ToString()).ToList();
            }
            catch (Exception ex)
            {
                logErr.AddLogErr(ex);
            }
            return null;
        }
        public string GetBatchType(string idbatch)
        {
            try
            {
                return GlobalDB.DBLinq.spBatch_GetBatchType_v2(idbatch).Select(w => w.BatchType).SingleOrDefault();
            }
            catch (Exception ex)
            {
                logErr.AddLogErr(ex);
            }
            return null;
        }
        public bool Get_ChiaUser(string idbatch)
        {
            bool chiauser = false;
            try
            {
                chiauser = (bool) GlobalDB.DBLinq.Get_ChiaUser_Batch_v2(idbatch).Select(w => w.ChiaUser).FirstOrDefault();
            }
            catch (Exception ex)
            {
                chiauser = false;
                logErr.AddLogErr(ex);
            }
            return chiauser;
        }
        public int AddBatch(LinqToSQLModels.Tb_Batch tbl_Batch)
        {
            int get_id = 0;
            DataTable dt = new DataTable();
            try
            {
                //using (var db = new DB_HIKARI_HPTEntities(""))
                //{                
                get_id = (int) GlobalDB.DBLinq.spBatch_AddBatch_v2(tbl_Batch.BatchName, tbl_Batch.PathPicture, tbl_Batch.Location, tbl_Batch.NumberImage, tbl_Batch.BatchType, tbl_Batch.ChiaUser,
                        tbl_Batch.CongKhaiBatch, tbl_Batch.Usercreate).ToList().First().Column1 ;
                //}
            }
            catch (Exception ex)
            {
                get_id = 0;
                logErr.AddLogErr(ex);
            }
            return get_id;
        }
        public void Delete_Batch(int ID_Batch, string Batch_Table)
        {
            try
            {
                GlobalDB.DBLinq.spBatch_XoaBatch_v2(ID_Batch, Batch_Table);
            }
            catch (Exception ex)
            {
                logErr.AddLogErr(ex);
            }
            
        }
        public List<spBatch_GetBatch_FULL_v2Result> getBatchFull()
        {
            try
            {
                return GlobalDB.DBLinq.spBatch_GetBatch_FULL_v2().ToList();
            }
            catch (Exception ex)
            {
                logErr.AddLogErr(ex);
            }
            return null;
        }
        public void UpdateCongKhaiBatch(int batchID, int status)
        {
            try
            {
                //using (var db = new DB_HIKARI_HPTEntities(""))
                //{
                GlobalDB.DBLinq.spBatch_UpdateCongKhaiBatch_v2(batchID, status);
                //}
            }
            catch (Exception ex)
            {
                logErr.AddLogErr(ex);
            }
        }
        public void UpdateBatchChiaUser(int batchID, int status)
        {
            try
            {
                //using (var db = new DB_HIKARI_HPTEntities(""))
                //{
                GlobalDB.DBLinq.spBatch_UpdateBatchChiaUser_v2(batchID, status);
                //}
            }
            catch (Exception ex)
            {
                logErr.AddLogErr(ex);
            }
        }
    }    
}