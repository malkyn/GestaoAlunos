using GestaoAlunos.Domain.Core.Interfaces.Repositories;
using GestaoAlunos.Domain.Core.Interfaces.Services;
using GestaoAlunos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Domain.Services
{
    public class ServiceClient : ServiceBase<Client>, IServiceClient
    {
        private readonly IRepositoryClient _client;

        public ServiceClient(IRepositoryClient client) : base(client)
        {
            _client = client;
        }
    }
}
