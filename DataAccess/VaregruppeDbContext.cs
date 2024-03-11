using Microsoft.EntityFrameworkCore;
using EntityModels;

namespace DataAccess
{
    internal class VaregruppeDbContext : DbContext
    {
        public DbSet<Varegruppe> Varegruppe { get; set; }
        public DbSet<Vare> Vare { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=BILAL-KINALI;Database=EfUdvidet;Trusted_Connection=True;Encrypt=false;")
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
    }
}
