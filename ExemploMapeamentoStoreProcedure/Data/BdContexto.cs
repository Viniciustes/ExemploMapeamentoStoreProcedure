using ExemploMapeamentoStoreProcedure.Entidades;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ExemploMapeamentoStoreProcedure.Data
{
    public class BdContexto : DbContext
    {
        public BdContexto()
            : base("ConnectionStringMapeamentoStoreProcedure")
        {
            Database.SetInitializer<BdContexto>(null);
        }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder
                .Entity<Cliente>()
                .MapToStoredProcedures(sp => sp.Insert(i => i.HasName("SPU_Inserir_Cliente")));

            modelBuilder
                .Entity<Cliente>()
                .MapToStoredProcedures(sp => sp.Delete(i => i.HasName("SPU_Apagar_Cliente")));

            modelBuilder
                .Entity<Cliente>()
                .MapToStoredProcedures(sp => sp.Update(i => i.HasName("SPU_Alterar_Cliente")));
        }
    }
}