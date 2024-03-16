using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UiModels
{
    public class VaregruppeUI
    {
        public VaregruppeUI()
        {
            VareListe = new List<VareUI>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<VareUI> VareListe { get; set; }
    }
}
