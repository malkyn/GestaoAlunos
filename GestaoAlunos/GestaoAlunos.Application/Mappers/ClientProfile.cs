using AutoMapper;
using GestaoAlunos.Application.Dtos;
using GestaoAlunos.Domain.Entities;

namespace GestaoAlunos.Application.Mappers
{
    public class ClientProfile : Profile
    {
        public ClientProfile()
        {
            CreateMap<Client, ClientDTO>();
            CreateMap<ClientDTO, Client>();
        }
    }
}
