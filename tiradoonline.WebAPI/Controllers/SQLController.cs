using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using tiradoonline.DataAccess.tiradoonline;


namespace tiradoonline.WebAPI.Controllers
{
    public class SQLController : Controller
    {

        private tiradoonlineDBDataContext objDB = new tiradoonlineDBDataContext();

        //public IEnumerable<Account> Get()
        //[HttpGet]
        //public JsonResult Index(string SQL)
        //public JsonResult Index()
        //{
        //    string SQL = "SELECT * FROM Users";
        //    var orsLogin = objDB.ExecuteQuery<dynamic>(SQL).ToList();
        //    //Login objmodel = new Login();

        //    return Json(orsLogin, JsonRequestBehavior.AllowGet);

        //}
    }
}