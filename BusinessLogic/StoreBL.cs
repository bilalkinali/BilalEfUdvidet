using DataAccess;
using EntityModels;
using UiModels;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace BusinessLogic
{
    public class StoreBL
    {
        StoreAccess storeDA;
        ModelConverter modelConverter;
        Validation.VareValidator vValidator;
        Validation.VaregruppeValidator vgValidator;

        public StoreBL()
        {
            storeDA = new StoreAccess();
            modelConverter = new ModelConverter();
            vValidator = new Validation.VareValidator();
            vgValidator = new Validation.VaregruppeValidator();
        }

        public async Task<List<VareUI>> GetVarerAsync()
        {
            List<VareUI> list = new List<VareUI>();
            foreach (Vare v in await storeDA.GetVarerAsync())
            {
                list.Add(modelConverter.ConvertFromVareEntity(v));
            }
            return list;
        }

        public async Task<VareUI> GetVareAsync(int id)
        {
            return modelConverter.ConvertFromVareEntity(await storeDA.GetVareAsync(id));
        }

        public async Task<List<UiModels.VaregruppeUI>> GetVaregrupperAsync()
        {
            List<UiModels.VaregruppeUI> list = new List<UiModels.VaregruppeUI>();
            foreach (EntityModels.Varegruppe vg in await storeDA.GetVaregrupperAsync())
            {
                list.Add(modelConverter.ConvertFromVaregruppeEntity(vg));
            }
            return list;
        }

        public async Task<UiModels.VaregruppeUI> GetVaregruppeAsync(int id)
        {
            return modelConverter.ConvertFromVaregruppeEntity(await storeDA.GetVaregruppeAsync(id));
        }

        public async Task<bool> CreateVareAsync(VareUI vUI)
        {
            if (!vValidator.ValidVare(vUI))
            {
                return false;
            }
            return await storeDA.CreateVareAsync(modelConverter.ConvertFromVareUI(vUI));
        }

        public async Task<bool> CreateVaregruppeAsync(UiModels.VaregruppeUI vgUI)
        {
            if (!vgValidator.ValidGroup(vgUI))
            {
                return false;
            }
            return await storeDA.CreateVaregruppeAsync(modelConverter.ConvertFromVaregruppeUI(vgUI));
        }

        public async Task<bool> UpdateVareAsync(VareUI vUI)
        {
            if (!vValidator.ValidVare(vUI))
            {
                return false;
            }
            return await storeDA.UpdateVareAsync(modelConverter.ConvertFromVareUI(vUI));
        }

        public async Task<bool> UpdateVaregruppeAsync(UiModels.VaregruppeUI vgUI)
        {
            if (!vgValidator.ValidGroup(vgUI))
            {
                return false;
            }
            return await storeDA.UpdateVaregruppeAsync(modelConverter.ConvertFromVaregruppeUI(vgUI));
        }

        public async Task<bool> DeleteVareAsync(int id)
        {
            return await storeDA.DeleteVareAsync(id);
        }

        public async Task<bool> DeleteVaregruppeAsync(int id)
        {
            return await storeDA.DeleteVaregruppeAsync(id);
        }
    }
}
