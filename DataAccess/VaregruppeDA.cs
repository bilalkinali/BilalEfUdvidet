using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityModels;

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
            return await db.Varegruppe.Include(v => v.VareListe).ToListAsync();
        }
    }
}
