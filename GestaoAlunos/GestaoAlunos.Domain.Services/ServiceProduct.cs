using GestaoAlunos.Domain.Core.Interfaces.Repositories;
using GestaoAlunos.Domain.Core.Interfaces.Services;
using GestaoAlunos.Domain.Models;

namespace GestaoAlunos.Domain.Services
{
    public class ServiceProduct : ServiceBase<Product>, IServiceProduct
    {
        private readonly IRepositoryProduct _product;
        public ServiceProduct(IRepositoryProduct product) : base(product)
        {
            _product = product;
        }
    }
}
