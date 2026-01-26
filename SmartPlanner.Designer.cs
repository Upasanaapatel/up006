namespace traveliti
{
    partial class SmartPlanner
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
            toppanel = new Panel();
            labelTagline = new Label();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            rightpanel = new Panel();
            backbutton = new Button();
            panel1 = new Panel();
            weatherbutton = new Button();
            btnSuggest = new Button();
            traveltypecmb = new ComboBox();
            txtday = new TextBox();
            txtbudget = new TextBox();
            lblResult = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            rightpanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // toppanel
            // 
            toppanel.BackColor = Color.White;
            toppanel.Controls.Add(labelTagline);
            toppanel.Controls.Add(label3);
            toppanel.Controls.Add(label1);
            toppanel.Controls.Add(pictureBox1);
            toppanel.Controls.Add(panel2);
            toppanel.Dock = DockStyle.Top;
            toppanel.ImeMode = ImeMode.Katakana;
            toppanel.Location = new Point(0, 0);
            toppanel.Name = "toppanel";
            toppanel.Size = new Size(800, 63);
            toppanel.TabIndex = 3;
            toppanel.UseWaitCursor = true;
            // 
            // labelTagline
            // 
            labelTagline.AutoSize = true;
            labelTagline.ForeColor = Color.Navy;
            labelTagline.Location = new Point(116, 36);
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
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.MenuBar;
            label1.AllowDrop = true;
            label1.AutoEllipsis = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(84, 9);
            label1.Name = "label1";
            label1.Size = new Size(304, 42);
            label1.TabIndex = 2;
            label1.Text = "Travel Itinerary";
            label1.UseWaitCursor = true;
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
            // rightpanel
            // 
            rightpanel.BackColor = SystemColors.ActiveCaption;
            rightpanel.Controls.Add(backbutton);
            rightpanel.Dock = DockStyle.Right;
            rightpanel.Location = new Point(717, 63);
            rightpanel.Name = "rightpanel";
            rightpanel.Size = new Size(83, 387);
            rightpanel.TabIndex = 5;
            // 
            // backbutton
            // 
            backbutton.BackColor = Color.Red;
            backbutton.Dock = DockStyle.Bottom;
            backbutton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backbutton.Location = new Point(0, 348);
            backbutton.Name = "backbutton";
            backbutton.Size = new Size(83, 39);
            backbutton.TabIndex = 4;
            backbutton.Text = "🔁 Back";
            backbutton.UseVisualStyleBackColor = false;
            backbutton.Click += backbutton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(weatherbutton);
            panel1.Controls.Add(btnSuggest);
            panel1.Controls.Add(traveltypecmb);
            panel1.Controls.Add(txtday);
            panel1.Controls.Add(txtbudget);
            panel1.Controls.Add(lblResult);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(717, 387);
            panel1.TabIndex = 6;
            // 
            // weatherbutton
            // 
            weatherbutton.Location = new Point(84, 233);
            weatherbutton.Name = "weatherbutton";
            weatherbutton.Size = new Size(124, 40);
            weatherbutton.TabIndex = 8;
            weatherbutton.Text = "Weather Trip";
            weatherbutton.UseVisualStyleBackColor = true;
            weatherbutton.Click += weatherbutton_Click;
            // 
            // btnSuggest
            // 
            btnSuggest.Location = new Point(100, 153);
            btnSuggest.Name = "btnSuggest";
            btnSuggest.Size = new Size(95, 30);
            btnSuggest.TabIndex = 7;
            btnSuggest.Text = "Suggest Trip";
            btnSuggest.UseVisualStyleBackColor = true;
            btnSuggest.Click += btnSuggest_Click;
            // 
            // traveltypecmb
            // 
            traveltypecmb.FormattingEnabled = true;
            traveltypecmb.Items.AddRange(new object[] { "Solo", "Family", "Friends" });
            traveltypecmb.Location = new Point(127, 84);
            traveltypecmb.Name = "traveltypecmb";
            traveltypecmb.Size = new Size(121, 23);
            traveltypecmb.TabIndex = 6;
            // 
            // txtday
            // 
            txtday.Location = new Point(126, 54);
            txtday.Name = "txtday";
            txtday.Size = new Size(162, 23);
            txtday.TabIndex = 5;
            // 
            // txtbudget
            // 
            txtbudget.Location = new Point(126, 26);
            txtbudget.Name = "txtbudget";
            txtbudget.Size = new Size(162, 23);
            txtbudget.TabIndex = 4;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(20, 121);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(125, 15);
            lblResult.TabIndex = 3;
            lblResult.Text = "Suggested Destination";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 85);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 2;
            label5.Text = "Travel Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 54);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 1;
            label4.Text = "Number of Days";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 29);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 0;
            label2.Text = "Enter Budget";
            // 
            // SmartPlanner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(rightpanel);
            Controls.Add(toppanel);
            Name = "SmartPlanner";
            Text = "SmartPlanner";
            toppanel.ResumeLayout(false);
            toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            rightpanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel toppanel;
        private Label labelTagline;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel rightpanel;
        private Button backbutton;
        private Panel panel1;
        private TextBox txtbudget;
        private Label lblResult;
        private Label label5;
        private Label label4;
        private Label label2;
        private Button btnSuggest;
        private ComboBox traveltypecmb;
        private TextBox txtday;
        private Button weatherbutton;
    }
}