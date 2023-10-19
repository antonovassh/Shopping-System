using System;
using System.ComponentModel.DataAnnotations;

namespace Sprint16_EntityFrameworkCore.Models
{
    public class Customer
    {
        public Customer()
        {

        }
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Discount { get; set; }

        public List<Order>? Orders { get; set; }
    }
}

