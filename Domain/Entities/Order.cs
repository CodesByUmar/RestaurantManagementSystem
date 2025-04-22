using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int MenuId { get; set; }
        public Menu Menu { get; set; } = null!;
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
