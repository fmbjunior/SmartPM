using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPM.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal SalePrice { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        //public List<ImageProduct> Images { get; set; }
    }
}
