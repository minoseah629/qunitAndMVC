using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QUnitMvcApp.Models;

namespace QUnitMvcApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult CascadingList()
        {
            return View();
        }

        public SelectList GetCountrySelectList()
        {

            var countries = Country.GetCountries();
            return new SelectList(countries.ToArray(),
                "Code",
                "Name");
        }

        public ActionResult CountryList()
        {
            var countries = Country.GetCountries();

            if (HttpContext.Request.IsAjaxRequest())
                return Json(GetCountrySelectList(), JsonRequestBehavior.AllowGet);

            return RedirectToAction("CascadingList");
        }

        public ActionResult CityList(string ID)
        {
            string Code = ID;
            var cities = from s in City.GetCitys()
                where s.Code == Code
                select s;

            if (HttpContext.Request.IsAjaxRequest())
                return Json(new SelectList(
                    cities.ToArray(),
                    "CityID",
                "CityName")
                , JsonRequestBehavior.AllowGet);

            return RedirectToAction("CascadingList");
        }
    }
}