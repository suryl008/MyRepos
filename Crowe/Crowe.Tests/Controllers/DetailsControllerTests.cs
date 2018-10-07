using Crowe.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowe.Tests.Controllers
{
    [TestClass]
    public class DetailsControllerTests
    {
        private DetailsController controller;

        [TestInitialize]
        public void TestInitialize()
        {
           
        }

        [TestMethod]
        public void TestHeartbeatEndpoint_Succeeds()
        {
            controller = new DetailsController();
            var actual = controller.GetStatusMessage();

            Assert.AreEqual("Hello World", actual);
        }
    }
}
