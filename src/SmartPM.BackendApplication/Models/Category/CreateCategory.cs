using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartPM.BackendApplication.Models.Category
{
    public class CreateCategory
    {
        public string Name { get; set; }
        public int? ParentId { get; set; }
    }
}
