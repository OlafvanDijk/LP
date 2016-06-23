﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _t_Sloepke.Business
{
    public class HuurContract
    {
        public List<string> boot { get; set; }

        public string email { get; set; }

        public DateTime datumVanaf { get; set; }

        public DateTime datumTot { get; set; }

        public List<string> artikelen { get; set; }

        public int HID { get; set; }

        public HuurContract(List<string> boot, string email, DateTime datumVanaf, DateTime datumTot, List<string> artikelen)
        {
            this.boot = boot;
            this.email = email;
            this.datumVanaf = datumVanaf;
            this.datumTot = datumTot;
            this.artikelen = artikelen;
        }

        public HuurContract(List<string> boot, string email, DateTime datumVanaf, DateTime datumTot, List<string> artikelen, int HID)
        {
            this.boot = boot;
            this.email = email;
            this.datumVanaf = datumVanaf;
            this.datumTot = datumTot;
            this.artikelen = artikelen;
            this.HID = HID;
        }

        public override string ToString()
        {
            return "boten: " + boot.Count + ", artikelen: " + artikelen.Count + ", " + datumVanaf.Date.ToShortDateString() + " - " + datumTot.Date.ToShortDateString();
        }
    }
}
