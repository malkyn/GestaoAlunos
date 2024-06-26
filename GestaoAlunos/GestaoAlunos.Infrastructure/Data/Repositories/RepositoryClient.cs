using GestaoAlunos.Domain.Core.Interfaces.Repositories;
using GestaoAlunos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Infrastructure.Data.Repositories
{
    public class RepositoryClient : RepositoryBase<Client>, IRepositoryClient
    {
        private readonly SqlContext _context;
        public RepositoryClient(SqlContext context) : base(context)
        {
            _context = context;
        }
    }
}
