using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AllColumbusProduct.DAL;

namespace AllColumbusProduct.BL
{
    class ClassManagmentReport
    {
        public static DataTable displayAllPro() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("displayAllPro", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable searchForPro(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("searchForPro", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.NVarChar, search));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable displayAllIMGForPro(int ProID)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("displayAllIMGForPro", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Product_ID", SqlDbType.Int, ProID));
            DataAccessLayer.Close();
            return dt;
        }
        public static int deleteIMG(int proID)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("deleteIMG", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Pro_Image_ID", SqlDbType.Int, proID));
            DataAccessLayer.Close();
            return i;
        }
        public static int updatePro(int ProID ,string name, string barcode, string category, string country, string city, string company, string costPro, string sellgroup, string sellone, string discrp, string notePro)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("updatePro", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Product_ID", SqlDbType.Int, ProID),
                DataAccessLayer.CreateParameter("@Product_Name", SqlDbType.NVarChar, name),
                DataAccessLayer.CreateParameter("@Barcode", SqlDbType.NVarChar, barcode),
                DataAccessLayer.CreateParameter("@Category", SqlDbType.NVarChar, category),
                DataAccessLayer.CreateParameter("@Counrty", SqlDbType.NVarChar, country),
                DataAccessLayer.CreateParameter("@City", SqlDbType.NVarChar, city),
                DataAccessLayer.CreateParameter("@Company", SqlDbType.NVarChar, company),
                DataAccessLayer.CreateParameter("@Cost_Price", SqlDbType.NVarChar, costPro),
                DataAccessLayer.CreateParameter("@Selling_Price_Group", SqlDbType.NVarChar, sellgroup),
                DataAccessLayer.CreateParameter("@Selling_Price_One", SqlDbType.NVarChar, sellone),
                DataAccessLayer.CreateParameter("@Discreption", SqlDbType.NVarChar, discrp),
                DataAccessLayer.CreateParameter("@Note", SqlDbType.NVarChar, notePro));
            DataAccessLayer.Close();
            return i;

        }
        public static DataTable selectOneProID(int ProID)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectOneProID", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Product_ID", SqlDbType.Int, ProID));
            DataAccessLayer.Close();
            return dt;
        }

        public static int deletePro(int proID)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("deletePro", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Product_ID", SqlDbType.Int, proID));
            DataAccessLayer.Close();
            return i;
        }
        public static int deleteAllIMGProduct(int proID)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("deleteAllIMGProduct", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Product_ID", SqlDbType.Int, proID));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable displayNormalPro()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("displayNormalPro", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable searchForNormalPro(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("searchForNormalPro", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.NVarChar, search));
            DataAccessLayer.Close();
            return dt;
        }
    }
}
