using GestaoAlunos.Application.Dtos;
using GestaoAlunos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Application.Interfaces.Mappers
{
    public interface IMapperProduct
    {
        Product MapperDtoToEntity(ProductDTO dto);
        IEnumerable<ProductDTO> MapperListProductsDTO(IEnumerable<Product> products);
        ProductDTO MapperEntityToDto(Product product);
    }
}
