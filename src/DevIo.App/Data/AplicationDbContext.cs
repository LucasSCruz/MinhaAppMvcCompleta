using DevIo.App.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DevIo.App.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext()
        {

        }

        public DbSet<ProdutoViewModel > Produtos { get; set; }
        public DbSet<EnderecoViewModel> Enderecos { get; set; }
        public DbSet<FornecedorViewModel> Fornecedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AplicationDbContext).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }

        internal Task<EnderecoViewModel> ASNoTracking()
        {
            throw new NotImplementedException();
        }
    }
}
