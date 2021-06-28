using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartPM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPM.Infra.Data.Mapping
{
    public class ImageProductMap : IEntityTypeConfiguration<ImageProduct>
    {
        public void Configure(EntityTypeBuilder<ImageProduct> builder)
        {
            builder.ToTable(typeof(Product).Name);
            
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Path)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Path")
                .HasColumnType("VARCHAR(250)");

            builder.Property(p => p.ProductId)
                .HasColumnName("ProductId");

            builder.HasOne(p => p.Product)
                .WithMany(x => x.Images)
                .HasForeignKey(f => f.ProductId)
                .HasConstraintName("FK_IMAGE_PRODUCT");
        }
    }
}
