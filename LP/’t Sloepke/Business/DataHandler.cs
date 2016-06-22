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
        public static string email;

        public void Login(string email, string naam)
        {
            Database.Login(email, naam);
        }

        public static void LoginFail(string message)
        {
            MessageBox.Show(message);
        }

        public List<HuurContract> getHuur()
        {
            return null;
        }

        public List<HuurContract> getHuurH()
        {
            return null;
        }

        public void createHuur(string email, string naam)
        {

        }

        public void createHuurContract(HuurContract huur)
        {
            
        }

        public void bootT(Boot boot)
        {

        }

        public void bootV(string naam)
        {

        }

        public void bootW(Boot boot, string orgNaam)
        {

        }

        public void artT(string naam)
        {

        }

        public void artV(string naam)
        {

        }

        public void artW(string naam, string orgNaam)
        {

        }

        public int aantalMeren(int budget, Boot boot, int aantalArt)
        {
            return 0;
        }

        public List<Boot> getBoten()
        {
            return null;
        }

        public List<string> getArtikelen()
        {
            return null;
        }
    }
}
