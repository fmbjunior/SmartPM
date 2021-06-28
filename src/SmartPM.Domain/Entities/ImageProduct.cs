using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPM.Domain.Entities
{
    public class ImageProduct: BaseEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string Path { get; set; }
    }
}
