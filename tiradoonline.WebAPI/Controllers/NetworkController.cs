using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using tiradoonline.ClassLibrary;

namespace tiradoonline.WebAPI.Controllers
{
    public class NetworkController : Controller
    {
        // GET: Network
        [HttpPost]
        public void SMTP(string toName, string toEmail, string fromName, string fromEmail, string subject, string bodyText)
        {

            clsNetworking objNetworking = new clsNetworking();

            bool results = objNetworking.STMP(toName, toEmail, fromName, fromEmail, subject, bodyText);

            objNetworking = null;
        }
    }
}