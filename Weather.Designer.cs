namespace traveliti
{
    partial class Weather
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            rightpanel = new Panel();
            backbutton = new Button();
            toppanel = new Panel();
            labelTagline = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            lblWeatherResult = new Label();
            btnCheck = new Button();
            cmbWeather = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            rightpanel.SuspendLayout();
            toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(rightpanel);
            panel1.Controls.Add(toppanel);
            panel1.Controls.Add(lblWeatherResult);
            panel1.Controls.Add(btnCheck);
            panel1.Controls.Add(cmbWeather);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(871, 499);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // rightpanel
            // 
            rightpanel.BackColor = SystemColors.ActiveCaption;
            rightpanel.Controls.Add(backbutton);
            rightpanel.Dock = DockStyle.Right;
            rightpanel.Location = new Point(788, 63);
            rightpanel.Name = "rightpanel";
            rightpanel.Size = new Size(83, 436);
            rightpanel.TabIndex = 6;
            // 
            // backbutton
            // 
            backbutton.BackColor = Color.Red;
            backbutton.Dock = DockStyle.Bottom;
            backbutton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backbutton.Location = new Point(0, 397);
            backbutton.Name = "backbutton";
            backbutton.Size = new Size(83, 39);
            backbutton.TabIndex = 4;
            backbutton.Text = "🔁 Back";
            backbutton.UseVisualStyleBackColor = false;
            backbutton.Click += backbutton_Click;
            // 
            // toppanel
            // 
            toppanel.BackColor = Color.White;
            toppanel.Controls.Add(labelTagline);
            toppanel.Controls.Add(label3);
            toppanel.Controls.Add(label4);
            toppanel.Controls.Add(pictureBox1);
            toppanel.Controls.Add(panel2);
            toppanel.Dock = DockStyle.Top;
            toppanel.ImeMode = ImeMode.Katakana;
            toppanel.Location = new Point(0, 0);
            toppanel.Name = "toppanel";
            toppanel.Size = new Size(871, 63);
            toppanel.TabIndex = 5;
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
            pictureBox1.Size = new Size(110, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(96, 100);
            panel2.TabIndex = 0;
            panel2.UseWaitCursor = true;
            // 
            // lblWeatherResult
            // 
            lblWeatherResult.AutoSize = true;
            lblWeatherResult.Location = new Point(56, 121);
            lblWeatherResult.Name = "lblWeatherResult";
            lblWeatherResult.Size = new Size(0, 15);
            lblWeatherResult.TabIndex = 4;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(74, 197);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(75, 23);
            btnCheck.TabIndex = 3;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // cmbWeather
            // 
            cmbWeather.FormattingEnabled = true;
            cmbWeather.Items.AddRange(new object[] { "Sunny", "Rainy", "Winter", "Cloudy" });
            cmbWeather.Location = new Point(28, 148);
            cmbWeather.Name = "cmbWeather";
            cmbWeather.Size = new Size(121, 23);
            cmbWeather.TabIndex = 2;
            cmbWeather.Text = "Select Weather";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 121);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 1;
            label2.Text = "Suggested Destination";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 94);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 0;
            label1.Text = "Select Current Weather";
            // 
            // Weather
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Weather";
            Size = new Size(871, 499);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            rightpanel.ResumeLayout(false);
            toppanel.ResumeLayout(false);
            toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button btnCheck;
        private ComboBox cmbWeather;
        private Label lblWeatherResult;
        private Panel toppanel;
        private Label labelTagline;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel rightpanel;
        private Button backbutton;
    }
}
