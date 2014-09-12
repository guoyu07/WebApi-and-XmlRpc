using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductsApp.Models;

namespace ProductsApp.Controllers
{
    public class ProductController : ApiController
    {
        // initialise some products
        Product[] products = new Product[]
        {
            new Product{ Id = 1, Category = "Groceries", Name = "Tomato Soup", Price = 1},
            new Product{ Id = 2, Category = "Toys", Name = "Vibrator", Price = 35.69M},
            new Product{ Id = 3, Category = "Hardware", Name = "Hammer", Price = 6M}
        };

        /// <summary>
        /// returns all products
        /// </summary>
        /// <returns>Products, in IEnumerable format</returns>
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        /// <summary>
        /// Returns a specific product
        /// </summary>
        /// <param name="id"> the id of the product</param>
        /// <returns>The Product</returns>
        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
