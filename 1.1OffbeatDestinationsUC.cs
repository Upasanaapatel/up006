using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace traveliti
{
    public partial class OffbeatDestinationsUC : Form
    {
        public OffbeatDestinationsUC()
        {

        }

        private void InitializeComponent()
        {
            toppanel = new Panel();
            labelTagline = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel3 = new Panel();
            contactbutton = new Button();
            itinbutton = new Button();
            menubuuton = new Button();
            historybutton = new Button();
            aboutbutton = new Button();
            Menubutton = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            GoaButton = new Button();
            label2 = new Label();
            label1 = new Label();
            leftpanel = new Panel();
            genitinbutton = new Button();
            button3 = new Button();
            toppanel.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            leftpanel.SuspendLayout();
            SuspendLayout();
            // 
            // toppanel
            // 
            toppanel.BackColor = Color.White;
            toppanel.Controls.Add(labelTagline);
            toppanel.Controls.Add(label3);
            toppanel.Controls.Add(label4);
            toppanel.Controls.Add(pictureBox1);
            toppanel.Dock = DockStyle.Top;
            toppanel.ImeMode = ImeMode.Katakana;
            toppanel.Location = new Point(0, 0);
            toppanel.Name = "toppanel";
            toppanel.Size = new Size(1251, 73);
            toppanel.TabIndex = 7;
            toppanel.UseWaitCursor = true;
            // 
            // labelTagline
            // 
            labelTagline.AutoSize = true;
            labelTagline.ForeColor = Color.Navy;
            labelTagline.Location = new Point(116, 41);
            labelTagline.Name = "labelTagline";
            labelTagline.Size = new Size(148, 15);
            labelTagline.TabIndex = 4;
            labelTagline.Text = "Your Perfect Escape Awaits";
            labelTagline.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 36);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 3;
            label3.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AccessibleRole = AccessibleRole.MenuBar;
            label4.AllowDrop = true;
            label4.AutoEllipsis = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 192);
            label4.Location = new Point(84, 9);
            label4.Name = "label4";
            label4.Size = new Size(304, 42);
            label4.TabIndex = 2;
            label4.Text = "Travel Itinerary";
            label4.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.travel;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(GoaButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(leftpanel);
            panel1.Controls.Add(button3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(1251, 547);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // panel3
            // 
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Controls.Add(contactbutton);
            panel3.Controls.Add(itinbutton);
            panel3.Controls.Add(menubuuton);
            panel3.Controls.Add(historybutton);
            panel3.Controls.Add(aboutbutton);
            panel3.Controls.Add(Menubutton);
            panel3.Cursor = Cursors.Hand;
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(110, 547);
            panel3.TabIndex = 19;
            // 
            // contactbutton
            // 
            contactbutton.BackColor = SystemColors.MenuHighlight;
            contactbutton.Dock = DockStyle.Top;
            contactbutton.FlatStyle = FlatStyle.Popup;
            contactbutton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactbutton.ForeColor = Color.White;
            contactbutton.Location = new Point(0, 178);
            contactbutton.Name = "contactbutton";
            contactbutton.Size = new Size(110, 34);
            contactbutton.TabIndex = 6;
            contactbutton.Text = "Contact";
            contactbutton.UseVisualStyleBackColor = false;
            // 
            // itinbutton
            // 
            itinbutton.BackColor = SystemColors.MenuHighlight;
            itinbutton.Dock = DockStyle.Top;
            itinbutton.FlatStyle = FlatStyle.Popup;
            itinbutton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itinbutton.ForeColor = Color.White;
            itinbutton.Location = new Point(0, 141);
            itinbutton.Name = "itinbutton";
            itinbutton.Size = new Size(110, 37);
            itinbutton.TabIndex = 5;
            itinbutton.Text = "📅Itinerary";
            itinbutton.UseVisualStyleBackColor = false;
            // 
            // menubuuton
            // 
            menubuuton.BackColor = SystemColors.MenuHighlight;
            menubuuton.Dock = DockStyle.Top;
            menubuuton.FlatStyle = FlatStyle.Popup;
            menubuuton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menubuuton.ForeColor = Color.White;
            menubuuton.Location = new Point(0, 106);
            menubuuton.Name = "menubuuton";
            menubuuton.Size = new Size(110, 35);
            menubuuton.TabIndex = 4;
            menubuuton.Text = "\U0001f9ed Menu";
            menubuuton.UseVisualStyleBackColor = false;
            // 
            // historybutton
            // 
            historybutton.BackColor = SystemColors.MenuHighlight;
            historybutton.Dock = DockStyle.Top;
            historybutton.FlatStyle = FlatStyle.Popup;
            historybutton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            historybutton.ForeColor = Color.White;
            historybutton.Location = new Point(0, 72);
            historybutton.Name = "historybutton";
            historybutton.Size = new Size(110, 34);
            historybutton.TabIndex = 3;
            historybutton.Text = "📜 History";
            historybutton.UseVisualStyleBackColor = false;
            // 
            // aboutbutton
            // 
            aboutbutton.BackColor = SystemColors.MenuHighlight;
            aboutbutton.Dock = DockStyle.Top;
            aboutbutton.FlatStyle = FlatStyle.Popup;
            aboutbutton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aboutbutton.ForeColor = Color.White;
            aboutbutton.Location = new Point(0, 37);
            aboutbutton.Name = "aboutbutton";
            aboutbutton.Size = new Size(110, 35);
            aboutbutton.TabIndex = 2;
            aboutbutton.Text = "ℹ   About";
            aboutbutton.UseVisualStyleBackColor = false;
            aboutbutton.Click += aboutbutton_Click;
            // 
            // Menubutton
            // 
            Menubutton.BackColor = SystemColors.MenuHighlight;
            Menubutton.Dock = DockStyle.Top;
            Menubutton.FlatStyle = FlatStyle.Popup;
            Menubutton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Menubutton.ForeColor = Color.White;
            Menubutton.Location = new Point(0, 0);
            Menubutton.Name = "Menubutton";
            Menubutton.Size = new Size(110, 37);
            Menubutton.TabIndex = 1;
            Menubutton.Text = "🏠 Home";
            Menubutton.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSalmon;
            button4.BackgroundImage = Properties.Resources.ChatGPT_Image_Jan_20__2026__02_23_01_AM;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(297, 248);
            button4.Name = "button4";
            button4.Size = new Size(172, 102);
            button4.TabIndex = 18;
            button4.Text = "Landmark Mounments";
            button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSalmon;
            button2.BackgroundImage = Properties.Resources.ChatGPT_Image_Jan_20__2026__02_13_03_AM;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(116, 248);
            button2.Name = "button2";
            button2.Size = new Size(175, 102);
            button2.TabIndex = 17;
            button2.Text = "Secluded Place";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSalmon;
            button1.BackgroundImage = Properties.Resources.ChatGPT_Image_Jan_20__2026__02_12_27_AM;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(297, 137);
            button1.Name = "button1";
            button1.Size = new Size(172, 105);
            button1.TabIndex = 16;
            button1.Text = "Wonder";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(116, 106);
            label5.Name = "label5";
            label5.Size = new Size(158, 22);
            label5.TabIndex = 15;
            label5.Text = "Destination Cards";
            // 
            // GoaButton
            // 
            GoaButton.BackColor = Color.MediumBlue;
            GoaButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GoaButton.ForeColor = Color.White;
            GoaButton.ImageAlign = ContentAlignment.BottomCenter;
            GoaButton.Location = new Point(123, 56);
            GoaButton.Name = "GoaButton";
            GoaButton.Size = new Size(175, 37);
            GoaButton.TabIndex = 14;
            GoaButton.Text = "Add Details";
            GoaButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateBlue;
            label2.Location = new Point(116, 34);
            label2.Name = "label2";
            label2.Size = new Size(323, 19);
            label2.TabIndex = 11;
            label2.Text = "Welcome to your most precious incredible Field";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(106, 3);
            label1.Name = "label1";
            label1.Size = new Size(158, 31);
            label1.TabIndex = 10;
            label1.Text = "Welcome!!!! ";
            label1.Click += label1_Click;
            // 
            // leftpanel
            // 
            leftpanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            leftpanel.BackColor = Color.White;
            leftpanel.BackgroundImageLayout = ImageLayout.Center;
            leftpanel.Controls.Add(genitinbutton);
            leftpanel.Cursor = Cursors.Hand;
            leftpanel.Dock = DockStyle.Right;
            leftpanel.Location = new Point(1116, 0);
            leftpanel.Name = "leftpanel";
            leftpanel.Size = new Size(135, 547);
            leftpanel.TabIndex = 9;
            // 
            // genitinbutton
            // 
            genitinbutton.BackColor = SystemColors.HotTrack;
            genitinbutton.Dock = DockStyle.Top;
            genitinbutton.FlatStyle = FlatStyle.Popup;
            genitinbutton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            genitinbutton.ForeColor = Color.White;
            genitinbutton.Location = new Point(0, 0);
            genitinbutton.Name = "genitinbutton";
            genitinbutton.Size = new Size(135, 37);
            genitinbutton.TabIndex = 5;
            genitinbutton.Text = "📅 Generate Itinerary";
            genitinbutton.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSalmon;
            button3.BackgroundImage = Properties.Resources.ChatGPT_Image_Jan_20__2026__02_09_31_AM;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(116, 137);
            button3.Name = "button3";
            button3.Size = new Size(175, 105);
            button3.TabIndex = 8;
            button3.Text = "Haunted Place";
            button3.UseVisualStyleBackColor = false;
            // 
            // OffbeatDestinationsUC
            // 
            ClientSize = new Size(1251, 620);
            Controls.Add(panel1);
            Controls.Add(toppanel);
            Name = "OffbeatDestinationsUC";
            toppanel.ResumeLayout(false);
            toppanel.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            leftpanel.ResumeLayout(false);
            ResumeLayout(false);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private Panel toppanel;
        private Label labelTagline;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button3;
        private Panel leftpanel;
        private Button genitinbutton;
        private Label label2;
        private Label label1;
        private Button GoaButton;
        private Button button4;
        private Button button2;
        private Button button1;
        private Label label5;
        private Panel panel3;
        private Button contactbutton;
        private Button itinbutton;
        private Button menubuuton;
        private Button historybutton;
        private Button aboutbutton;
        private Button Menubutton;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aboutbutton_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
            this.Hide();
        }
    }
}
