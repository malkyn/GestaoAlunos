using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Domain.Models
{
    public class Docente
    {
        public int Id { get; set; }
        public string AreaEnsino { get; set; }

        public Funcionario Funcionario { get; set; }
    }

}
