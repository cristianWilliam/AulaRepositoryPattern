using System.Threading.Tasks;
using AulaRepositoryPattern.Core.Models;
using AulaRepositoryPattern.Data.Repositories.Abstractions;
using AulaRepositoryPattern.Domain;

namespace AulaRepositoryPattern.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IRepositoryBase<Usuario> _repositoryBase;

        public UsuarioRepository(IRepositoryBase<Usuario> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public async Task AddAsync(Usuario entity)
        {
            await _repositoryBase.AddAsync(entity);
        }
    }
}