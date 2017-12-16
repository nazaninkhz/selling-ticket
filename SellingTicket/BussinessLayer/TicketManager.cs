using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;


namespace BussinessLayer
{
    public class TicketManager
    {

        public static DataTable GetAll()
        {
            return Tickets.GetAll();
        }
        public static void Add(int UserId, string FirstName, string LastName, bool IsMale, string Tell, string Address, int Orgin, int Destination, int Price)
        {
            Tickets.INSERT( UserId,  FirstName,  LastName,  IsMale,  Tell,  Address,  Orgin,  Destination,  Price);
        }
    }
}
