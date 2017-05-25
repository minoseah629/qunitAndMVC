using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QUnitMvcApp.Models
{
    public class Country
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public static IQueryable<Country> GetCountries()
        {
            return new List<Country>
            {
                new Country {Code = "AU", Name = "Australia"},
                new Country {Code = "UK", Name = "United Kingdom"},

            }.AsQueryable();
        }
    }
}