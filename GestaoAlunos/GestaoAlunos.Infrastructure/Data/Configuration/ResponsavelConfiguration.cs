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
    public class ResponsavelConfiguration : IEntityTypeConfiguration<Responsavel>
    {
        public void Configure(EntityTypeBuilder<Responsavel> builder)
        {
            builder.ToTable("Responsavel");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.Parentesco)
                .HasMaxLength(20);

            builder.HasOne(r => r.AlunoDependente)
                .WithMany()
                .HasForeignKey(r => r.AlunoDependenteId);

            builder.HasOne(r => r.Pessoa)
                .WithOne()
                .HasForeignKey<Responsavel>(r => r.Id);
        }
    }

}
