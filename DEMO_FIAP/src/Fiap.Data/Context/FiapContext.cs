using Fiap.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Data.Context
{
    public class FiapContext : DbContext
    {
        public FiapContext(DbContextOptions<FiapContext> options) : base(options) 
        {

            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Verificar o API Fluent que foi criado e caso alguma propriedade não estiver setado ColumnType (tipo da coluna)
            //Por default colocar a propriedade como string de 100 caracteres (varchar(100))
            foreach (var property in modelBuilder.Model.GetEntityTypes()
               .SelectMany(e => e.GetProperties().Where(p => p.ClrType == typeof(string)))) property.SetColumnType("varchar(100)");

            //Obter todo o mapeamento realizado utilizando
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FiapContext).Assembly);
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }
    }
}
