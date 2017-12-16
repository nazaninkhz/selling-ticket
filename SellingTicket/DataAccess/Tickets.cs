using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace DataAccess
{
    public static class Tickets
    {
        static dbConnection con;
        static Tickets()
        {
            con = new dbConnection();
        }


        public static DataTable GetAll()
        {
            DataTable table = con.executeSelectQuery(@"select tbl_People.FirstName+ ' ' +tbl_People.LastName 'نام و نام خانوادگی مسافر', tbl_Users.FirstName + ' ' + tbl_Users.LastName 'نام و نام خانوادگی کاربر'
                                                    , tbl_origin.Name 'مبدا', tbl_destination.Name 'مقصد', tbl_Sells.Price 'قیمت' from tbl_Sells
                                                    INNER JOIN tbl_Users on (tbl_Users.Id = tbl_Sells.UserId)
                                                    INNER JOIN tbl_People on (tbl_People.Id = tbl_Sells.PersonId)
                                                    INNER JOIN tbl_Cities tbl_origin on(tbl_origin.Id = tbl_Sells.Origin) 
                                                    INNER JOIN tbl_Cities tbl_destination on (tbl_destination.Id = tbl_Sells.Destination)");
            if (table.Rows.Count > 0)
                return table;
            return null;
        }

        public static void INSERT(int UserId, string FirstName, string LastName, bool IsMale, string Tell, string Address, int Orgin, int Destination, int Price)
        {

            SqlParameter[] parameters = new SqlParameter[9];
            parameters[0] = new SqlParameter("@FirstName", FirstName);
            parameters[1] = new SqlParameter("@LastName", LastName);
            parameters[2] = new SqlParameter("@IsMale", IsMale);
            parameters[3] = new SqlParameter("@Tell", Tell);
            parameters[4] = new SqlParameter("@Address", Address);
            parameters[5] = new SqlParameter("@UserId", UserId);
            parameters[6] = new SqlParameter("@Origin", Orgin);
            parameters[7] = new SqlParameter("@Destination", Destination);
            parameters[8] = new SqlParameter("@Price", Price);
            con.executeQuery(@"            DECLARE @personId int
                    INSERT INTO tbl_people
                    VALUES(@FirstName, @LastName, @IsMale, @Tell, @Address)
                    SET @personId =  @@IDENTITY
                    INSERT INTO tbl_Sells
                    VALUES(@UserId, @PersonId, @Origin, @Destination, @Price)", parameters);

        }

    }
}
