using System;
using System.Threading.Tasks;
using AulaRepositoryPattern.Data.Repositories.Abstractions;
using AulaRepositoryPattern.Domain;
using Microsoft.AspNetCore.Mvc;

namespace AulaRepositoryPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarroController : ControllerBase
    {
        private readonly ICarroRepository _carroRepository;

        public CarroController(ICarroRepository carroRepository)
        {
            _carroRepository = carroRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AdicionarCarro()
        {
            var carro = new Carro(Guid.NewGuid(), "Carro", 400);
            await _carroRepository.AddAsync(carro);
            return Ok(carro);
        }
    }
}