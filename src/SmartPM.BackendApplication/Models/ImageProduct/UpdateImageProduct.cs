using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartPM.BackendApplication.Models.ImageProduct
{
    public class UpdateImageProduct
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Path { get; set; }
    }
}
