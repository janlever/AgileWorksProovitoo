using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TodoApi.Controllers;

namespace Test.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void TestConfirmationView()
        {
            var controller = new HomeController();
            var result = controller.Confirmation(2) as ViewResult;
            Assert.AreEqual("Confirmation", result.ViewName);

        }
    }
}