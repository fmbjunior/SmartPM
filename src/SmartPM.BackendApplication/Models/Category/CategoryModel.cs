using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartPM.BackendApplication.Models.Category
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CategoryModel Parent { get; set; }
        public ICollection<SubcategoryModel> SubCategories { get; } = new List<SubcategoryModel>();
    }
}
