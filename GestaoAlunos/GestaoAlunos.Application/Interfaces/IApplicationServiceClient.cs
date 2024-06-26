using GestaoAlunos.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Application.Interfaces
{
    public interface IApplicationServiceClient
    {
        void Add(ClientDTO clientDto);
        void Remove(ClientDTO clientDto);
        void Update(ClientDTO clientDto);
        IEnumerable<ClientDTO> GetAll();
        ClientDTO GetById(int id);
    }
}
