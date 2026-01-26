using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace traveliti
{
    public partial class Weather : UserControl
    {
        public Weather()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            string weather = cmbWeather.Text;

            if (weather == "Sunny")
            {
                lblWeatherResult.Text = "Best Destination: Goa / Beaches";
            }
            else if (weather == "Rainy")
            {
                lblWeatherResult.Text = "Best Destination: Jaipur / City Tour";
            }
            else if (weather == "Winter")
            {
                lblWeatherResult.Text = "Best Destination: Manali / Shimla";
            }
            else if (weather == "Cloudy")
            {
                lblWeatherResult.Text = "Best Destination: Lonavala";
            }
            else
            {
                lblWeatherResult.Text = "Please select weather";
            }

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
