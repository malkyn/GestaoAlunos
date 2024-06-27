using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Infrastructure.Data.Configuration
{
    public class TurmaConfiguration : IEntityTypeConfiguration<Turma>
    {
        public void Configure(EntityTypeBuilder<Turma> builder)
        {
            builder.ToTable("Turma");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.AnoOferecimento)
                .IsRequired();

            builder.Property(t => t.AnoSerie)
                .IsRequired();

            builder.Property(t => t.Serie)
                .IsRequired();

            builder.HasOne(t => t.Curso)
                .WithMany()
                .HasForeignKey(t => t.CursoId);
        }
    }

}
