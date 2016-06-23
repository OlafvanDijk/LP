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
        public static decimal sluisgeld = 0;

        public static bool Login(string email, string naam)
        {
            if (Database.Login(email, naam) == false)
            {
                return false;
            }
            else
            {
                return true;
            }
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

        public static bool cHuurder(string email, string naam)
        {
            if (Database.cHuurder(email, naam) == false)
            {
                MessageBox.Show("Uw email bestaat al in onze database. Kies een andere email.");
                return false;
            }
            return true;
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

        public static int aantalMeren(decimal budget, decimal totaal)
        {
            int aantalmeren = 0;
            int counter1 = 5;
            while (budget > totaal && aantalmeren < 12)
            {
                if (budget >= totaal + Convert.ToDecimal(1.50))
                {
                    if (counter1 > 0)
                    {
                        aantalmeren++;
                        budget -= 1;
                        counter1--;
                    }

                    if (counter1 <= 0)
                    {
                        if (aantalmeren < 12)
                        {
                            aantalmeren++;
                            budget -= Convert.ToDecimal(1.50);
                            counter1--;
                        }
                    }
                }
                else if (counter1 > 0)
                {
                    if (budget >= (totaal + 1))
                    {
                        aantalmeren++;
                        budget -= 1;
                        counter1--;
                    }
                    else
                    {
                        budget = totaal;
                    }
                }
                else if (counter1 <= 0 && aantalmeren < 12)
                {
                    aantalmeren++;
                    budget = totaal;
                    counter1--;
                }
            }
            if (counter1 <= 0)
            {
                sluisgeld = (counter1 - counter1 - counter1 + 1) * Convert.ToDecimal(0.5);
            }
            else
            {
                sluisgeld = 0;
            }
            return aantalmeren;
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
