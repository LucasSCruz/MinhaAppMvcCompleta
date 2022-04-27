using DevIo.Business.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Data.Context
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions<MeuDbContext> options) : base(options) 
        {

        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeuDbContext).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }

        internal Task<Endereco> ASNoTracking()
        {
            throw new NotImplementedException();
        }
    }
}
