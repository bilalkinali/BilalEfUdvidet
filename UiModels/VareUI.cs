using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UiModels
{
    public class VareUI
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int VaregruppeId { get; set; }
        public VaregruppeUI Varegruppe { get; set; }
    }
}
