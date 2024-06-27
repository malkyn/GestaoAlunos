using GestaoAlunos.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Infrastructure.Data.Configuration
{
    public class GestorConfiguration : IEntityTypeConfiguration<Gestor>
    {
        public void Configure(EntityTypeBuilder<Gestor> builder)
        {
            builder.ToTable("Gestor");

            builder.HasKey(g => g.Id);

            builder.Property(g => g.Formacao)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasOne(g => g.Funcionario)
                .WithOne()
                .HasForeignKey<Gestor>(g => g.Id);
        }
    }

}
