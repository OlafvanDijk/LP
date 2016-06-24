using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _t_Sloepke.DatabaseFolder;
using _t_Sloepke.Business.BootFolder;
using System.Windows.Forms;
using t_Sloepke;
using System.IO;
using t_Sloepke.Business;

namespace _t_Sloepke.Business
{
    public class DataHandler
    {
        public static string email = string.Empty;
        public static decimal sluisgeld = 0;
        private static List<Verwachting> verwachtingen = new List<Verwachting>();
        public static List<Verwachting> gebruiken = new List<Verwachting>();

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

        public static void temp()
        {
            verwachtingen.Clear();
            bool check = false;
            try
            {
                string boten = string.Empty;
                string artikelen = string.Empty;
                using (var streamReader = File.OpenText("../../Temperatuur/verwachting.txt"))
                {
                    var lines = streamReader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    foreach (var line in lines)
                    {
                        string[] lin = line.Split(';');
                        foreach (var item in lin)
                        {
                            item.Trim(';');
                        }
                        Verwachting verwachting = new Verwachting(Convert.ToDateTime(lin[0]), Convert.ToInt32(lin[1]), Convert.ToInt32(lin[2]));
                        verwachtingen.Add(verwachting);
                    }
                }
                check = true;
            }
            catch (IOException)
            {
                check = false;
                MessageBox.Show("Het bestand is niet uitgelezen. Er ging iets fout.");
            }
        }

        public static void checkdat(HuurContract a)
        {
            gebruiken.Clear();
            foreach (Verwachting ver in verwachtingen)
            {
                if (a.datumVanaf.Date >= ver.date.Date && a.datumVanaf.Date <= ver.date.Date)
                {
                    if (gebruiken.Contains(ver))
                    {

                    }
                    else
                    {
                        gebruiken.Add(ver);
                    }
                }
                if (a.datumTot.Date >= ver.date.Date && a.datumTot.Date <= ver.date.Date)
                {
                    if (gebruiken.Contains(ver))
                    {

                    }
                    else
                    {
                        gebruiken.Add(ver);
                    }
                }
            }
        }

        public static List<string> gevoel()
        {
            List<string> gevoels = new List<string>();
            foreach (Verwachting item in gebruiken)
            {
                double i = 33 + (item.temperatuur - 33) * (0.474 + 0.454 * (Math.Round(Math.Sqrt(item.windsnelheid))) - 0.0454 * item.windsnelheid);
                string gevoelstemp = item.date + " " + i;
                gevoels.Add(gevoelstemp);
            }
            return gevoels;
        }

        public static void export(HuurContract a)
        {
            bool check = false;
            try
            {
                string boten = string.Empty;
                string artikelen = string.Empty;
                foreach (string boot in a.boot)
                {
                    boten = boten + boot + " ";
                }
                foreach (string artikel in a.artikelen)
                {
                    artikelen = artikelen + artikel + " ";
                }
                FileStream file = new FileStream("../../../Huurcontracten/HuurContract" + a.HID + ".txt", FileMode.Create, FileAccess.Write);
                StreamWriter fileWriter = new StreamWriter(file);
                fileWriter.WriteLine("Boten: " + boten);
                fileWriter.WriteLine("Artikelen: " + artikelen);
                fileWriter.WriteLine("Verhuurder: " + a.email);
                fileWriter.WriteLine("Huur periode: " + a.datumVanaf.Date.ToShortDateString() + " - " + a.datumTot.Date.ToShortDateString());
                fileWriter.Flush();
                fileWriter.Close();
                check = true;
            }
            catch (IOException)
            {
                check = false;
                MessageBox.Show("Het bestand is niet aangemaakt. Er ging iets fout.");
            }

            if (check == true)
            {
                MessageBox.Show("Het bestand is succesvol aangemaakt.");
            }
        }
    }
}
