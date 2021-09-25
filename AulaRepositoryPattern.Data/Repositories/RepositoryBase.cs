using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AulaRepositoryPattern.Core.Models;
using AulaRepositoryPattern.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace AulaRepositoryPattern.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : Entity
    {
        public readonly DbSet<TEntity> _DbSet;
        public readonly AppDbContext _AppDbContext;
        
        public RepositoryBase(AppDbContext appContext)
        {
            _DbSet = appContext.Set<TEntity>();
            _AppDbContext = appContext;
        }
        
        public async Task<IEnumerable<TEntity>> Obter(Expression<Func<TEntity, bool>> filter = null)
        {
            var query = _DbSet.AsQueryable();

            if (filter != null)
                query = query
                    .Where(filter)
                    .AsNoTracking();

            return await query.ToListAsync();
        }

        public async Task<TEntity> ObterPorIdAsync(Guid id)
        {
            return await _DbSet.FindAsync(id);
        }

        public async Task AddAsync(TEntity entity)
        {
            await _DbSet.AddAsync(entity);
            await _AppDbContext.SaveChangesAsync();
        }

        public async Task DeletarAsync(TEntity entity)
        {
            _DbSet.Remove(entity);
            await _AppDbContext.SaveChangesAsync();
        }

        public async Task Atualizar(TEntity entity)
        {
            _DbSet.Update(entity);
            await _AppDbContext.SaveChangesAsync();
        }
    }
}