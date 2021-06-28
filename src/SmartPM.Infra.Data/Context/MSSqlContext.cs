using Microsoft.EntityFrameworkCore;
using SmartPM.Domain.Entities;
using SmartPM.Infra.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPM.Infra.Data.Context
{
    public class MSSqlContext : DbContext
    {
        public MSSqlContext(DbContextOptions<MSSqlContext> options) 
            : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .Entity<Category>(new CategoryMap().Configure);
            modelBuilder
                .Entity<Product>(new ProductMap().Configure);
        }

    }
}
