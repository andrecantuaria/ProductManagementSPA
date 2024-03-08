using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductManagementSPA.Models
{
    public class ProductVM
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string Category { get; set; }
        public string Supplier { get; set; }
    }
}