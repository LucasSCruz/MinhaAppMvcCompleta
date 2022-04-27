using DevIo.App.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DevIo.App.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions options) : base(options) 
        {

        }
        public DbSet<DevIo.App.ViewModels.ProdutoViewModel> ProdutoViewModel { get; set; }
    }
}
