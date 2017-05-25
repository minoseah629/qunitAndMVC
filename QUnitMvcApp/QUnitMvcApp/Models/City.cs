using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QUnitMvcApp.Models
{
    public class City
    {
        public string Code { get; set; }
        public int CityID { get; set; }
        public string CityName { get; set; }

        public static IQueryable<City> GetCitys()
        {
            return new List<City>
            {
                new City
                {
                    Code = "AU",
                    CityID=1,
                    CityName = "Perth"
                },
                new City
                {
                    Code = "AU",
                    CityID=2,
                    CityName = "Sydney"
                },
                new City
                {
                    Code = "AU",
                    CityID=3,
                    CityName = "Melbourne"
                },
                new City
                {
                    Code = "UK",
                    CityID=4,
                    CityName = "London"
                },
                new City
                {
                    Code = "UK",
                    CityID=5,
                    CityName = "Bermingham"
                },
                new City
                {
                    Code = "UK",
                    CityID=6,
                    CityName = "Manchester"
                }
            }.AsQueryable();
        }
    }
}