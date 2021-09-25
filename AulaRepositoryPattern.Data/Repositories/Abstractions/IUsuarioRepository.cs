using System.Threading.Tasks;
using AulaRepositoryPattern.Core.Models;
using AulaRepositoryPattern.Domain;

namespace AulaRepositoryPattern.Data.Repositories.Abstractions
{
    public interface IUsuarioRepository
    {
        Task AddAsync(Usuario entity);
    }
}