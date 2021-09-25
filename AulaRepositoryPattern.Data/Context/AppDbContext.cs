using AulaRepositoryPattern.Domain;
using Microsoft.EntityFrameworkCore;

namespace AulaRepositoryPattern.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}