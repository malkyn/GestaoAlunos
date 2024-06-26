using AutoMapper;
using GestaoAlunos.Application.Dtos;
using GestaoAlunos.Application.Interfaces;
using GestaoAlunos.Domain.Core.Interfaces.Services;
using GestaoAlunos.Domain.Entities;

namespace GestaoAlunos.Application
{
    public class ApplicationServiceClient : IApplicationServiceClient
    {
        private readonly IServiceClient _service;
        private readonly IMapper _mapper;

        public ApplicationServiceClient(IServiceClient service, IMapper mapper)
        {
            _mapper = mapper;
            _service = service;
        }

        public void Add(ClientDTO clientDto)
        {
            var client = _mapper.Map<Client>(clientDto);
            _service.Add(client);
        }

        public IEnumerable<ClientDTO> GetAll()
        {
            var clients = _service.GetAll();
            return _mapper.Map<IEnumerable<ClientDTO>> (clients);
        }

        public ClientDTO GetById(int id)
        {
            var clients = _service.GetById(id);
            return _mapper.Map<ClientDTO>(clients);
        }

        public void Remove(ClientDTO clientDto)
        {
            var clients = _mapper.Map<Client>(clientDto);
            _service.Delete(clients);
        }

        public void Update(ClientDTO clientDto)
        {
            var clients = _mapper.Map<Client>(clientDto);
            _service.Update(clients);
        }
    }
}
