using Microsoft.EntityFrameworkCore;
using TranTienSon_231210892_de02.Models;

namespace TranTienSon_231210892_de02.Database
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }

        public DbSet<TtsCatalog> TtsCatalogs { get; set; }
    }
}
