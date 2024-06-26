using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Domain.Models
{
    public class Product : Base
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsAvaible { get; set; }
    }
}
