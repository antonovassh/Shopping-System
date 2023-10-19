using System;
using System.ComponentModel.DataAnnotations;

namespace Sprint16_EntityFrameworkCore.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        public List<OrderDetails>? OrderDetails { get; set; }
    }
}

