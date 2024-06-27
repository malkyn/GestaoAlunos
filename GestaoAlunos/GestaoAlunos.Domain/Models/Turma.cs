using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Domain.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public int AnoOferecimento { get; set; }
        public int AnoSerie { get; set; }
        public char Serie { get; set; }
        public int CursoId { get; set; }

        public Curso Curso { get; set; }
    }

}
