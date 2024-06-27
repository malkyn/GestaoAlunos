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
    public class ChamadoConfiguration : IEntityTypeConfiguration<Chamado>
    {
        public void Configure(EntityTypeBuilder<Chamado> builder)
        {
            builder.ToTable("Chamado");

            builder.HasKey(c => new { c.Data, c.DataOcorrencia, c.AlunoOcorrenciaId });

            builder.HasOne(c => c.Ocorrencia)
                .WithMany()
                .HasForeignKey(c => new { c.AlunoOcorrenciaId, c.DataOcorrencia });

            builder.HasOne(c => c.Gestor)
                .WithMany()
                .HasForeignKey(c => c.GestorId);

            builder.HasOne(c => c.Responsavel)
                .WithMany()
                .HasForeignKey(c => c.ResponsavelId);
        }
    }

}
