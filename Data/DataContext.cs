using Microsoft.EntityFrameworkCore;
using usingScaffolding.Models;

namespace usingScaffolding.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }

    }
}
