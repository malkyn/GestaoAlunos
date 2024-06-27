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
    public class AulaGradeConfiguration : IEntityTypeConfiguration<AulaGrade>
    {
        public void Configure(EntityTypeBuilder<AulaGrade> builder)
        {
            builder.ToTable("Aula_grade");

            builder.HasKey(ag => new { ag.HoraInicio, ag.DiaDaSemana, ag.MateriaId, ag.TurmaId });

            builder.Property(ag => ag.DiaDaSemana)
                .IsRequired();

            builder.HasOne(ag => ag.Materia)
                .WithMany()
                .HasForeignKey(ag => ag.MateriaId);

            builder.HasOne(ag => ag.Turma)
                .WithMany()
                .HasForeignKey(ag => ag.TurmaId);

            builder.HasOne(ag => ag.Docente)
                .WithMany()
                .HasForeignKey(ag => ag.DocenteId);
        }
    }

}
