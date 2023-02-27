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
        public int GetIDImage(int batchId, string tablename)
        {
            int res = 0;
            try
            {
                res =Convert.ToInt32(GlobalDB.DBLinq.spData_CheckBatch_ChiaUser_v2(batchId).Select(w => w.Column1).FirstOrDefault().ToString());                
            }
            catch (Exception ex)
            {
                logErr.AddLogErr(ex);
            }
            return res;
        }
        public List<spData_GetImage_Check_v2Result> Get_Image_Check(int ID_Batch,string UserCheck, int Level_Image)
        {
            try
            {
                return GlobalDB.DBLinq.spData_GetImage_Check_v2(ID_Batch, UserCheck, Level_Image).ToList();
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

        public spData_GetInfo_MissImage_Entry_v2Result GetInforBatchForOperator(int batchID, int level_image, int level_User, string UserName, int chiaUsser)
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
        //public spData_InsertData_ENTRY_v2Result Entry_insertData(string ID_Image,string batchID, string DataEntry, string PairEntry, string levelimg, string Lendata, string Data_Split, string User_Name)
        //{
        //    spData_InsertData_ENTRY_v2Result result = new spData_InsertData_ENTRY_v2Result();
        //    try
        //    {
        //        //using (var DBLinq = new LinqToSQLModels.DBHikari_HPTDataContext(Global.ConnectionString))
        //        //{
        //        result = GlobalDB.DBLinq.spData_InsertData_ENTRY_v2(ID_Image, batchID, DataEntry, PairEntry, levelimg, Lendata, Data_Split, User_Name).FirstOrDefault();
        //        //}
        //    }
        //    catch (Exception ex)
        //    {
        //        logErr.AddLogErr(ex);
        //    }
        //    return result;
        //}
        public spEntry_Submit_New_v3Result Entry_insertData(int ID_Image, int batchID, string DataEntry, int PairEntry, int levelimg, int Lendata, string Data_Split, string User_Name)
        {
            spEntry_Submit_New_v3Result result = new spEntry_Submit_New_v3Result();
            try
            {
                //using (var DBLinq = new LinqToSQLModels.DBHikari_HPTDataContext(Global.ConnectionString))
                //{
                result = GlobalDB.DBLinq.spEntry_Submit_New_v3(ID_Image, batchID, DataEntry, PairEntry, levelimg, Lendata, Data_Split, User_Name).FirstOrDefault();
                //}
            }
            catch (Exception ex)
            {
                logErr.AddLogErr(ex);
            }
            return result;
        }

        public Entry_Check_ReturnBack_ImageResult InsertData_Back(int batchID,  int ID_Image, int PairEntry,  string username)
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


        public DataTable LC_GetData_batch(int IDBatch, string UserName,int level_image)
        {
            DataTable dt = new DataTable();            
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("NameImage", typeof(string));
            dt.Columns.Add("Content_E1", typeof(string));
            dt.Columns.Add("Content_E2", typeof(string));
            dt.Columns.Add("Content_Check", typeof(string));
            dt.Columns.Add("Content_LC", typeof(string));
            try
            {
                var infoData_LC = GlobalDB.DBLinq.LC_spData_Getdata(IDBatch, UserName, level_image).OrderBy(x => x.ID).ToList();
                if (infoData_LC != null)
                {
                    if (infoData_LC.Count() > 0)
                    {
                        foreach (var item in infoData_LC)
                        {
                            DataRow dtr = dt.NewRow();                            
                            dtr["ID"] = item.ID;
                            dtr["NameImage"] = item.NameImage;
                            dtr["Content_E1"] = item.Content_E1;
                            dtr["Content_E2"] = item.Content_E2;
                            dtr["Content_Check"] = item.Content_Check;
                            dtr["Content_LC"] = item.Content_LC;
                            dt.Rows.Add(dtr);
                        }
                        dt.DefaultView.Sort = "ID";
                        dt = dt.DefaultView.ToTable();
                    }
                }
                return dt;
            }
            catch
            {
                return dt;                
            }
            //DataTable dt = new DataTable();
            //try
            //{
            //    DataSet ds = new DataSet();
            //    string ConnectionString = Global.ConnectionString;
            //    SqlConnection con = new SqlConnection(ConnectionString);
            //    SqlCommand cmd = new SqlCommand("LC_spData_Getdata", con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.CommandTimeout = 60 * 60;
            //    cmd.Parameters.AddWithValue("@ID_Batch", IDBatch);
            //    cmd.Parameters.AddWithValue("@UserName", UserName);
            //    cmd.Parameters.AddWithValue("@Level_LC", level_image);                
            //    SqlDataAdapter da = new SqlDataAdapter();
            //    da.SelectCommand = cmd;
            //    da.Fill(ds);
            //    dt = ds.Tables[0];
            //    return dt;
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
        }

        //public string name_img (string Id_Batch, string Id_Img, string Status, string level_img)
        //{
            
        //}
    }
}
