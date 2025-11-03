using Microsoft.EntityFrameworkCore;
using volksdex.Models;

namespace volksdex.Data
{
    public class VolksdexContext : DbContext
    {
        public VolksdexContext(DbContextOptions<VolksdexContext> options) : base(options) { }

        public DbSet<Carro> Carros { get; set; }
    }    
}

