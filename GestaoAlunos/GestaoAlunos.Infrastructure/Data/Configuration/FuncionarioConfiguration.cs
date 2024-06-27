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
    public class FuncionarioConfiguration : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("Funcionario");

            builder.HasKey(f => f.Id);

            builder.Property(f => f.TipoFuncionario)
                .IsRequired();

            builder.HasOne(f => f.Cargo)
                .WithMany()
                .HasForeignKey(f => f.CargoId);

            builder.HasOne(f => f.Pessoa)
                .WithOne()
                .HasForeignKey<Funcionario>(f => f.Id);
        }
    }

}
