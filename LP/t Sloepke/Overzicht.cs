using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _t_Sloepke.Business;
using System.IO;
using _t_Sloepke.Business.BootFolder;

namespace t_Sloepke
{
    public partial class Overzicht : Form
    {
        public Overzicht()
        {
            InitializeComponent();
            foreach (HuurContract HC in DataHandler.getHuur())
            {
                HuurContractenA.Items.Add(HC);
            }
            if (DataHandler.email != string.Empty)
            {
                foreach (HuurContract HC in DataHandler.getHuurH())
                {
                    HuurContractenB.Items.Add(HC);
                }
            }
        }

        private void bttnexp_Click(object sender, EventArgs e)
        {
            HuurContract a;
            bool check = false;
            if (HuurContractenA != null || HuurContractenB != null)
            {
                try
                {
                    if (HuurContractenA.SelectedItem != null)
                    {
                        a = (HuurContract)HuurContractenA.SelectedItem;
                    }
                    else
                    {
                        a = (HuurContract)HuurContractenA.SelectedItem;
                    }
                    string boten = string.Empty;
                    string artikelen = string.Empty;
                    foreach (string boot in a.boot)
                    {
                        boten = boot + " ";
                    }
                    foreach (string artikel in a.artikelen)
                    {
                        artikelen = artikel + " ";
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
}

