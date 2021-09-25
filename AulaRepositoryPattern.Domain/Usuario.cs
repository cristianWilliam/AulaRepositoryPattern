using System;
using AulaRepositoryPattern.Core.Models;

namespace AulaRepositoryPattern.Domain
{
    public class Usuario : Entity
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public int Idade { get; private set; }

        public Usuario(Guid id, string nome, string email, int idade) : base(id)
        {
            Nome = nome;
            Email = email;
            Idade = idade;
        }
    }
}