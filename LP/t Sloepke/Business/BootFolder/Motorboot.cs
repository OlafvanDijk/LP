using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _t_Sloepke.Business.BootFolder
{
    public class Motorboot : Boot
    {
        public int tankInhoud { get; set; }

        public int actieRadius { get; private set; }

        public Motorboot(string naam, int prijs, int tankInhoud) : base(naam, prijs)
        {
            this.tankInhoud = tankInhoud;
            this.actieRadius = tankInhoud * 15;
        }
    }
}
