using Crowe.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Controllers
{
    [TestClass]
    public class DetailsControllerTests
    {
        private DetailsController controller;

        [TestInitialize]
        public void Initialize()
        {
            controller = new DetailsController();
        }

        [TestMethod]
        public void Call_Heartbeat_Endpoint_Succeed()
        {
            Assert.AreEqual("Hello World", controller.GetStatusMessage());
        }
    }
}
