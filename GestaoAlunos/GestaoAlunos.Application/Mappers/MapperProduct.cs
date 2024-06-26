using GestaoAlunos.Application.Dtos;
using GestaoAlunos.Application.Interfaces.Mappers;
using GestaoAlunos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Application.Mappers
{
    public class MapperProduct : IMapperProduct
    {
        public Product MapperDtoToEntity(ProductDTO dto)
        {
            var product = new Product()
            {
                ID = dto.Id,
                Name = dto.Name,
                Price = dto.Price,
            };
            return product;
        }

        public ProductDTO MapperEntityToDto(Product product)
        {
            var dto = new ProductDTO()
            {
                Id = product.ID,
                Name = product.Name,
                Price = product.Price,
            };
            return dto;
        }

        public IEnumerable<ProductDTO> MapperListProductsDTO(IEnumerable<Product> products)
        {
            var dto = products.Select(c => new ProductDTO
            {
                Id = c.ID,
                Name = c.Name,
                Price = c.Price
            });
            return dto;
        }
    }
}
