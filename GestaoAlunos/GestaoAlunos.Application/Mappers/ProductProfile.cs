using AutoMapper;
using GestaoAlunos.Application.Dtos;
using GestaoAlunos.Domain.Models;

namespace GestaoAlunos.Application.Mappers
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDTO>();
            CreateMap<ProductDTO, Product>();
        }
    }
}
