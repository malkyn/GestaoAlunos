using GestaoAlunos.Domain.Core.Interfaces.Repositories;
using GestaoAlunos.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repositoryBase;
        public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }
        public void Add(TEntity entity)
        {
            _repositoryBase.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _repositoryBase.Delete(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repositoryBase.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _repositoryBase.GetById(id);
        }

        public void Update(TEntity entity)
        {
            _repositoryBase.Update(entity);
        }
    }
}
