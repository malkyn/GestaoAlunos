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
    public class AlunoConfiguration : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Aluno");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.DataNascimento)
                .IsRequired();

            builder.HasOne(a => a.Turma)
                .WithMany()
                .HasForeignKey(a => a.TurmaId);

            builder.HasOne(a => a.Tutor)
                .WithMany()
                .HasForeignKey(a => a.TutorId);

            builder.HasOne(a => a.Pessoa)
                .WithOne()
                .HasForeignKey<Aluno>(a => a.Id);
        }
    }

}
