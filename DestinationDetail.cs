using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace traveliti
{
    public partial class DestinationDetail : Form
    {
        public DestinationDetail(string city, string price, string days, string hotel, Image img)
        {
            InitializeComponent();

            lblPlace.Text = city;
            lblPrice.Text = price;
            lblDays.Text = days;
            lblHotel.Text = hotel;
            pictureBox1.Image = img;
        }

        private void DestinationDetail_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblPlace_Click(object sender, EventArgs e)
        {

        }
    }
}
