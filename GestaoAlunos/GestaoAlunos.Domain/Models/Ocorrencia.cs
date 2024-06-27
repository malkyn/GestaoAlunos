using GestaoAlunos.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Domain.Models
{
    public class Ocorrencia
    {
        public int Id { get; set; }
        public Aluno Aluno { get; set; }
        public int ID_Aluno { get; set; }
        public Gravidade Gravidade { get; set; } 
        public DateTime Data {  get; set; }
    }
}
