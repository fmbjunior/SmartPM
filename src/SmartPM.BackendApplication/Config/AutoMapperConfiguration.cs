using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using SmartPM.BackendApplication.Models.Category;
using SmartPM.BackendApplication.Models.Product;
using SmartPM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartPM.BackendApplication.Config
{
    public static class AutoMapperConfiguration
    {
        public static void AddAutoMapperServices(this IServiceCollection services)
        {
            services.AddSingleton(new MapperConfiguration(config =>
            {
                //Category
                config.CreateMap<CreateCategory, Category>();
                config.CreateMap<UpdateCategory, Category>();
                config.CreateMap<Category, CategoryModel>();
                config.CreateMap<Category, SubcategoryModel>();

                //Product
                config.CreateMap<CreateProduct, Product>();
                config.CreateMap<UpdateProduct, Product>();
                config.CreateMap<Product, ProductModel>();
            }).CreateMapper());
        }
    }
}
