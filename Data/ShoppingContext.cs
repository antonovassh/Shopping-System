using System;
using Sprint16_EntityFrameworkCore.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sprint16_EntityFrameworkCore.Data
{

    public class ShoppingContext : DbContext
    {
        public ShoppingContext()
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<SuperMarkets> SuperMarkets { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }

        public ShoppingContext(DbContextOptions<ShoppingContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("ShoppingDatabase");
            }
        }
    }
}

