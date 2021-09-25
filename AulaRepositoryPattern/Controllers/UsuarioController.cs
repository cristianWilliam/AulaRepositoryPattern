using System;
using System.Threading.Tasks;
using AulaRepositoryPattern.Data.Repositories.Abstractions;
using AulaRepositoryPattern.Domain;
using Microsoft.AspNetCore.Mvc;

namespace AulaRepositoryPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;
        
        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddUsuario()
        {
            var usuario = new Usuario(Guid.NewGuid(), "Cristian", "Email@Email.com", 25);
            await _usuarioRepository.AddAsync(usuario);
            return Ok(usuario);
        }
    }
}