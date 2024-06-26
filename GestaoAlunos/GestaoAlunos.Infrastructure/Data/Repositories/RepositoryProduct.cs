using GestaoAlunos.Domain.Core.Interfaces.Repositories;
using GestaoAlunos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Infrastructure.Data.Repositories
{
    public class RepositoryProduct : RepositoryBase<Product>, IRepositoryProduct
    {
        private readonly SqlContext _context;

        public RepositoryProduct(SqlContext context) : base(context)
        {
            _context = context;
        }
    }
}
