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
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client");
            builder.HasKey(p => p.ID);
            builder.Property(p => p.ID).HasColumnName("ID");
            builder.Property(p => p.Name).HasColumnName("Name").HasMaxLength(100);
            builder.Property(p => p.LastName).HasColumnName("LastName").HasMaxLength(100);
            builder.Property(p => p.CreatedAt).HasColumnType("datetime").IsRequired();
            builder.Property(p => p.IsActive).HasColumnName("IsActive");
        }
    }
}
