using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class User
    {
        private int _Id;
        private string _FirstName;
        private string _LastName;
        private string _UserName;
        private string _Password;

        public User(string UserName, string Password):this( "", "", UserName, Password)
        {

        }

        public User(string FirstName, string LastName, string UserName, string Password)
            :this(0, FirstName, LastName, UserName,  Password)
        {

        }

        public User(int Id,  string FirstName, string LastName, string UserName, string Password)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Id = Id;
        }

        public int Id
        {
            get
            {
                return _Id;
            }

            set
            {
                _Id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return _FirstName;
            }

            set
            {
                _FirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _LastName;
            }

            set
            {
                _LastName = value;
            }
        }

        public string UserName
        {
            get
            {
                return _UserName;
            }

            set
            {
                _UserName = value;
            }
        }

        public string Password
        {
            get
            {
                return _Password;
            }

            set
            {
                _Password = value;
            }
        }
    }
}
