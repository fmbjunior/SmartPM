using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPM.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public Category Parent { get; set; }
        public int? ParentId { get; set; }
        public ICollection<Category> SubCategories { get; } = new List<Category>();
        public ICollection<Product> Products { get; } = new List<Product>();
    }
}
