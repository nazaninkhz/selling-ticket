using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DataAccess
{
    public static class Cities
    {

        static dbConnection con;
        static Cities()
        {
            con = new dbConnection();
        }


        public static DataTable GetAll()
        {
            DataTable table = con.executeSelectQuery("SELECT * FROM tbl_Cities");
            if (table.Rows.Count > 0)
                return table;
            return null;
        }
    }
}
