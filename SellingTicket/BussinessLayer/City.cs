using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class City
    {
        private int _Id;
        private string _Name;

        public City(string name):this(0,name)
        {

        }
        public City(int id, string name)
        {
            Id = id;
            Name = name;
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

        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                _Name = value;
            }
        }
    }
}
