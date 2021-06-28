using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartPM.BackendApplication.Models.Product
{
    public class CreateProduct
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal SalePrice { get; set; }
        public int CategoryId { get; set; }
    }
}
