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
            return await db.Varegruppe.Include(vg => vg.VareListe).SingleOrDefaultAsync(vg => vg.Id == id)?? new();
        }

        public async Task<bool> CreateAsync(Varegruppe vareGruppe)
        {
            await db.Varegruppe.AddAsync(vareGruppe);
            return await db.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateAsync(Varegruppe vareGruppe)
        {
            Varegruppe updateVg = await db.Varegruppe.SingleOrDefaultAsync(vg => vg.Id == vareGruppe.Id)?? new();
            if (updateVg != null)
            {
                updateVg.Name = vareGruppe.Name;
                return await db.SaveChangesAsync() > 0;
            }
            return false;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            Varegruppe deleteVg = await db.Varegruppe.FindAsync(id);
            if (deleteVg != null)
            {
                db.Varegruppe.Remove(deleteVg);
                return await db.SaveChangesAsync() > 0;
            }
            return false;
        }
    }
}
