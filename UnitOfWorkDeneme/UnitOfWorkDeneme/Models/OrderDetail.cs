using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitOfWorkDeneme.Models
{
    public class OrderDetail
    {

        public int Id { get; set; }
        public int OrderId { get; set; }

        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public double Discount { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public List<Order> Orders { get; set; }
    }
}
