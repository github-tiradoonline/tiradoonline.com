using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using tiradoonline.ClassLibrary;
using tiradoonline.DataAccess;
using tiradoonline.WebAPI.Controllers;
using tiradoonline.InterviewQuestionsAnswers;
using tiradoonline.Models;

namespace tiradoonline.Tests.tiradoonline.ClassLibrary
{
    [Ignore]
    [TestClass]
    public class clsNetworkingTests
    {
        [Ignore]
        [TestMethod]
        public void SendEmail()
        {
            try
            {
                NetworkController objNetworkController = new NetworkController();

                objNetworkController.SMTP("Theodore Tirado", "intranet@tiradoonline.com", "Theodore Tirado", "intranet@tiradoonline.com", "test subject", "test body text");

                objNetworkController = null;
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                string errorMesssage = ex.ToString();

                Assert.IsTrue(false);
            }

        }

    }
}
