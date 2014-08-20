using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CalReplyModels;

namespace WebApplication1.Controllers
{
    [RoutePrefix("api/products")]
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Tomoto Soup", Category = "Groceries", Price = 1},
            new Product { Id = 2, Name = "Yo Yo", Category = "Toys", Price = 1},
            new Product { Id = 3, Name = "Ting Tang", Category = "Hardware", Price = 1}
        };

        //GET  /api/products
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        //GET /api/products/1
        public Product GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            //if (product == null)
            //{
            //    return NotFound();
            //}
            //return Ok(product);
            return product;
        }
    }
}
