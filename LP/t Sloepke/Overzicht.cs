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
using _t_Sloepke;

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

            if (HuurContractenA != null || HuurContractenB != null)
            {
                if (HuurContractenA.SelectedItem != null)
                {
                    a = (HuurContract)HuurContractenA.SelectedItem;
                }
                else
                {
                    a = (HuurContract)HuurContractenB.SelectedItem;
                }
                DataHandler.export(a);
            }
        }

        private void HuurContractenA_Click(object sender, EventArgs e)
        {
            if (HuurContractenB.SelectedItem != null)
            {
                HuurContractenB.SelectedItem = null;
            }
        }

        private void HuurContractenB_Click(object sender, EventArgs e)
        {
            if (HuurContractenA.SelectedItem != null)
            {
                HuurContractenA.SelectedItem = null;
            }
        }

        private void bttntemp_Click(object sender, EventArgs e)
        {
            gvlTmp.Items.Clear();
            HuurContract a;
            if (HuurContractenA.SelectedItem != null || HuurContractenB.SelectedItem != null)
            {
                if (HuurContractenA.SelectedItem != null)
                {
                    a = (HuurContract)HuurContractenA.SelectedItem;
                    DataHandler.temp();
                    DataHandler.checkdat(a);
                }
                else
                {
                    a = (HuurContract)HuurContractenB.SelectedItem;
                }
                DataHandler.temp();
                DataHandler.checkdat(a);
                foreach (string item in DataHandler.gevoel())
                {
                    gvlTmp.Items.Add(item);
                }
            }
        }

        private void bttnhome_Click(object sender, EventArgs e)
        {
            Home Home = (Home)Application.OpenForms["Home"];
            Home.Show();
            this.Close();
        }
    }
}

