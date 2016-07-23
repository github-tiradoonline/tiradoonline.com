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
    public class ZipCodeController : Controller
    {
        private tiradoonlineDBDataContext objDB = new tiradoonlineDBDataContext();
        string connectionString = String.Empty;

        [HttpPost]
        public JsonResult Get(string ZipCode)
        {
            List<modelZipCode> objmodel = new List<modelZipCode>();

            try
            {
                var orsZipCode = objDB.sp_ZipCode_ZipCode_get(ZipCode);

                foreach (var item in orsZipCode.ToList())
                {
                    objmodel.Add(new modelZipCode
                    {
                        Zipcode = Convert.ToDouble(item.Zipcode),
                        City = item.City,
                        State = item.State,
                        TaxRate = item.TaxRate.ToString()
                    });
                }
            }
            catch(Exception ex)
            {
                objmodel.Add(new modelZipCode
                {
                    ErrorMessage = "ConnectionString : " + connectionString + " --- " + ex.ToString()
                });
            }
            return Json(objmodel, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public JsonResult Validate(string City, string State, string ZipCode)
        {
            List<modelZipCode> objmodel = new List<modelZipCode>();

            try
            {
                var orsZipCode = objDB.sp_ZipCode_City_State_ZipCode_get(City, State, ZipCode);

                foreach (var item in orsZipCode.ToList())
                {
                    objmodel.Add(new modelZipCode
                    {
                        City = item.City,
                        State = item.State,
                        Zipcode = item.Zipcode
                    });
                }
            }
            catch(Exception ex)
            {
                objmodel.Add(new modelZipCode
                {
                    ErrorMessage = "ConnectionString : " + connectionString + " --- " + ex.ToString()
                });
            }
            return Json(objmodel, JsonRequestBehavior.AllowGet);
        }
    }
}