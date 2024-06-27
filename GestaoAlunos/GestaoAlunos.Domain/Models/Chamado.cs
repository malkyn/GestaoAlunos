using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Domain.Models
{
    public class Chamado
    {
        public DateTime Data { get; set; }
        public DateTime DataOcorrencia { get; set; }
        public int AlunoOcorrenciaId { get; set; }
        public int GestorId { get; set; }
        public int? ResponsavelId { get; set; }

        public Ocorrencia Ocorrencia { get; set; }
        public Gestor Gestor { get; set; }
        public Responsavel Responsavel { get; set; }
    }

}
