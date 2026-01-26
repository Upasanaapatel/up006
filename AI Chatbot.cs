using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace traveliti
{
    public partial class AI_Chatbot : Form
    {
        public AI_Chatbot()
        {
            InitializeComponent();
        }


        async Task<string> AskGemini(string userMessage)
        {
            // Gemini API code will be here
            return "This is a test reply from AI";
            string apiKey = "AIzaSyDX0CNqRhH3f0UjktsG4D6sIAVuUQrqbv8";

            string url =
            $"https://generativelanguage.googleapis.com/v1beta/models/gemini-pro:generateContent?key={apiKey}";

        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("Please type something");
                return;
            }

            string userMsg = txtUser.Text;

            chatBox.AppendText("You: " + userMsg + "\n");

            string reply = await AskGemini(userMsg);

            chatBox.AppendText("Agent: " + reply + "\n\n");

            txtUser.Clear();
        }

        private void btnAI_Click(object sender, EventArgs e)
        {
            AI_Chatbot bot = new AI_Chatbot();
            bot.Show();
            this.Hide();
        }
    }
}
