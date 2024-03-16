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

        // Varegruppe                                                   --*
        public VaregruppeUI ConvertFromVaregruppeEntity(Varegruppe vg)
        {
            VaregruppeUI vgUI = new VaregruppeUI
            {
                Id = vg.Id,
                Name = vg.Name,
            };
            return vgUI;
        }

        public Varegruppe ConvertFromVaregruppeUI(VaregruppeUI vgUI)
        {
            Varegruppe vg = new Varegruppe
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
            return vUI;
        }

        public Vare ConvertFromVareUI(VareUI vUI)
        {
            Vare v = new Vare
            {
                Name = vUI.Name,
                Description = vUI.Description,
                Price = vUI.Price,
                VaregruppeId = vUI.Id
            };
            return v;
        }
    }
}
