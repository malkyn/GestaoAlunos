using GestaoAlunos.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Domain.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string PrimeiroNome { get; set; }
        public string Sobrenome { get; set; }
        public TipoPessoa TipoPessoa { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public string NumeroResidencia { get; set; }
    }
}
