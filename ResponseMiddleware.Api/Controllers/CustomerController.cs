using Microsoft.AspNetCore.Mvc;
using ResponseMiddleware.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ResponseMiddleware.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private static readonly List<Customer> _customers = new();

        public CustomerController()
        {
            for (int i = 1; i <= 10; i++)
            {
                _customers.Add(new Customer(Guid.NewGuid(), i, $"Customer - {i}"));
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _customers.OrderBy(x => x.Code).ToList();
            return Ok(products);
        }
    }
}
