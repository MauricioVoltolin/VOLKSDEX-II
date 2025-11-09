using Microsoft.EntityFrameworkCore;
using Volksdex_II.Models;

namespace Volksdex_II.Data
{
    public class VolksdexContext : DbContext
    {
        public VolksdexContext(DbContextOptions<VolksdexContext> options)
            : base(options)
        {
        }

        public DbSet<Carro> Carros { get; set; }
    }
}
