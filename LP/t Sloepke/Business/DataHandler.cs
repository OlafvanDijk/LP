using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _t_Sloepke.DatabaseFolder;
using _t_Sloepke.Business.BootFolder;
using System.Windows.Forms;

namespace _t_Sloepke.Business
{
    public class DataHandler
    {
        public static string email = string.Empty;

        public static void Login(string email, string naam)
        {
            Database.Login(email, naam);
        }

        public static void LoginFail(string message)
        {
            MessageBox.Show(message);
        }

        public static List<HuurContract> getHuur()
        {
            return Database.getHuur();
        }

        public static List<HuurContract> getHuurH()
        {
            if (email != string.Empty)
            {
                return Database.getHuurH(email);
            }
            else
            {
                return null;
            }
        }

        public static void cHuurder(string email, string naam)
        {
            if (Database.cHuurder(email, naam) == false)
            {
                MessageBox.Show("Uw email bestaat al in onze database. Kies een andere email.");
            }
        }

        public static void createHuurContract(HuurContract huur)
        {
            if (Database.createHuurContract(huur) == false)
            {
                MessageBox.Show("Er ging iets fout :P.", "Man man man");
            }
        }

        public static void bootT(Boot boot)
        {
            if (Database.bootT(boot) == false)
            {
                MessageBox.Show("Er ging iets fout :P.", "Man man man");
            }
        }

        public static void bootV(string naam)
        {
            if (Database.bootV(naam) == false)
            {
                MessageBox.Show("Er ging iets fout :P.", "Man man man");
            }

        }

        public static void bootW(Boot boot, string orgNaam)
        {
            if (Database.bootW(boot, orgNaam) == false)
            {
                MessageBox.Show("Er ging iets fout :P.", "Man man man");
            }
        }

        public static void artT(string naam)
        {
            if (Database.artT(naam) == false)
            {
                MessageBox.Show("Er ging iets fout :P.", "Man man man");
            }
        }

        public static void artV(string naam)
        {
            if (Database.artV(naam) == false)
            {
                MessageBox.Show("Er ging iets fout :P.", "Man man man");
            }
        }

        public static void artW(string naam, string orgNaam)
        {
            if (Database.artW(naam, orgNaam) == false)
            {
                MessageBox.Show("Er ging iets fout :P.", "Man man man");
            }
        }

        public static int aantalMeren(int budget, List<Boot> boot, List<string> Art, string meren)
        {
            return 0;
        }

        public static List<Boot> getBoten()
        {
            return Database.getBoten();
        }

        public static List<string> getArtikelen()
        {
            return Database.getArtikelen();
        }
    }
}
