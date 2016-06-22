using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _t_Sloepke.Business.BootFolder
{
    public abstract class Boot
    {
        public string naam { get; set; }

        public int prijs { get; set; }

        public Boot(string naam, int prijs)
        {
            this.naam = naam;
            this.prijs = prijs;
        }
    }
}
