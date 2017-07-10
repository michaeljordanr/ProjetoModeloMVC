using System;
using System.Collections.Generic;

namespace MJ.ProjetoModelo.Domain.Entities
{
    public class Cliente
    {
        public Cliente()
        {
            ClienteId = Guid.NewGuid();
        }

        public Guid ClienteId { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual IEnumerable<Endereco> Endereco { get; set; }
    }
}
