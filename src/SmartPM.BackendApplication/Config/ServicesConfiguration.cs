using Microsoft.Extensions.DependencyInjection;
using SmartPM.Domain.Entities;
using SmartPM.Domain.Interfaces;
using SmartPM.Infra.Data.Repository;
using SmartPM.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartPM.BackendApplication.Config
{
    public static class ServicesConfiguration
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            //Category
            services.AddScoped<IBaseRepository<Category>, BaseRepository<Category>>();
            services.AddScoped<IBaseService<Category>, BaseService<Category>>();
            //Product
            services.AddScoped<IBaseRepository<Product>, BaseRepository<Product>>();
            services.AddScoped<IBaseService<Product>, BaseService<Product>>();
        }
    }
}
