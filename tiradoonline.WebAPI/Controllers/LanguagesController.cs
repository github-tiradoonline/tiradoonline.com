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
    public class LanguagesController : Controller
    {
        private tiradoonlineDBDataContext objDB = new tiradoonlineDBDataContext();
        string connectionString = String.Empty;

        [HttpPost]
        public JsonResult Get()
        {
            List<modelLanguages> objmodel = new List<modelLanguages>();

            try
            {
                var orsLanguages = objDB.sp_Languages_get();

                foreach (var item in orsLanguages.ToList())
                {
                    objmodel.Add(new modelLanguages
                    {
                        Language = item.Language
                    });
                }
            }
            catch (Exception ex)
            {

                objmodel.Add(new modelLanguages
                {
                    ErrorMessage = "ConnectionString : " + connectionString + " --- " + ex.ToString()
                });
            }
            return Json(objmodel, JsonRequestBehavior.AllowGet);
        }
    }
}