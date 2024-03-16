using DataAccess;
using EntityModels;
using UiModels;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace BusinessLogic
{
    public class VareBL
    {
        VareDA vDA;
        ModelConverter modelConverter;
        Validation.VareValidator vValidator;

        public VareBL()
        {
            vDA = new VareDA();
            modelConverter = new ModelConverter();
        }

        public async Task<List<VareUI>> GetAsync()
        {
            List<VareUI> list = new List<VareUI>();
            foreach (Vare v in await vDA.GetAsync())
            {
                list.Add(modelConverter.ConvertFromVareEntity(v));
            }
            return list;
        }

        public async Task<VareUI> GetVareAsync(int id)
        {
            return modelConverter.ConvertFromVareEntity(await vDA.GetVareAsync(id));
        }

        public async Task<bool> CreateAsync(VareUI vUI)
        {
            if (!vValidator.ValidVare(vUI))
            {
                return false;
            }
            return await vDA.CreateAsync(modelConverter.ConvertFromVareUI(vUI));
        }
    }
}
