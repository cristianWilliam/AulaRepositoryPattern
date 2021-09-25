using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AulaRepositoryPattern.Core.Models
{
    public interface IRepositoryBase<TEntity> where TEntity : Entity
    {
        Task<IEnumerable<TEntity>> Obter(Expression<Func<TEntity, bool>> filter = null);
        Task<TEntity> ObterPorIdAsync(Guid id);
        Task AddAsync(TEntity entity);
        Task DeletarAsync(TEntity entity);
        Task Atualizar(TEntity entity);
    }
}