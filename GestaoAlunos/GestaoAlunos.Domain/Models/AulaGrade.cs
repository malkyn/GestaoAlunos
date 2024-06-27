using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Domain.Models
{
    public class AulaGrade
    {
        public TimeSpan HoraInicio { get; set; }
        public string DiaDaSemana { get; set; }
        public int MateriaId { get; set; }
        public int TurmaId { get; set; }
        public int DocenteId { get; set; }

        public Materia Materia { get; set; }
        public Turma Turma { get; set; }
        public Docente Docente { get; set; }
    }

}
