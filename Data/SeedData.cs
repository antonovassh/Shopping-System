using Microsoft.EntityFrameworkCore;
using Sprint16_EntityFrameworkCore.Data;
using Sprint16_EntityFrameworkCore.Models;
using System;
using System.Linq;

namespace Sprint16_EntityFrameworkCore.Data
{

    public static class SeedData
    {
        public static void Initialize(ShoppingContext context)
        {
            context.Database.Migrate();

            if (context.Products.Any() || context.Customers.Any() || context.SuperMarkets.Any())
            {
                return;
            }

            var products = new Product[]
            {
            new Product { Name = "Product1", Price = 10.99f },
            new Product { Name = "Product2", Price = 19.99f },

            };
            context.Products.AddRange(products);

            var customers = new Customer[]
            {
            new Customer { FirstName = "John", LastName = "Doe", Address = "123 Main St", Discount = 5 },
            new Customer { FirstName = "Jane", LastName = "Smith", Address = "456 Elm St", Discount = 10 },

            };
            context.Customers.AddRange(customers);

            var supermarkets = new SuperMarkets[]
            {
            new SuperMarkets { Name = "Supermarket1", Address = "789 Oak St" },
            new SuperMarkets { Name = "Supermarket2", Address = "101 Pine St" },

            };
            context.SuperMarkets.AddRange(supermarkets);

            context.SaveChanges();
        }
    }
}