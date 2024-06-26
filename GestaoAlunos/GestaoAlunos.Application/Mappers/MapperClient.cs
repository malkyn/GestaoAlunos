using GestaoAlunos.Application.Dtos;
using GestaoAlunos.Application.Interfaces.Mappers;
using GestaoAlunos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Application.Mappers
{
    public class MapperClient : IMapperClient
    {
        public Client MapperDtoToEntity(ClientDTO dto)
        {
            var client = new Client()
            {
                ID = dto.ID,
                Email = dto.Email,
                Name = dto.Name,
                LastName = dto.LastName,
            };
            return client;
        }

        public ClientDTO MapperEntityToDto(Client client)
        {
            var dto = new ClientDTO()
            {
                ID = client.ID,
                Email = client.Email,
                Name = client.Name,
                LastName = client.LastName,
            };

            return dto;
        }

        public IEnumerable<ClientDTO> MapperListClientsDto(IEnumerable<Client> clients)
        {
            var dto = clients.Select(c => new ClientDTO
            {
                ID = c.ID,
                Name = c.Name,
                LastName = c.LastName,
            });
            return dto;
        }
    }
}
