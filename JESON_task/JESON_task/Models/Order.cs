using System;
using System.Collections.Generic;
using System.Text;

namespace JESON_task.Models
{
   public class Order
    {
        public int Id { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}
