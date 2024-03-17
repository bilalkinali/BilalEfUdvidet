using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityModels;
using UiModels;

namespace BusinessLogic
{
    internal class ModelConverter
    {
        public ModelConverter() { }

        // VaregruppeUI                                                   --*
        public UiModels.VaregruppeUI ConvertFromVaregruppeEntity(EntityModels.Varegruppe vg)
        {
            UiModels.VaregruppeUI vgUI = new UiModels.VaregruppeUI
            {
                Id = vg.Id,
                Name = vg.Name,
                VareListe = vg.VareListe.Select(x => new VareUI
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Price = x.Price,
                    VaregruppeId = x.VaregruppeId
                }).ToList()
            };
            return vgUI;
        }

        public EntityModels.Varegruppe ConvertFromVaregruppeUI(UiModels.VaregruppeUI vgUI)
        {
            EntityModels.Varegruppe vg = new EntityModels.Varegruppe
            {
                Name = vgUI.Name
            };
            return vg;
        }

        // Vare                                                         --*

        public VareUI ConvertFromVareEntity(Vare v)
        {
            VareUI vUI = new VareUI
            {
                Id = v.Id,
                Name = v.Name,
                Description = v.Description,
                Price = v.Price,
                VaregruppeId = v.VaregruppeId
            };

            if (v.Varegruppe != null)
            {
                vUI.Varegruppe = ConvertFromVaregruppeEntity(v.Varegruppe);
            }
            return vUI;
        }

        public Vare ConvertFromVareUI(VareUI vUI)
        {
            Vare v = new Vare
            {
                Id = vUI.Id,
                Name = vUI.Name,
                Description = vUI.Description,
                Price = vUI.Price,
                VaregruppeId = vUI.VaregruppeId
            };

            //if (vUI.VaregruppeUI != null)
            //{
            //    v.VaregruppeUI = ConvertFromVaregruppeUI(vUI.VaregruppeUI);
            //}
            return v;
        }
    }
}
