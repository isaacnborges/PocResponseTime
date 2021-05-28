using Microsoft.AspNetCore.Mvc;
using ResponseMiddleware.Api.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ResponseMiddleware.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        protected readonly ProductApiClient _client;

        public ProductsController(ProductApiClient client)
        {
            _client = client;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _client.GetProducts();
            var products = await response.Content.ReadAsAsync<List<Product>>();

            return Ok(products);
        }
    }
}
