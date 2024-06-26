using GestaoAlunos.Domain.Entities;
using GestaoAlunos.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Infrastructure.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(p => p.ID);
            builder.Property(p => p.ID).HasColumnName("ID");
            builder.Property(p => p.Name).HasColumnName("Name").HasMaxLength(100);
        }
    }
}
