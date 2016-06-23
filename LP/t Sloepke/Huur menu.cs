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
using _t_Sloepke.Business.BootFolder;

namespace t_Sloepke
{
    public partial class Huur_menu : Form
    {
        int prijsbootpd;
        double prijsartpd;

        public Huur_menu()
        {
            InitializeComponent();
            foreach (Boot boot in DataHandler.getBoten())
            {
                BotenL.Items.Add(boot);
            }
            foreach (string artikel in DataHandler.getArtikelen())
            {
                ArtL.Items.Add(artikel);
            }

            DateV.Value = DateTime.Now;
            DateT.Value = DateTime.Now;
        }

        private void BootNR_Click(object sender, EventArgs e)
        {
            if (budget.Value != 0)
            {
                if (BotenL.SelectedItem != null)
                {
                    BotenR.Items.Add(BotenL.SelectedItem);
                    Boot boot = (Boot)BotenL.SelectedItem;
                    prijsbootpd += boot.prijs;
                    lblkostenboot.Text = "€" + prijsbootpd.ToString() + ",-";
                    BotenL.Items.Remove(BotenL.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Selecteer eerst een boot.");
                }
            }
            else
            {
                MessageBox.Show("Vul eerst een budget in.");
            }
        }

        private void BootNL_Click(object sender, EventArgs e)
        {
            if (BotenR.SelectedItem != null)
            {
                BotenL.Items.Add(BotenR.SelectedItem);
                Boot boot = (Boot)BotenR.SelectedItem;
                prijsbootpd -= boot.prijs;
                lblkostenboot.Text = "€" + prijsbootpd.ToString() + ",-";
                BotenR.Items.Remove(BotenR.SelectedItem);
            }
            else
            {
                MessageBox.Show("Selecteer eerst een boot.");
            }
        }

        private void BotenR_Click(object sender, EventArgs e)
        {
            if (BotenL.SelectedItem != null)
            {
                BotenL.SetSelected(BotenL.SelectedIndex, false);
            }
        }

        private void BotenL_Click(object sender, EventArgs e)
        {
            if (BotenR.SelectedItem != null)
            {
                BotenR.SetSelected(BotenR.SelectedIndex, false);
            }
        }

        private void ArtNR_Click(object sender, EventArgs e)
        {
            if (budget.Value != 0)
            {
                if (ArtL.SelectedItem != null)
                {
                    ArtR.Items.Add(ArtL.SelectedItem);
                    prijsartpd = ArtR.Items.Count * 1.25;
                    lblkostenart.Text = "€" + prijsartpd.ToString() + ",-";
                    ArtL.Items.Remove(ArtL.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Selecteer eerst een artikel.");
                }
            }
            else
            {
                MessageBox.Show("Vul eerst een budget in.");
            }
        }

        private void ArtNL_Click(object sender, EventArgs e)
        {
            if (ArtR.SelectedItem != null)
            {
                ArtL.Items.Add(ArtR.SelectedItem);
                ArtR.Items.Remove(ArtR.SelectedItem);
                prijsartpd = ArtR.Items.Count * 1.25;
                lblkostenart.Text = "€" + prijsartpd.ToString() + ",-";
            }
            else
            {
                MessageBox.Show("Selecteer eerst een artikel.");
            }
        }

        private void ArtL_Click(object sender, EventArgs e)
        {
            if (ArtR.SelectedItem != null)
            {
                ArtR.SetSelected(ArtR.SelectedIndex, false);
            }
        }

        private void ArtR_Click(object sender, EventArgs e)
        {
            if (ArtL.SelectedItem != null)
            {
                ArtL.SetSelected(ArtL.SelectedIndex, false);
            }
        }

        private void BotenL_DoubleClick(object sender, EventArgs e)
        {
            if (BotenL.SelectedItem != null)
            {
                Boot boot = (Boot)BotenL.SelectedItem;
                Type a = boot.GetType();
                if (a == typeof(Spierkrachtboot))
                {
                    Spierkrachtboot bootje = (Spierkrachtboot)boot;
                    MessageBox.Show(bootje.naam + " €" + bootje.prijs.ToString() + ",- per dag.");
                }
                else if (a == typeof(Motorboot))
                {
                    Motorboot bootje = (Motorboot)boot;
                    MessageBox.Show(bootje.naam + " €" + bootje.prijs.ToString() + ",- per dag." + Environment.NewLine + "Tankinhoud: " + bootje.tankInhoud.ToString() + ", Actie radius: " + bootje.actieRadius.ToString());
                }
            }
        }

        private void bttnBdagen_Click(object sender, EventArgs e)
        {
            if (DateT.Value.Date >= DateV.Value.Date)
            {
                TimeSpan days = DateT.Value.Date - DateV.Value.Date;
                lbldagen.Text = "Aantal dagen: " + Convert.ToInt32(days.Days + 1).ToString();
            }
            else
            {
                MessageBox.Show("U kunt niet terug in de tijd. Verrander de datums.");
            }
        }

        private void bttnBereken_Click(object sender, EventArgs e)
        {
            if (budget.Value != 0)
            {
                int dagen;
                double totaal;
                int vaar = 0;
                int aantalmeren = 0;
                if (DateT.Value.Date >= DateV.Value.Date)
                {
                    TimeSpan days = DateT.Value.Date - DateV.Value.Date;
                    dagen = Convert.ToInt32(days.Days + 1);
                    if (IJsselmeercheck.Checked)
                    {
                        vaar = dagen * 2;
                    }
                    if (Noordzeecheck.Checked)
                    {
                        vaar = vaar + (dagen * 2);
                    }
                    totaal = (prijsartpd * dagen) + (prijsbootpd * dagen) + vaar;
                    aantalmeren = DataHandler.aantalMeren(budget.Value, totaal);
                    lblaantalf.Text = lblaantalf.Text + aantalmeren;
                }
                else
                {
                    MessageBox.Show("U kunt niet terug in de tijd. Verrander de datums.");
                }
            }
            else
            {
                MessageBox.Show("Vul een budget in.");
            }
        }
    }
}
