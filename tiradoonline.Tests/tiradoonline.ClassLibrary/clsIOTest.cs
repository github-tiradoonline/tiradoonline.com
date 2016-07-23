using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using tiradoonline.ClassLibrary;

namespace tiradoonline.Tests.tiradoonline.ClassLibrary
{
    [TestClass]
    public class clsIOTest
    {
        [TestMethod]
        public void GetSubDirectoriesList()
        {
            List<string> subDirectories = new List<string>();

            subDirectories = clsIO.GetSubDirectoriesList(@"c:\storage");

            Assert.IsTrue(true);
        }

    }
}
    