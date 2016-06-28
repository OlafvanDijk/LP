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
using t_Sloepke;

namespace _t_Sloepke
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bttnLogin_Click(object sender, EventArgs e)
        {
            if (DataHandler.Login(txtEmail.Text, txtNaam.Text) == true)
            {
                DataHandler.email = txtEmail.Text;
                Huur_menu huurmenu = new Huur_menu();
                huurmenu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Geen account gevonden");
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
