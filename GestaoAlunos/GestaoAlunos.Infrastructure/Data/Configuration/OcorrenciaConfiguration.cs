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
    public class OcorrenciaConfiguration : IEntityTypeConfiguration<Ocorrencia>
    {
        public void Configure(EntityTypeBuilder<Ocorrencia> builder)
        {
            builder.ToTable("Ocorrencia");

            builder.HasKey(o => new { o.AlunoId, o.Data });

            builder.Property(o => o.Gravidade)
                .IsRequired();

            builder.HasOne(o => o.Aluno)
                .WithMany()
                .HasForeignKey(o => o.AlunoId);
        }
    }

}
