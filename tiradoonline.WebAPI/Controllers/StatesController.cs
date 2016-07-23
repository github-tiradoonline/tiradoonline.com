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
    public class StatesController : Controller
    {
        private tiradoonlineDBDataContext objDB = new tiradoonlineDBDataContext();
        string connectionString = String.Empty;
        //HttpResponse resp = new HttpResponse();

        public StatesController()
        {
            objDB.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["tiradoonlineConnectionString"].ToString();
            connectionString = objDB.Connection.ConnectionString;
        }

        [HttpPost]
        public JsonResult Get()
        {
            List<modelStates> objmodel = new List<modelStates>();
            
            try
            {
                var orsStates = objDB.sp_States_get();

                foreach (var item in orsStates.ToList())
                {
                    objmodel.Add(new modelStates
                    {
                        StateAbbr = item.StateAbbr,
                        State = item.State
                    });
                }
            }
            catch (Exception ex)
            {

                objmodel.Add(new modelStates
                {
                    ErrorMessage = "ConnectionString : " + connectionString + " --- " + ex.ToString()
                });
            }
            return Json(objmodel, JsonRequestBehavior.AllowGet);
        }
    }
}