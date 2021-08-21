using DeeperAndDeeper.Models;
using Microsoft.EntityFrameworkCore;

namespace DeeperAndDeeper.Data
{
    public class DeeperAndDeeperContext : DbContext
    {
        public DeeperAndDeeperContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Sector> Sector { get; set; }
        public DbSet<SolarBody> SolarBody { get; set; }
        public DbSet<Resource> Resource { get; set; }
    }
}