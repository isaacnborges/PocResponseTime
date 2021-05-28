using Microsoft.Extensions.Configuration;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ResponseMiddleware.Api
{
    public class ProductApiClient
    {
        protected readonly HttpClient _client;
        protected readonly IConfiguration _configuration;

        public ProductApiClient(HttpClient client, IConfiguration configuration)
        {
            _client = client;
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            _configuration = configuration;
        }

        public async Task<HttpResponseMessage> GetProducts()
        {
            var watch = new Stopwatch();
            watch.Start();
            var response = await _client.GetAsync(_configuration.GetSection("UrlApi").Value);
            watch.Stop();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Response time product api: " + watch.Elapsed.TotalSeconds);
            Console.WriteLine();
            Console.ResetColor();

            return response;
        }
    }
}