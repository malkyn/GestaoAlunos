using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Domain.Models
{
    public class Gestor
    {
        public int Id { get; set; }
        public string Formacao { get; set; }

        public Funcionario Funcionario { get; set; }
    }

}
