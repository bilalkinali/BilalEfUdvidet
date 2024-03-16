using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityModels;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAccess
{
    public class VaregruppeDA
    {
        VaregruppeDbContext db;
        public VaregruppeDA()
        {
            db = new VaregruppeDbContext();
        }

        public async Task<List<Varegruppe>> GetAsync()
        {
            return await db.Varegruppe.Include(vg => vg.VareListe).ToListAsync();
        }

        public async Task<Varegruppe> GetVaregruppeAsync(int id)
        {
            return await db.Varegruppe.Include(vg => vg.VareListe).SingleOrDefaultAsync(vg => vg.Id == id)?? new Varegruppe();
        }

        public async Task<bool> CreateAsync(Varegruppe vareGruppe)
        {
            await db.AddAsync(vareGruppe);
            return await db.SaveChangesAsync() > 0;
        }
    }
}
