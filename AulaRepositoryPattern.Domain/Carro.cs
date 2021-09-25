using System;
using System.ComponentModel.DataAnnotations;
using AulaRepositoryPattern.Core.Models;

namespace AulaRepositoryPattern.Domain
{
    public class Carro : Entity
    {
        [StringLength(100)]
        public string Nome { get; private set; }
        
        public int Potencia { get; private set; }
        
        public Carro(Guid id, string nome, int potencia) : base(id)
        {
            Nome = nome;
            Potencia = potencia;
        }
    }
}