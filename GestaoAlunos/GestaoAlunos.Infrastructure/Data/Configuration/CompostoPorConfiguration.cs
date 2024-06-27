using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Infrastructure.Data.Configuration
{
    public class CompostoPorConfiguration : IEntityTypeConfiguration<CompostoPor>
    {
        public void Configure(EntityTypeBuilder<CompostoPor> builder)
        {
            builder.ToTable("Composto_por");

            builder.HasKey(cp => new { cp.IdMateria, cp.IdCurso });

            builder.HasOne(cp => cp.Materia)
                .WithMany()
                .HasForeignKey(cp => cp.IdMateria);

            builder.HasOne(cp => cp.Curso)
                .WithMany()
                .HasForeignKey(cp => cp.IdCurso);
        }
    }

}
