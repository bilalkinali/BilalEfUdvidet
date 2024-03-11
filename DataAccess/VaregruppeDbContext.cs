using Microsoft.EntityFrameworkCore;
using EntityModels;

namespace DataAccess
{
    public class VaregruppeDbContext : DbContext
    {
        public DbSet<Varegruppe> Varegrupper { get; set; }
        public DbSet<Vare> Vares { get; set; }
    }
}
