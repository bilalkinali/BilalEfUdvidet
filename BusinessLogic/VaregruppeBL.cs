using DataAccess;
using EntityModels;
using Microsoft.Identity.Client;

namespace BusinessLogic
{
    public class VaregruppeBL
    {
        VaregruppeDA vgDA;

        public VaregruppeBL()
        {
            vgDA = new VaregruppeDA();
        }

        public async Task<List<Varegruppe>> GetAsync()
        {
            return await vgDA.GetAsync();
        }
    }
}
