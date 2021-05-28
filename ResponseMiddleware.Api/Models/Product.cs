using System;

namespace ResponseMiddleware.Api.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Product(Guid id, int code, string description, decimal price)
        {
            Id = id;
            Code = code;
            Description = description;
            Price = price;
        }
    }
}