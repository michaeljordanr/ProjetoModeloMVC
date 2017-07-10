using MJ.ProjetoModelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJ.ProjetoModelo.Infra.Data.EntityConfig
{
    public class EnderecoConfiguration : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfiguration()
        {
            HasKey(e => e.EnderecoId);

            Property(e => e.Rua)
                .HasMaxLength(300)
                .IsRequired();

            Property(e => e.Numero)
                .IsRequired()
                .HasMaxLength(15);

            Property(e => e.Complemento)
                .HasMaxLength(400);

            Property(e => e.Bairro)
                .IsRequired();

            Property(e => e.CEP)
                .HasMaxLength(8)
                .IsRequired();

            HasRequired(e => e.Cliente)
                .WithMany()
                .HasForeignKey(e => e.ClienteId);
        }

    }
}
