using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Infrastructure.Data.Configuration
{
    public class DocenteConfiguration : IEntityTypeConfiguration<Docente>
    {
        public void Configure(EntityTypeBuilder<Docente> builder)
        {
            builder.ToTable("Docente");

            builder.HasKey(d => d.Id);

            builder.Property(d => d.AreaEnsino)
                .IsRequired()
                .HasMaxLength(10);

            builder.HasOne(d => d.Funcionario)
                .WithOne()
                .HasForeignKey<Docente>(d => d.Id);
        }
    }

}
