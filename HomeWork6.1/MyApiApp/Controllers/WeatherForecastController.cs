using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MyApiApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Price = 10.0 },
                new Product { Id = 2, Name = "Product 2", Price = 20.0 },
                new Product { Id = 3, Name = "Product 3", Price = 30.0 }
            };

            return products;
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}