using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace traveliti
{
    public partial class PopularDesign : Form
    {
       
        Label[] labelsPlace;
        Label[] labelsPrice;
        Label[] labelsDays;
        PictureBox[] pictureBoxes;

        public PopularDesign()
        {
            InitializeComponent();
        }

        private void GoaButton_Click(object sender, EventArgs e)
        {

        }

        private void PopularDesign_Load(object sender, EventArgs e)
        {
            labelsPlace = new Label[] { label5, label12, label15, label21 };
            labelsPrice = new Label[] { label6, label13, label16, label22 };
            labelsDays = new Label[] { label7, label14, label17, label23 };

            pictureBoxes = new PictureBox[] { pictureBox1, pictureBox4 };

            string cs = ConfigurationManager
                        .ConnectionStrings["DBCS"]
                        .ConnectionString;

            SqlConnection con = new SqlConnection(cs);
            con.Open();

            SqlCommand cmd = new SqlCommand(
                "SELECT PlaceName, Price, Days, ImagePath FROM PopularPlaces", con);

            SqlDataReader dr = cmd.ExecuteReader();

            int i = 0;

            while (dr.Read())
            {
                labelsPlace[i].Text = dr["PlaceName"].ToString();
                labelsPrice[i].Text = dr["Price"].ToString();
                labelsDays[i].Text = dr["Days"].ToString();

                pictureBoxes[i].Image =
                    Image.FromFile(Application.StartupPath +
                    "\\Images\\" + dr["ImagePath"].ToString());

                i++;
            }

            con.Close();
        }

     
}
}
