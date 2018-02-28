using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AllColumbusProduct.DAL;

namespace AllColumbusProduct.BL
{
    class ClassUsers
    {
        public static DataTable sp_SelectAllUser()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_SelectAllUser", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static int sp_changepassword(string newpass, int id)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_changepassword", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@newPass", SqlDbType.NVarChar, newpass),
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;
        }

        //************** BackUp *************************

        public static void Back_up(string Path)
        {
            DataAccessLayer.Open();
            string Query = string.Format("Backup Database AllProducts to Disk = '{0}'", Path);
            DataAccessLayer.ExecuteNonQuery(Query, CommandType.Text);
            DataAccessLayer.Close();

        }
    }
}
