using GestaoAlunos.Application.Dtos;
using GestaoAlunos.Application.Interfaces;
using GestaoAlunos.Application.Interfaces.Mappers;
using GestaoAlunos.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Application
{
    public class ApplicationServiceProduct : IApplicationServiceProduct
    {
        private readonly IServiceProduct _service;
        private readonly IMapperProduct _mapper;

        public ApplicationServiceProduct(IServiceProduct product, IMapperProduct mapper)
        {
            _mapper = mapper;
            _service = product;
        }
        public void Add(ProductDTO clientDto)
        {
            var products = _mapper.MapperDtoToEntity(clientDto);
        }

        public IEnumerable<ProductDTO> GetAll()
        {
            var products = _service.GetAll();
            return _mapper.MapperListProductsDTO(products);
        }

        public ProductDTO GetById(int id)
        {
            var products = _service.GetById(id);
            return _mapper.MapperEntityToDto(products);
        }

        public void Remove(ProductDTO clientDto)
        {
            var products = _mapper.MapperDtoToEntity(clientDto);
            _service.Delete(products);
        }

        public void Update(ProductDTO clientDto)
        {
            var products = _mapper.MapperDtoToEntity(clientDto);
            _service.Update(products);
        }
    }
}
