using GestaoAlunos.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Application.Interfaces
{
    public interface IApplicationServiceProduct
    {
        void Add(ProductDTO clientDto);
        void Remove(ProductDTO clientDto);
        void Update(ProductDTO clientDto);
        IEnumerable<ProductDTO> GetAll();
        ProductDTO GetById(int id);
    }
}
