using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CA3_D10120047;
using CA3_D10120047.Controllers;
using CA3_D10120047.Tests.Fake;
using CA3_D10120047.Models;


namespace CA3_D10120047.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            var db = new FakeCA3_D10120047Db();

            db.AddSet(TestData.Business);


            HomeController controller = new HomeController(db);
            controller.ControllerContext = new FakeControllerContext();

            // Act
            ViewResult result = controller.Index() as ViewResult;
            IEnumerable<BusinessListViewModel> model = result.Model as IEnumerable<BusinessListViewModel>;


            // Assert
            Assert.AreEqual(10, model.Count());
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result.Model);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
