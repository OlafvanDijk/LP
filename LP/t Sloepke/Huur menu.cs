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
        public Huur_menu()
        {
            InitializeComponent();
            foreach (Boot boot in DataHandler.getBoten())
            {
                BotenL.Items.Add(boot);
            }
        }

        private void BootNR_Click(object sender, EventArgs e)
        {
            if (BotenL.SelectedItem != null)
            {
                BotenR.Items.Add(BotenL.SelectedItem);
                BotenL.Items.Remove(BotenL.SelectedItem);
            }
            else
            {
                MessageBox.Show("Selecteer eerst een boot.");
            }
        }

        private void BootNL_Click(object sender, EventArgs e)
        {
            if (BotenR.SelectedItem != null)
            {
                BotenL.Items.Add(BotenR.SelectedItem);
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
            if (ArtL.SelectedItem != null)
            {
                ArtR.Items.Add(ArtL.SelectedItem);
                ArtL.Items.Remove(ArtL.SelectedItem);
            }
            else
            {
                MessageBox.Show("Selecteer eerst een artikel.");
            }
        }

        private void ArtNL_Click(object sender, EventArgs e)
        {
            if (ArtR.SelectedItem != null)
            {
                ArtL.Items.Add(ArtR.SelectedItem);
                ArtR.Items.Remove(ArtR.SelectedItem);
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
    }
}
