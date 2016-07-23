using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tiradoonline.ClassLibrary
{
    public class clsConfiguration
    {

        public static string AdministratorName
        {
            get
            {
                return @"Theodore Tirado";
            }
        }
        public static string AdministratorEmail
        {
            get
            {
                return @"intranet@tiradoonline.com";
            }
        }

        public static string LogsEmail
        {
            get
            {
                return @"logs@tiradoonline.com";
            }
        }

        // SQL 
        public static string SQLConnectionString
        {
            get
            { 
                return @".\SQL2K14;Initial Catalog=tiradoonline;Persist Security Info=True;User ID=tiradoonline_user;Password=Sixpak141414";
            }
        }

        // SMTP
        public static string STMPServerHost
        {
            get
            {
                return "smtp.tiradoonline.com";
            }
        }
        public static int STMPServerPort
        {
            get
            {
                return 587;
            }
        }
        public static string STMPServerUserName
        {
            get
            {
                return "intranet@tiradoonline.com";
            }
        }

        public static string STMPServerPassword
        {
            get
            {
                return "sixpak1414";
            }
        }

        public clsConfiguration()
        {
        }
    }
}
