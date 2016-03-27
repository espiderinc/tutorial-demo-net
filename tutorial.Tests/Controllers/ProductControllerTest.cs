using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using tutorial.Controllers;
using System.Collections.Generic;
using System.Linq;

namespace tutorial.Tests.Controllers
{
    [TestClass]
    public class ProductControllerTest
    {
        [TestMethod]
        public void GetAll()
        {
            // Arrange
            ProductController controller = new ProductController();

            // Act
            IQueryable<Product> result = controller.Get();
            
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(77, result.Count());
        }
    }
}
