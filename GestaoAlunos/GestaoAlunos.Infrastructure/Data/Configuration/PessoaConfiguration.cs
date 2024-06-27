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
    public class PessoaConfiguration : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("Pessoa");

            builder.HasKey(p => p.Id);

            builder.HasIndex(p => p.Cpf)
                .IsUnique();

            builder.Property(p => p.Cpf)
                .IsRequired()
                .HasMaxLength(11);

            builder.Property(p => p.PrimeiroNome)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(p => p.Sobrenome)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(p => p.TipoPessoa)
                .IsRequired();

            builder.Property(p => p.Email)
                .HasMaxLength(50);

            builder.Property(p => p.Cep)
                .HasMaxLength(8);

            builder.Property(p => p.Telefone)
                .HasMaxLength(11);

            builder.Property(p => p.NumeroResidencia)
                .IsRequired()
                .HasMaxLength(6);
        }
    }
}
