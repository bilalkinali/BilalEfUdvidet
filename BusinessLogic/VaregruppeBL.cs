using DataAccess;
using EntityModels;
using UiModels;
using Microsoft.Identity.Client;

namespace BusinessLogic
{
    public class VaregruppeBL
    {
        VaregruppeDA vgDA;
        ModelConverter modelConverter;

        public VaregruppeBL()
        {
            vgDA = new VaregruppeDA();
            modelConverter = new ModelConverter();
        }

        public async Task<List<VaregruppeUI>> GetAsync()
        {
            List<VaregruppeUI> list = new List<VaregruppeUI>();
            foreach (Varegruppe vg in await vgDA.GetAsync())
            {
                list.Add(modelConverter.ConvertFromVaregruppeEntity(vg));
            }
            return list;
        }

        public async Task<VaregruppeUI> GetVaregruppeAsync(int id)
        {
            return modelConverter.ConvertFromVaregruppeEntity(await vgDA.GetVaregruppeAsync(id));
        }

        public async Task<bool> CreateAsync(VaregruppeUI vgUI)
        {
            return await vgDA.CreateAsync(modelConverter.ConvertFromVaregruppeUI(vgUI));
        }
    }
}
