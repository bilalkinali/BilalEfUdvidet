using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class VareDA
    {
        VaregruppeDbContext db;
        public VareDA()
        {
            db = new VaregruppeDbContext();
        }

        //public async Task<bool> AddAsync()
        //{
        //    Vare vare = new Vare { Name = "Test", Description = "Test", Price = 100, VaregruppeId = 1 };
        //    await db.AddAsync(vare);
        //    await db.SaveChangesAsync();
        //    return true;
        //}
    }
}
