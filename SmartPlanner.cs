using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace traveliti
{
    public partial class SmartPlanner : Form
    {
        public SmartPlanner()
        {
            InitializeComponent();
        }

        private void btnSuggest_Click(object sender, EventArgs e)
        {
            int budget = int.Parse(txtbudget.Text);
            int days = int.Parse(txtday.Text);
            string type = traveltypecmb.Text;

            if (budget <= 5000 && days <= 2)
            {
                lblResult.Text = "Suggested Trip: Local City Tour";
            }
            else if (budget <= 1000 && type == "Solo")
            {
                lblResult.Text = "Suggested Trip: Aap Ghar mein raho";
            }
            else if (budget <= 1000 && type == "Family")
            {
                lblResult.Text = "Suggested Trip: really interested";
            }
            else if (budget <= 1000 && type == "Friends")
            {
                lblResult.Text = "Suggested Trip: Dosto ko bol ghar pe rahe";
            }

            else if (budget <= 10000 && type == "Solo")
            {
                lblResult.Text = "Suggested Trip: Pondicherry";
            }
            else if (budget <= 15000 && type == "Friends")
            {
                lblResult.Text = "Suggested Trip: Dost ko bol raste per bheekh maangne";
            }
            else if (budget <= 150000 && type == "Friends")
            {
                lblResult.Text = "Suggested Trip: Goa";
            }
            else if (budget > 20000 && type == "Family")
            {
                lblResult.Text = "Suggested Trip: Manali";
            }
            else
            {
                lblResult.Text = "Suggested Trip: Jaipur";
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            MainHomePage home = new MainHomePage();
            home.Show();
            this.Close();
        }

        private void weatherbutton_Click(object sender, EventArgs e)
        {
            Weather ws = new Weather();
            ws.Show();
            this.Hide();
        }
    }
}
