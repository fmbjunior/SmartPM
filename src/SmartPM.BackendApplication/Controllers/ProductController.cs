using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartPM.BackendApplication.Models.Product;
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
    public class ProductController : BaseController<ProductController>
    {
        private IBaseService<Product> _baseProductService;
        public ProductController(IBaseService<Product> baseProductService)
        {
            _baseProductService = baseProductService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateProduct product)
        {
            if (product == null)
                return NotFound();

            return Execute(() => _baseProductService.Add<CreateProduct, ProductModel, ProductValidator>(product).Id); ;
        }

        [HttpPut]
        public IActionResult Update([FromBody] UpdateProduct product)
        {
            if (product == null)
                return NotFound();

            return Execute(() => _baseProductService.Update<UpdateProduct, ProductModel, ProductValidator>(product));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id == 0)
                return NotFound();

            Execute(() =>
            {
                _baseProductService.Delete(id);
                return true;
            });

            return new NoContentResult();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Execute(() => _baseProductService.Get<ProductModel>());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id == 0)
                return NotFound();

            return Execute(() => _baseProductService.GetById<ProductModel>(id));
        }
    }
}
