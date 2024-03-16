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
    }
}
