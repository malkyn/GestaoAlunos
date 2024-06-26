using AutoMapper;
using GestaoAlunos.Application.Dtos;
using GestaoAlunos.Application.Interfaces;
using GestaoAlunos.Domain.Core.Interfaces.Services;
using GestaoAlunos.Domain.Models;

namespace GestaoAlunos.Application
{
    public class ApplicationServiceProduct : IApplicationServiceProduct
    {
        private readonly IServiceProduct _service;
        private readonly IMapper _mapper;

        public ApplicationServiceProduct(IServiceProduct product, IMapper mapper)
        {
            _mapper = mapper;
            _service = product;
        }
        public void Add(ProductDTO productDto)
        {
            var products = _mapper.Map<Product>(productDto);
        }

        public IEnumerable<ProductDTO> GetAll()
        {
            var products = _service.GetAll();
            return _mapper.Map<IEnumerable<ProductDTO>>(products);
        }

        public ProductDTO GetById(int id)
        {
            var products = _service.GetById(id);
            return _mapper.Map<ProductDTO>(products);
        }

        public void Remove(ProductDTO productDto)
        {
            var products = _mapper.Map<Product>(productDto);
            _service.Delete(products);
        }

        public void Update(ProductDTO productDto)
        {
            var products = _mapper.Map<Product>(productDto);
            _service.Update(products);
        }
    }
}
