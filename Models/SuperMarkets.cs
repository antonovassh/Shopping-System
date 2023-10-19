using System;
using System.ComponentModel.DataAnnotations;

namespace Sprint16_EntityFrameworkCore.Models
{
    public class SuperMarkets
    {
        public SuperMarkets()
        {

        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public List<Order>? Orders { get; set; }

    }
}

