using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Business.BootFolder.Motorboot boot = new Business.BootFolder.Motorboot("hoi", 4, 3);
            DatabaseFolder.Database.bootT(boot);
            //this.Hide();
            //Login login = new Login();
            //login.Show();
        }

        private void bttnBoot_Click(object sender, EventArgs e)
        {
            Business.BootFolder.Spierkrachtboot boot = new Business.BootFolder.Spierkrachtboot("hoi", 4);
            DatabaseFolder.Database.bootT(boot);
        }
    }
}
