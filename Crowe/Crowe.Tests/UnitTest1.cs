using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Crowe.Controllers;

namespace Crowe.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new DetailsController();
            var actual = controller.GetStatusMessage();

            Assert.AreEqual("Hello World", actual);
        }
    }
}
