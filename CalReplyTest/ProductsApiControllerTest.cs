using System;
using CalReplyModels;
using CalReplyApi.Controllers;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CalReplyTest
{
    /// <summary>
    /// Test class for productcontroller webapi
    /// </summary>
    [TestClass]
    public class ProductsApiControllerTest
    {
        [TestMethod]
        public void TestGetAllProducts()
        {
            var testProducts = GetTestProducts();
            var controller = new ProductsController(testProducts);
            var result = controller.GetAllProducts() as List<Product>;
            Assert.AreEqual(testProducts.Count, result.Count);
        }

        [TestMethod]
        public void TestVerifyProducts()
        {
            var testProducts = GetTestProducts();
            var controller = new ProductsController(testProducts);
            var result = controller.GetAllProducts() as List<Product>;
            Assert.AreEqual(testProducts[1].Id, result[1].Id);
            Assert.AreEqual(testProducts[1].Name, result[1].Name);
            Assert.AreEqual(testProducts[1].Category, result[1].Category);
            Assert.AreEqual(testProducts[1].Price, result[1].Price);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void TestGetAllProductsExceptionCase()
        {
            var controller = new ProductsController(null);
            var result = controller.GetAllProducts() as List<Product>;
        }

        private List<Product> GetTestProducts()
        {
            var testProducts = new List<Product>();
            testProducts.Add(new Product { Id = 1, Name = "Demo1", Category = "Category1", Price = 1 });
            testProducts.Add(new Product { Id = 2, Name = "Demo2", Category = "Category2", Price = 2 });
            testProducts.Add(new Product { Id = 3, Name = "Demo3", Category = "Category3", Price = 3 });
            testProducts.Add(new Product { Id = 4, Name = "Demo4", Category = "Category4", Price = 4 });

            return testProducts;
        }
    }
}
