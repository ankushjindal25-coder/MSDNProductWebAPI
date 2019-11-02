using MSDNProductWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MSDNProductWebApi.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[] {
            new Product(){ Id=1,Name="Tomato Soup",Price = 50, Category= "Grocery" },
            new Product(){ Id=2,Name="Yo Yo",Price = 150, Category= "Toy" },
            new Product(){ Id=3,Name="OnePlus 6 T",Price = 50, Category= "Mobile" }
        };

        public IEnumerable<Product> GetAllProducts() {
            return products.ToList();
        }

        public IHttpActionResult GetProduct(int id) {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null) { return NotFound(); }
            
            return Ok(product);
        }
    }
}
