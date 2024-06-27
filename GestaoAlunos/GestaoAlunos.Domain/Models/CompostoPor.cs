using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Domain.Models
{
    public class CompostoPor
    {
        public int IdMateria { get; set; }
        public int IdCurso { get; set; }

        public Materia Materia { get; set; }
        public Curso Curso { get; set; }
    }

}
