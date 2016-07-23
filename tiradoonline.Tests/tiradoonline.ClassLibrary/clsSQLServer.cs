using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using tiradoonline.ClassLibrary;

namespace tiradoonline.Tests.tiradoonline.ClassLibrary
{
   [TestClass]
    public class clsSQLServer
    {
        //private string SQLServerName = @".\SQL2K8";
        //private string SQLServerDatabaseName = "tiradoonline";
        //private string SQLUserName = "tiradoonline_user";
        //private string SQLPassword = "Sixpak141414";
        //private string OutputDirectory = @"C:\Storage\www\maninfosys.com\intranet.maninfosys.com\sql\Intranet";

        private string SQLServerName = @".\SQL2K8";
        private string SQLServerDatabaseName = "Intranet";
        private string SQLUserName = "intranet_user";
        private string SQLPassword = "intranet";
        private string OutputDirectory = @"c:\sql";

        [Ignore]
        [TestMethod]
        public void ExportSQLTablesToExcel()
        {
            clsSQLServer objSQLServer = new clsSQLServer();
            objSQLServer.SQLServerName = this.SQLServerName;
            objSQLServer.SQLServerDatabaseName = this.SQLServerDatabaseName;
            objSQLServer.SQLUserName = this.SQLUserName;
            objSQLServer.SQLPassword = this.SQLPassword;
            objSQLServer.OutputDirectory = this.OutputDirectory;
            //objSQLServer.ExportTablesToExcel();
            //Assert.IsFalse(model.Territories.Count == 2);
        }

        [TestMethod]
        public void ExportSQLStoredProceduresToExcel()
        {
            clsSQLServer objSQLServer = new clsSQLServer();
            objSQLServer.SQLServerName = this.SQLServerName;
            objSQLServer.SQLServerDatabaseName = this.SQLServerDatabaseName;
            objSQLServer.SQLUserName = this.SQLUserName;
            objSQLServer.SQLPassword = this.SQLPassword;
            objSQLServer.OutputDirectory = this.OutputDirectory;
            //objSQLServer.ExportStoredProceduresToExcel();
            //Assert.IsFalse(model.Errored);
        }
    }
}
