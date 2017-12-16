using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BussinessLayer
{
    public static class UserManager
    {
        public static User GetUserByUserName(string UserName)
        {
            DataRow myRow =  Users.GetUserByUserName(UserName);
            if (myRow == null)
                return null;

            User user = new BussinessLayer.User(Convert.ToInt32(myRow["Id"].ToString()), myRow["FirstName"].ToString()
                , myRow["LastName"].ToString(), myRow["UserName"].ToString(), myRow["Password"].ToString());
            return user;
        }
    }
}
