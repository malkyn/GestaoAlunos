using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Domain.Models
{
    public class Responsavel
    {
        public int Id { get; set; }
        public string Parentesco { get; set; }
        public int AlunoDependenteId { get; set; }

        public Aluno AlunoDependente { get; set; }
        public Pessoa Pessoa { get; set; }
    }

}
