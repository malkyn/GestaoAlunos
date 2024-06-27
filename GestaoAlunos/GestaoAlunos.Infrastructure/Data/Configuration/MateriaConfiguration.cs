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
    public class MateriaConfiguration : IEntityTypeConfiguration<Materia>
    {
        public void Configure(EntityTypeBuilder<Materia> builder)
        {
            builder.ToTable("Materia");

            builder.HasKey(m => m.Id);

            builder.Property(m => m.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(m => m.AreaDoConhecimento)
                .IsRequired()
                .HasMaxLength(50);
        }
    }

}
