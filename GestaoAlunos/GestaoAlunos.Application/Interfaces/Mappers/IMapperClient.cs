using GestaoAlunos.Application.Dtos;
using GestaoAlunos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Application.Interfaces.Mappers
{
    public interface IMapperClient
    {
        Client MapperDtoToEntity(ClientDTO dto);
        IEnumerable<ClientDTO> MapperListClientsDto(IEnumerable<Client> clients);
        ClientDTO MapperEntityToDto(Client client);
    }
}
