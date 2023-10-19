using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sprint16_EntityFrameworkCore.Models
{
    public class Order
    {
        public Order()
        {

        }
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int SupermarketId { get; set; }
        public DateTime OrderDate { get; set; }

        [ForeignKey("CustomerId")]
        public Customer? Customer { get; set; }

        [ForeignKey("SupermarketId")]
        public SuperMarkets? SuperMarkets { get; set; }
        public List<OrderDetails>? OrderDetails { get; set; }
    }
}

