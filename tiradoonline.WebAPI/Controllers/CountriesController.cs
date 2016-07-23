using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using tiradoonline.DataAccess.tiradoonline;
using tiradoonline.DataAccess.tiradoonline.Models;

namespace tiradoonline.WebAPI.Controllers
{
    public class CountriesController : Controller
    {
        private tiradoonlineDBDataContext objDB = new tiradoonlineDBDataContext();
        string connectionString = String.Empty;

        [HttpPost]
        public JsonResult Get()
        {
            List<modelCountries> objmodel = new List<modelCountries>();

            try
            {
                var orsCountries = objDB.sp_Countries_get();

                foreach (var item in orsCountries.ToList())
                {
                    objmodel.Add(new modelCountries
                    {
                        CountryAbbr = item.CountryAbbr,
                        Country = item.Country
                    });
                }
            }
            catch (Exception ex)
            {

                objmodel.Add(new modelCountries
                {
                    ErrorMessage = "ConnectionString : " + connectionString + " --- " + ex.ToString()
                });
            }
            return Json(objmodel, JsonRequestBehavior.AllowGet);
        }
    }
}