using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CalReplyModels;
using System.Threading.Tasks;

namespace CalReplyApi.Controllers
{
    /// <summary>
    /// Product controller - product details
    /// </summary>
    [RoutePrefix("api/products")]
    public class ProductsController : ApiController
    {
        List<Product> products = new List<Product>();        
        
        /// <summary>
        /// ctor
        /// </summary>
        public ProductsController() {
            products.Add(new Product { Id = 1, Name = "Tomoto Soup", Category = "Groceries", Price = 1 });
            products.Add(new Product { Id = 2, Name = "Yo Yo", Category = "Toys", Price = 2 });
            products.Add(new Product { Id = 3, Name = "Ting Tang", Category = "Hardware", Price = 3 });
            products.Add(new Product { Id = 4, Name = "Pizza", Category = "Food", Price = 4 });
        }

        public ProductsController(List<Product> products)
        {
            this.products = products;
        }

        //GET  /api/products
        /// <summary>
        /// Get all products synchronously
        /// </summary>
        /// <returns>list of products</returns>
        public IEnumerable<Product> GetAllProducts()
        {
            if (products == null)
            {
                var message = string.Format("No Products found");
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.NotFound, message)); // http status code 404
            }
            else
            {
                return products;
            }
        }
           
    }
}
