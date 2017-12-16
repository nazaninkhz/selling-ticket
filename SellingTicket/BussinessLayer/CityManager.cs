using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;

namespace BussinessLayer
{
    public static class CityManager
    {
        public static List<City> GetAll()
        {
            List<City> lstCities = new List<City>();
            DataTable table = Cities.GetAll();
            if (table != null && table.Rows.Count > 0)
            {
                foreach (DataRow myRow in table.Rows)
                {
                    City city = new City(Convert.ToInt32(myRow["Id"].ToString()), myRow["Name"].ToString());
                    lstCities.Add(city);
                }

                return lstCities;
            }
            else
                return null;
        }
    }
}
