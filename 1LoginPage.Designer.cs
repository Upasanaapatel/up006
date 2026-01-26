namespace traveliti
{
    partial class LoginPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            Registerbutton = new Button();
            passwordlbel = new Label();
            userlabel = new Label();
            txtusername = new TextBox();
            exitbutton = new Button();
            txtpassword = new TextBox();
            Loginbutton = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1370, 137);
            panel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.travel;
            pictureBox1.Location = new Point(539, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaption;
            panel6.Controls.Add(Registerbutton);
            panel6.Controls.Add(passwordlbel);
            panel6.Controls.Add(userlabel);
            panel6.Controls.Add(txtusername);
            panel6.Controls.Add(exitbutton);
            panel6.Controls.Add(txtpassword);
            panel6.Controls.Add(Loginbutton);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 137);
            panel6.Name = "panel6";
            panel6.Size = new Size(1370, 588);
            panel6.TabIndex = 5;
            // 
            // Registerbutton
            // 
            Registerbutton.BackColor = Color.Green;
            Registerbutton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Registerbutton.Location = new Point(604, 286);
            Registerbutton.Name = "Registerbutton";
            Registerbutton.Size = new Size(127, 40);
            Registerbutton.TabIndex = 7;
            Registerbutton.Text = "REGISTER";
            Registerbutton.UseVisualStyleBackColor = false;
            Registerbutton.Click += Registerbutton_Click;
            // 
            // passwordlbel
            // 
            passwordlbel.AutoSize = true;
            passwordlbel.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordlbel.Location = new Point(562, 250);
            passwordlbel.Name = "passwordlbel";
            passwordlbel.Size = new Size(66, 17);
            passwordlbel.TabIndex = 2;
            passwordlbel.Text = "Password";
            // 
            // userlabel
            // 
            userlabel.AutoSize = true;
            userlabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userlabel.Location = new Point(562, 203);
            userlabel.Name = "userlabel";
            userlabel.Size = new Size(69, 17);
            userlabel.TabIndex = 1;
            userlabel.Text = "Username";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(634, 197);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(148, 23);
            txtusername.TabIndex = 0;
            // 
            // exitbutton
            // 
            exitbutton.BackColor = Color.Red;
            exitbutton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitbutton.Location = new Point(604, 378);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(127, 39);
            exitbutton.TabIndex = 6;
            exitbutton.Text = "EXIT";
            exitbutton.UseVisualStyleBackColor = false;
            exitbutton.Click += exitbutton_Click;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(634, 244);
            txtpassword.MaxLength = 15;
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(148, 23);
            txtpassword.TabIndex = 15;
            // 
            // Loginbutton
            // 
            Loginbutton.BackColor = Color.Green;
            Loginbutton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Loginbutton.Location = new Point(604, 332);
            Loginbutton.Name = "Loginbutton";
            Loginbutton.Size = new Size(127, 40);
            Loginbutton.TabIndex = 5;
            Loginbutton.Text = "LOGIN";
            Loginbutton.UseVisualStyleBackColor = false;
            Loginbutton.Click += Loginbutton_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 725);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Name = "LoginPage";
            Text = "LoginPage";
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panel6;
        private Label passwordlbel;
        private Label userlabel;
        private TextBox txtusername;
        private Button exitbutton;
        private TextBox txtpassword;
        private Button Loginbutton;
        private Button Registerbutton;
    }
}