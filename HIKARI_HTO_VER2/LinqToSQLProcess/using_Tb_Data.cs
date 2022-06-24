using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIKARI_HTO_VER2.LinqToSQLModels;

namespace HIKARI_HTO_VER2.LinqToSQLProcess
{
    internal class using_Tb_Data
    {
        using_Tb_LogErr logErr;
        public using_Tb_Data()
        {
            logErr = new using_Tb_LogErr();
        }
        public int GetIDImage(string batchId, string tablename)
        {
            int res = 0;
            try
            {
                res =Convert.ToInt32(GlobalDB.DBLinq.spData_CheckBatch_ChiaUser_v2(batchId, tablename).Select(w => w.Row_E).FirstOrDefault().ToString());                
            }
            catch (Exception ex)
            {
                logErr.AddLogErr(ex);
            }
            return res;
        }
        public List<spData_GetImage_Check_v2Result> Get_Image_Check(string ID_Batch,string UserCheck, int Level_Image)
        {
            try
            {
                return GlobalDB.DBLinq.spData_GetImage_Check_v2(ID_Batch, UserCheck, Level_Image.ToString()).ToList();
            }
            catch (Exception ex)
            {
                logErr.AddLogErr(ex);
            }
            return null;
        }
        public  spData_Getinfo_Image_Check_v2Result Get_info_ImageCheck(string batchID, string level_image, string UserName)
        {
            spData_Getinfo_Image_Check_v2Result result = new spData_Getinfo_Image_Check_v2Result();
            try
            {
                result = GlobalDB.DBLinq.spData_Getinfo_Image_Check_v2(batchID, level_image, UserName).SingleOrDefault();
            }
            catch (Exception ex)
            {
                logErr.AddLogErr(ex);
            }
            return result;
        }

        public spData_GetInfo_MissImage_Entry_v2Result GetInforBatchForOperator(string batchID, string level_image, string level_User, string UserName, string chiaUsser)
        {
            spData_GetInfo_MissImage_Entry_v2Result result = new spData_GetInfo_MissImage_Entry_v2Result();
            try
            {
                //using (var DBLinq = new LinqToSQLModels.DBHikari_HPTDataContext(Global.ConnectionString))
                //{
                result = GlobalDB.DBLinq.spData_GetInfo_MissImage_Entry_v2(batchID, level_image, level_User, UserName, chiaUsser).SingleOrDefault();
                //}
            }
            catch (Exception ex)
            {
                logErr.AddLogErr(ex);
            }
            return result;
        }      
        public spData_InsertData_ENTRY_v2Result Entry_insertData(string ID_Image,string batchID, string DataEntry, string PairEntry, string levelimg, string Lendata, string Data_Split, string User_Name)
        {
            spData_InsertData_ENTRY_v2Result result = new spData_InsertData_ENTRY_v2Result();
            try
            {
                //using (var DBLinq = new LinqToSQLModels.DBHikari_HPTDataContext(Global.ConnectionString))
                //{
                result = GlobalDB.DBLinq.spData_InsertData_ENTRY_v2(ID_Image, batchID, DataEntry, PairEntry, levelimg, Lendata, Data_Split, User_Name).FirstOrDefault();
                //}
            }
            catch (Exception ex)
            {
                logErr.AddLogErr(ex);
            }
            return result;
        }

        public Entry_Check_ReturnBack_ImageResult InsertData_Back(string batchID,  string ID_Image, string PairEntry,  string username)
        {
            Entry_Check_ReturnBack_ImageResult result = new Entry_Check_ReturnBack_ImageResult();
            try
            {
                //using (var DBLinq = new LinqToSQLModels.DBHikari_HPTDataContext(Global.ConnectionString))
                //{
                result = GlobalDB.DBLinq.Entry_Check_ReturnBack_Image(batchID, ID_Image,   PairEntry, username).FirstOrDefault();
                //}
            }
            catch (Exception ex)
            {
                logErr.AddLogErr(ex);
            }
            return result;
        }


        public DataTable LC_GetData_batch(string IDBatch, string UserName,string level_image)
        {
            DataTable dt = new DataTable();
            try
            {
                DataSet ds = new DataSet();
                string ConnectionString = Global.ConnectionString;
                SqlConnection con = new SqlConnection(ConnectionString);
                SqlCommand cmd = new SqlCommand("LC_spData_Getdata", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 60 * 60;
                cmd.Parameters.AddWithValue("@ID_Batch", IDBatch);
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@Level_LC", level_image);                
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                dt = ds.Tables[0];
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //public string name_img (string Id_Batch, string Id_Img, string Status, string level_img)
        //{
            
        //}
    }
}
