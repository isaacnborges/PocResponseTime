using Microsoft.AspNetCore.Mvc;
using Products.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Products.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static readonly List<Product> _products = new();

        public ProductsController()
        {
            for (int i = 1; i <= 10; i++)
            {
                _products.Add(new Product(Guid.NewGuid(), i, $"product_{i}", i));
            }
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
            var products = _products.OrderBy(x => x.Code).ToList();
            Thread.Sleep(5000);
            return Ok(products);
        }
    }
}
