using System.Data.Entity;
using CadastroCliente.ContextConfig;
using CadastroCliente.Models;

namespace CadastroCliente.Models
{
    public class CadastroClienteContext : DbContext
    {
        public CadastroClienteContext() : base("CadastroClienteBD")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClienteConfig());
            modelBuilder.Configurations.Add(new ProdutoConfig());
        }
    }
}