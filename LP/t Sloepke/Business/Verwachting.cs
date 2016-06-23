using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t_Sloepke.Business
{
    public class Verwachting
    {
        public DateTime date { get; set; }

        public int temperatuur { get; set; }

        public int windsnelheid { get; set; }

        public Verwachting(DateTime date, int temperatuur, int windsnelheid)
        {
            this.date = date;
            this.temperatuur = temperatuur;
            this.windsnelheid = windsnelheid;
        }
    }
}
