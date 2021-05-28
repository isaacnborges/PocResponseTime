using System;

namespace ResponseMiddleware.Api.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }

        public Customer(Guid id, int code, string name)
        {
            Id = id;
            Code = code;
            Name = name;
        }
    }
}
