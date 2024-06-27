using GestaoAlunos.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Domain.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public TipoFuncionario TipoFuncionario { get; set; }
        public int CargoId { get; set; }

        public Cargo Cargo { get; set; }
        public Pessoa Pessoa { get; set; }
    }

}
