using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class Users
    {
        static dbConnection con;
        static Users()
        {
            con = new dbConnection();
        }


        public static DataRow GetUserByUserName(string Username)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@UserName", Username);
            DataTable table = con.executeSelectQuery("SELECT * FROM tbl_Users WHERE UserName=@UserName", parameters);
            if (table.Rows.Count > 0)
                return table.Rows[0];
            return null;
        }

        public static bool Login(string userName, string Password)
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@username", userName);
            parameters[1] = new SqlParameter("@password", Password);
            DataTable table = con.executeSelectQuery("SELECT * FROM tbl_Users WHERE UserName=@username AND Password=@password", parameters);
            if (table.Rows.Count > 0)
                return true;
            return false;
        }
    }
}
