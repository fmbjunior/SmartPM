using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartPM.Domain.Entities;
using System;

namespace SmartPM.Infra.Data.Mapping
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(typeof(Product).Name);
            
            builder.HasKey(p => p.Id);
            
            builder.Property(p => p.Name)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("VARCHAR(100)");

            builder.Property(p => p.SalePrice)
                .HasColumnName("SalePrice")
                .HasColumnType("NUMERIC(15, 2)");

            builder.Property(p => p.Description)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .HasColumnName("Description")
                .HasColumnType("VARCHAR(200)");

            builder.Property(p => p.CategoryId)
                .HasColumnName("CategoryId");

            builder.HasOne(x => x.Category)
                .WithMany(p => p.Products)
                .HasForeignKey(f => f.CategoryId)
                .HasConstraintName("FK_PRODUCT_CATEGORY");
        }
    }
}
