using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartPM.BackendApplication.Models;
using SmartPM.BackendApplication.Models.Category;
using SmartPM.Domain.Entities;
using SmartPM.Domain.Interfaces;
using SmartPM.Service.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartPM.BackendApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : BaseController<CategoryController>
    {
        private IBaseService<Category> _baseCategoryService;

        public CategoryController(IBaseService<Category> baseCategoryService)
        {
            _baseCategoryService = baseCategoryService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateCategory category)
        {
            if (category == null) 
                return NotFound();

            return Execute(() => _baseCategoryService.Add<CreateCategory, CategoryModel, CategoryValidator>(category).Id); ;
        }

        [HttpPut]
        public IActionResult Update([FromBody] UpdateCategory category)
        {
            if (category == null)
                return NotFound();
            
            return Execute(() => _baseCategoryService.Update<UpdateCategory, CategoryModel, CategoryValidator>(category));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id == 0)
                return NotFound();

            Execute(() =>
            {
                _baseCategoryService.Delete(id);
                return true;
            });

            return new NoContentResult();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Execute(() => _baseCategoryService.Get<CategoryModel>());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id == 0)
                return NotFound();

            return Execute(() => _baseCategoryService.GetById<CategoryModel>(id));
        }
    }
}
