using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace traveliti
{

    public partial class MainHomePage : Form
    {
        public MainHomePage()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += MainHomePage_KeyDown;
        }

        public void LoadUserControl(UserControl uc)
        {
            midpanel.Controls.Clear();   // your main panel name
            uc.Dock = DockStyle.Fill;
            midpanel.Controls.Add(uc);
            midpanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            midpanel.Controls.Add(uc);
        }

        private void rightpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menubutton_Click(object sender, EventArgs e)
        {
            MainHomePage home = new MainHomePage();
            home.Show();
            this.Close();
        }

        private void menubuuton_Click(object sender, EventArgs e)
        {
            MainHomePage home = new MainHomePage();
            home.Show();
            this.Close();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            MainHomePage home = new MainHomePage();
            home.Show();
            this.Close();
        }

        private void OFFBEAT_Click(object sender, EventArgs e)
        {
            OffbeatDestinationsUC off = new OffbeatDestinationsUC();
            off.Show();
            this.Hide();
        }

        private void POPULARBUTTON_Click(object sender, EventArgs e)
        {
            Popular pop = new Popular();
            pop.Show();
            this.Hide();
        }

        private void budgetbutton_Click(object sender, EventArgs e)
        {
            Budgetfriendly bud = new Budgetfriendly();
            bud.Show();
            this.Hide();
        }

        private void hiddengembutton_Click(object sender, EventArgs e)
        {
            HiddenGems pop = new HiddenGems();
            pop.Show();
            this.Hide();
        }

        private void aboutbutton_Click(object sender, EventArgs e)
        {
            About off = new About();
            off.Show();
            this.Hide();
        }

        private void historybutton_Click(object sender, EventArgs e)
        {

        }

        private void itinbutton_Click(object sender, EventArgs e)
        {

        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            LoginPage log = new LoginPage(); // if this is Form
            log.Show();
            this.Hide();
        }

        private void midpanel_Paint(object sender, PaintEventArgs e)
        {

        }



        private void smartplanner_Click_1(object sender, EventArgs e)
        {

            SmartPlanner sp = new SmartPlanner();
            sp.Show();
            this.Hide();
        }

        private void MainHomePage_Load(object sender, EventArgs e)
        {


        }

        private void MainHomePage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                MainHomePage next = new MainHomePage();
                next.Show();
                this.Hide();
            }
        }

        private void toppanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void POPULARBUTTON_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                MainHomePage next = new MainHomePage();
                next.Show();
                this.Hide();
            }
        }
    }
}
