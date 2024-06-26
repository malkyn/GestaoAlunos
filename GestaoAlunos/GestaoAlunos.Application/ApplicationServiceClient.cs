using GestaoAlunos.Application.Dtos;
using GestaoAlunos.Application.Interfaces;
using GestaoAlunos.Application.Interfaces.Mappers;
using GestaoAlunos.Domain.Core.Interfaces.Services;

namespace GestaoAlunos.Application
{
    public class ApplicationServiceClient : IApplicationServiceClient
    {
        private readonly IServiceClient _service;
        private readonly IMapperClient _mapper;

        public ApplicationServiceClient(IServiceClient service, IMapperClient mapper)
        {
            _mapper = mapper;
            _service = service;
        }

        public void Add(ClientDTO clientDto)
        {
            var client = _mapper.MapperDtoToEntity(clientDto);
            _service.Add(client);
        }

        public IEnumerable<ClientDTO> GetAll()
        {
            var clients = _service.GetAll();
            return _mapper.MapperListClientsDto(clients);
        }

        public ClientDTO GetById(int id)
        {
            var clients = _service.GetById(id);
            return _mapper.MapperEntityToDto(clients);
        }

        public void Remove(ClientDTO clientDto)
        {
            var clients = _mapper.MapperDtoToEntity(clientDto);
            _service.Delete(clients);
        }

        public void Update(ClientDTO clientDto)
        {
            var clients = _mapper.MapperDtoToEntity(clientDto);
            _service.Update(clients);
        }
    }
}
