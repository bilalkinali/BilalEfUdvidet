using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class Varegruppe
    {
        public Varegruppe()
        {
            VareListe = new List<Vare>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Items { get; set; }
        public List<Vare> VareListe { get; set; }
    }
}
