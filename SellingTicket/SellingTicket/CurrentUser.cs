using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer;

namespace SellingTicket
{
    static class CurrentUser
    {
        static private User _user;

        static public User User
        {
            get
            {
                return _user;
            }

            set
            {
                _user = value;
            }
        }
    }
}
