using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace traveliti
{
    public partial class HiddenGems : Form
    {
        public HiddenGems()
        {
            InitializeComponent();
        }

        private void HiddenGems_Load(object sender, EventArgs e)
        {

        }

        private void HiddenGems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                MainHomePage home = new MainHomePage();
                home.Show();
                this.Close();   // close HiddenGems
            }
        }
    }
}
