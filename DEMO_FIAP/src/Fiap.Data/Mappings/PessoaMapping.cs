using Fiap.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fiap.Data.Mappings
{
    public class PessoaMapping : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(30)")
                .HasColumnName("Nome");

            builder.Property(p => p.Sobrenome)
                .IsRequired()
                .HasColumnType("varchar(30)")
                .HasColumnName("Sobrenome");

            builder.Property(p => p.CPF)
               .IsRequired()
               .HasColumnType("varchar(11)")
               .HasColumnName("CPF");

            builder.Property(p => p.RG)
               .IsRequired()
               .HasColumnType("varchar(11)")
               .HasColumnName("RG");

            builder.HasOne(a => a.Endereco)
               .WithOne(c => c.Pessoa);

            builder.ToTable("Pessoa");
        }
    }
}
