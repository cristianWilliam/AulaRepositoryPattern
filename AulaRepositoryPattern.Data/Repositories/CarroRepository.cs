using AulaRepositoryPattern.Data.Context;
using AulaRepositoryPattern.Data.Repositories.Abstractions;
using AulaRepositoryPattern.Domain;

namespace AulaRepositoryPattern.Data.Repositories
{
    public class CarroRepository : RepositoryBase<Carro>, ICarroRepository
    {
        public CarroRepository(AppDbContext appContext) : base(appContext)
        {
            
        }
    }
}