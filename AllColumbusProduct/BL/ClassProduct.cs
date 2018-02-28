using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AllColumbusProduct.DAL;

namespace AllColumbusProduct.BL
{
    class ClassProduct
    {
        public static int insertPro(string name,string barcode,string category,string country,string city,string company,string costPro,string sellgroup,string sellone,string discrp,string notePro) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("insertPro", CommandType.StoredProcedure,
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
        public static DataTable selectOnePro(string barcode) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectOnePro", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@barcode", SqlDbType.NVarChar, barcode));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable LastPro() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("LastPro", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static int insertIMG(byte[] img, int proID) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("insertIMG", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Pro_Image", SqlDbType.Image, img),
                DataAccessLayer.CreateParameter("@Product_ID", SqlDbType.Int, proID));
            DataAccessLayer.Close();
            return i;
        }
    }
}
