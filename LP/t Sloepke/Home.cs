using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _t_Sloepke.Business.BootFolder;
using _t_Sloepke.Business;
using t_Sloepke;

namespace _t_Sloepke
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void bttnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void bttnBoot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Huur_menu huurmenu = new Huur_menu();
            huurmenu.Show();
        }

        private void bttnoverzicht_Click(object sender, EventArgs e)
        {
            this.Hide();
            Overzicht overzicht = new Overzicht();
            overzicht.Show();
        }
    }
}
