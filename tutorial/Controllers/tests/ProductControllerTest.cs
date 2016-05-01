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

        
        [TestMethod]
        public void GetById()
        {
            // Arrange
            ProductController controller = new ProductController();

            // Act
            Product product = controller.Get(5);

            // Assert
            Assert.IsNotNull(product);
            Assert.AreEqual("Chef Anton's Gumbo Mix", product.ProductName);
        }
        
    }
}
