using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

using tiradoonline.ClassLibrary;

namespace tiradoonline.WebAPI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Application_Error(Object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();

            clsNetworking objSMTP = new clsNetworking();
            bool results = objSMTP.STMP("Theodore Tirado", "logs@tiradoonline.com", "Theodore Tirado", "developer@tiradoonline.com", Request.ServerVariables["SERVER_NAME"].ToString() + " - ERROR", ex.ToString());
            objSMTP = null;

        }
    }
}
