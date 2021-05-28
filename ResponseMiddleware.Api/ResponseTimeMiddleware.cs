using Microsoft.AspNetCore.Http;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ResponseMiddleware.Api
{
    public class ResponseTimeMiddleware
    {
        private readonly RequestDelegate _next;
        public ResponseTimeMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task InvokeAsync(HttpContext context)
        {
            var watch = new Stopwatch();
            watch.Start();
            context.Response.OnStarting(() => {
                watch.Stop();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Response time http context: " + watch.Elapsed.TotalSeconds);
                Console.WriteLine();
                Console.ResetColor();

                return Task.CompletedTask;
            });

            return _next(context);
        }
    }
}
