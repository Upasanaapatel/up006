using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace traveliti
{
    public partial class Budgetfriendly : Form
    {
        public Budgetfriendly()
        {
            InitializeComponent();
        }
        private void UncheckOthers(CheckBox selected)
        {
            CheckBox[] ranges =
            {
        chkUnder1000,
        chk1000_3000,
        chk3000_5000,
        chk5000_10000,
        chkLuxury
    };

            foreach (CheckBox chk in ranges)
            {
                if (chk != selected)
                    chk.Checked = false;
            }
        }

        private void Budgetfriendly_Load(object sender, EventArgs e)
        {

        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
           
            string transport = "";
            string stay = "";
            string trip = "";
            string budget = "";
            string extra = "";

            // TRANSPORT
            if (chkBus.Checked) transport += "Bus, ";
            if (chkCab.Checked) transport += "Cab, ";
            if (chkTrain.Checked) transport += "Train, ";
            if (chkBike.Checked) transport += "Bike Rental, ";
            if (chkFlight.Checked) transport += "Flight, ";

            // ACCOMMODATION
            if (chkHotel.Checked) stay += "Hotel, ";
            if (chkHomestay.Checked) stay += "Homestay, ";
            if (chkResort.Checked) stay += "Resort, ";
            if (chkCamp.Checked) stay += "Camps/Tents, ";
            if (chkApartment.Checked) stay += "Apartment, ";
            if (chkNoStay.Checked) stay += "No Stay Needed, ";

            // TRIP TYPE
            if (chkVacation.Checked) trip += "Vacation, ";
            if (chkEducation.Checked) trip += "Education, ";
            if (chkBusiness.Checked) trip += "Business, ";
            if (chkMedical.Checked) trip += "Medical, ";
            if (chkFestival.Checked) trip += "Festival/Event, ";

            // BUDGET RANGE
            if (chkUnder1000.Checked) budget = "Under ₹1,000/day";
            else if (chk1000_3000.Checked) budget = "₹1,000 – ₹3,000/day";
            else if (chk3000_5000.Checked) budget = "₹3,000 – ₹5,000/day";
            else if (chk5000_10000.Checked) budget = "₹5,000 – ₹10,000/day";
            else if (chkLuxury.Checked) budget = "Luxury ₹10,000+";
            else
            {
                MessageBox.Show("Please select your budget range.");
                return;
            }

            // EXTRA
            if (chkFree.Checked) extra += "Free Attractions\n";
            if (chkStudent.Checked) extra += "Student Budget\n";
            if (chkFamily.Checked) extra += "Family Budget\n";

            lblResult.Text =
                "TRANSPORT: " + transport + "\n\n" +
                "ACCOMMODATION: " + stay + "\n\n" +
                "TRIP TYPE: " + trip + "\n\n" +
                "BUDGET: " + budget + "\n\n" +
                "EXTRA:\n" + extra;
        }

        

        private void chkUnder1000_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUnder1000.Checked)
                UncheckOthers(chkUnder1000);
        }

        private void chk1000_3000_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1000_3000.Checked)
                UncheckOthers(chk1000_3000);
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk3000_5000_CheckedChanged(object sender, EventArgs e)
        {
            if (chk3000_5000.Checked)
                UncheckOthers(chk3000_5000);

        }

        private void chk5000_10000_CheckedChanged(object sender, EventArgs e)
        {
            if (chk5000_10000.Checked)
                UncheckOthers(chk5000_10000);

        }

        private void chkLuxury_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLuxury.Checked)
                UncheckOthers(chkLuxury);

        }
    }
}
