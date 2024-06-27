using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Domain.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public DateTime DataNascimento { get; set; }
        public int TurmaId { get; set; }
        public int? TutorId { get; set; }

        public Turma Turma { get; set; }
        public Funcionario Tutor { get; set; }
        public Pessoa Pessoa { get; set; }
    }

}
