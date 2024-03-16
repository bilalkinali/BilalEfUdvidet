using EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class VareDA
    {
        VaregruppeDbContext db;
        public VareDA()
        {
            db = new VaregruppeDbContext();
        }

        public async Task<List<Vare>> GetAsync()
        {
            return await db.Vare.ToListAsync();
        }

        public async Task<Vare> GetVareAsync(int id)
        {
            return await db.Vare.SingleOrDefaultAsync(v => v.Id == id) ?? new();
        }

        public async Task<bool> CreateAsync(Vare vare)
        {
            await db.Vare.AddAsync(vare);
            return await db.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateAsync(Vare vare)
        {
            Vare updateV = await db.Vare.SingleOrDefaultAsync(v => v.Id == vare.Id) ?? new();
            if (updateV != null)
            {
                updateV.Name = vare.Name;
                updateV.Description = vare.Description;
                updateV.Price = vare.Price;
                return await db.SaveChangesAsync() > 0;
            }
            return false;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            Vare deleteV = await db.Vare.FindAsync(id);
            if (deleteV != null)
            {
                db.Vare.Remove(deleteV);
                return await db.SaveChangesAsync() > 0;
            }
            return false;
        }
    }
}
