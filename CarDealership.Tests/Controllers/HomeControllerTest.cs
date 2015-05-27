using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarDealership;
using CarDealership.Controllers;

namespace CarDealership.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            DealershipController controller = new DealershipController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
