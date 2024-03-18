using EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class StoreAccess
    {
        StoreDbContext db;
        public StoreAccess()
        {
            db = new StoreDbContext();
        }

        public async Task<List<Vare>> GetVarerAsync()
        {
            return await db.Vare.Include(vg => vg.Varegruppe).ToListAsync();
        }

        public async Task<Vare> GetVareAsync(int id)
        {
            Vare v = await db.Vare.Include(vg => vg.Varegruppe).SingleOrDefaultAsync(v => v.Id == id) ?? new();
            //v.Varegruppe = await db.Varegruppe.SingleOrDefaultAsync(vg => vg.Id == v.VaregruppeId);
            return v;
        }

        public async Task<List<Varegruppe>> GetVaregrupperAsync()
        {
            return await db.Varegruppe.Include(vg => vg.VareListe).ToListAsync();
        }

        public async Task<Varegruppe> GetVaregruppeAsync(int id)
        {
            return await db.Varegruppe.Include(vg => vg.VareListe).SingleOrDefaultAsync(vg => vg.Id == id) ?? new();
        }

        public async Task<bool> CreateVareAsync(Vare vare)
        {
            await db.AddAsync(vare);
            bool result = await db.SaveChangesAsync() > 0;
            db.ChangeTracker.Clear();
            return result;
        }

        public async Task<bool> CreateVaregruppeAsync(Varegruppe vareGruppe)
        {
            await db.Varegruppe.AddAsync(vareGruppe);
            bool result = await db.SaveChangesAsync() > 0;
            db.ChangeTracker.Clear();
            return result;
        }

        public async Task<bool> UpdateVareAsync(Vare vare)
        {
            db.Vare.Update(vare);
            bool result = await db.SaveChangesAsync() > 0;
            db.ChangeTracker.Clear();
            return result;
        }

        public async Task<bool> UpdateVaregruppeAsync(Varegruppe vareGruppe)
        {
            db.Update(vareGruppe);
            bool result = await db.SaveChangesAsync() > 0;
            db.ChangeTracker.Clear();
            return result;
        }

        public async Task<bool> DeleteVareAsync(int id)
        {
            Vare deleteV = await db.Vare.FindAsync(id);
            if (deleteV != null)
            {
                db.Vare.Remove(deleteV);
                return await db.SaveChangesAsync() > 0;
            }
            return false;
        }

        public async Task<bool> DeleteVaregruppeAsync(int id)
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
