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
        Validation.VaregruppeValidator vgValidator;

        public VaregruppeBL()
        {
            vgDA = new VaregruppeDA();
            modelConverter = new ModelConverter();
            vgValidator = new Validation.VaregruppeValidator();
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
            if (!vgValidator.ValidGroup(vgUI))
            {
                return false;
            }
            return await vgDA.CreateAsync(modelConverter.ConvertFromVaregruppeUI(vgUI));
        }

        public async Task<bool> UpdateAsync(VaregruppeUI vgUI)
        {
            if (vgValidator.ValidGroup(vgUI))
            {
                return false;
            }
            return await vgDA.UpdateAsync(modelConverter.ConvertFromVaregruppeUI(vgUI));
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await vgDA.DeleteAsync(id);
        }
    }
}
