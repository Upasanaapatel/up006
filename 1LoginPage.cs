using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace traveliti
{
    public partial class LoginPage : Form
    {
        string conStr = @"Data Source=localhost\SQLEXPRESS;
                          Initial Catalog=traveliti;
                          Integrated Security=True";
        private object con;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            string conStr = @"Data Source=localhost\SQLEXPRESS;
                      Initial Catalog=traveliti;
                      Integrated Security=True";

            using var con = new SqlConnection(conStr);
            {
                string query = "SELECT COUNT(*) FROM LoginUsers WHERE Username=@u AND Password=@p";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@u", txtusername.Text.Trim());
                cmd.Parameters.AddWithValue("@p", txtpassword.Text.Trim());

                con.Open();
                int result = (int)cmd.ExecuteScalar();

                if (result == 1)
                {
                    MessageBox.Show("Login Successful");

                    MainHomePage home = new MainHomePage();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Registerbutton_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection con = new SqlConnection(conStr))
            {
                // 1️⃣ Check username already exists
                string checkQuery = "SELECT COUNT(*) FROM LoginUsers WHERE Username = @u";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@u", txtusername.Text.Trim());

                con.Open();
                int userExists = (int)checkCmd.ExecuteScalar();

                if (userExists > 0)
                {
                    MessageBox.Show("Username already exists. Please choose another.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                // 2️⃣ Insert new user
                string insertQuery =
                    "INSERT INTO LoginUsers (Username, Password) VALUES (@u, @p)";

                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@u", txtusername.Text.Trim());
                cmd.Parameters.AddWithValue("@p", txtpassword.Text.Trim());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Registration Successful!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            
        }

    }
}
}
