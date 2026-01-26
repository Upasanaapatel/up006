using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Text;
using System.Windows.Forms;
using traveliti;
using System.Configuration;
using System.Data.SqlClient;


namespace traveliti
{


    public partial class Popular : Form
    {
        List<PlaceData> places = new List<PlaceData>();

        public Popular()
        {
            InitializeComponent();
        }
        void ShowDetails(string place, string price, string days, string hotel, PictureBox pic)
        {
            DestinationDetail f = new DestinationDetail(place, price, days, hotel, pic.Image);
            f.ShowDialog();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            MainHomePage home = new MainHomePage();
            home.Show();

            // Close current Offbeat page
            this.Close();
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Popular_Load(object sender, EventArgs e)
        {

        }
        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel16_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void GoaButton_Click(object sender, EventArgs e)
        {
            ShowDetails("Goa", "₹12,000", "3 Days / 2 Nights", "Hotel Taj", pictureBox1);

        }

        private void Manalibutton_Click(object sender, EventArgs e)
        {
            ShowDetails("Manali", "₹18,000", "4 Days / 3 Nights", "Snow Resort", pictureBox2);

        }

        private void jaaipurbutton_Click(object sender, EventArgs e)
        {
            ShowDetails("Jaipur", "₹11,000", "3 Days / 2 Nights", "Royal Palace Hotel", pictureBox4);

        }

        private void keralabutton_Click(object sender, EventArgs e)
        {
            ShowDetails("Kerala", "₹14,000", "3 Days / 2 Nights", "Backwater Resort", pictureBox3);

        }

        private void Delhibutton_Click(object sender, EventArgs e)
        {
            ShowDetails("Delhi", "₹9,000", "2 Days / 1 Night", "City Inn", pictureBox5);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void shimlabutton_Click(object sender, EventArgs e)
        {
            ShowDetails("Shimla", "₹16,000", "4 Days / 3 Nights", "Hill View Resort", pictureBox6);

        }

        private void agrabutton_Click(object sender, EventArgs e)
        {
            ShowDetails("Agra", "₹10,000", "2 Days / 1 Night", "Taj View Hotel", pictureBox7);

        }

        private void udaipur_Click(object sender, EventArgs e)
        {
            ShowDetails("Udaipur", "₹13,000", "3 Days / 2 Nights", "Lake View Resort", pictureBox9);

        }

        private void darjeelin_Click(object sender, EventArgs e)
        {
            ShowDetails("Darjeeling", "₹17,000", "4 Days / 3 Nights", "Tea Garden Resort", pictureBox10);

        }

        private void rsishikesh_Click(object sender, EventArgs e)
        {
            ShowDetails("Rishikesh", "₹12,500", "3 Days / 2 Nights", "River Side Camp", pictureBox11);

        }

        private void ooty_Click(object sender, EventArgs e)
        {
            ShowDetails("Ooty", "₹15,000", "4 Days / 3 Nights", "Hill Breeze Hotel", pictureBox12);

        }

        private void Popular_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            int index = Convert.ToInt32(b.Tag);

            PlaceData p = places[index];
            ShowDetails(p.Place, p.Price, p.Days, p.Hotel, p.Pic);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MainHomePage next = new MainHomePage();
            next.Show();
            this.Hide();
        }
    }
}
