

namespace traveliti
{
    partial class MainHomePage
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
            bottompanel = new Panel();
            logoutbutton = new Button();
            leftpanel = new Panel();
            contactbutton = new Button();
            itinbutton = new Button();
            menubuuton = new Button();
            historybutton = new Button();
            aboutbutton = new Button();
            Menubutton = new Button();
            midpanel = new Panel();
            label4 = new Label();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            smartplanner = new Button();
            budgetbutton = new Button();
            msteriousbutton = new Button();
            POPULARBUTTON = new Button();
            hiddengembutton = new Button();
            OFFBEAT = new Button();
            rightpanel = new Panel();
            toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            bottompanel.SuspendLayout();
            leftpanel.SuspendLayout();
            midpanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // toppanel
            // 
            toppanel.BackColor = Color.White;
            toppanel.Controls.Add(labelTagline);
            toppanel.Controls.Add(label3);
            toppanel.Controls.Add(label1);
            toppanel.Controls.Add(pictureBox1);
            toppanel.Cursor = Cursors.No;
            toppanel.Dock = DockStyle.Top;
            toppanel.ImeMode = ImeMode.Katakana;
            toppanel.Location = new Point(0, 0);
            toppanel.Name = "toppanel";
            toppanel.Size = new Size(1042, 75);
            toppanel.TabIndex = 1;
            toppanel.UseWaitCursor = true;
            toppanel.Paint += toppanel_Paint;
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
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.MenuBar;
            label1.AllowDrop = true;
            label1.AutoEllipsis = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(100, 9);
            label1.Name = "label1";
            label1.Size = new Size(304, 42);
            label1.TabIndex = 2;
            label1.Text = "Travel Itinerary";
            label1.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.travel;
            pictureBox1.Location = new Point(0, -13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // bottompanel
            // 
            bottompanel.BackColor = SystemColors.ActiveCaption;
            bottompanel.Controls.Add(logoutbutton);
            bottompanel.Cursor = Cursors.WaitCursor;
            bottompanel.Dock = DockStyle.Bottom;
            bottompanel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bottompanel.Location = new Point(0, 629);
            bottompanel.Margin = new Padding(4);
            bottompanel.Name = "bottompanel";
            bottompanel.Size = new Size(959, 35);
            bottompanel.TabIndex = 4;
            // 
            // logoutbutton
            // 
            logoutbutton.BackColor = Color.Red;
            logoutbutton.Cursor = Cursors.UpArrow;
            logoutbutton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutbutton.Location = new Point(0, -3);
            logoutbutton.Name = "logoutbutton";
            logoutbutton.Size = new Size(96, 39);
            logoutbutton.TabIndex = 4;
            logoutbutton.Text = "🚪Logout";
            logoutbutton.UseVisualStyleBackColor = false;
            logoutbutton.Click += logoutbutton_Click;
            // 
            // leftpanel
            // 
            leftpanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            leftpanel.BackColor = SystemColors.ActiveCaption;
            leftpanel.BackgroundImageLayout = ImageLayout.Center;
            leftpanel.Controls.Add(contactbutton);
            leftpanel.Controls.Add(itinbutton);
            leftpanel.Controls.Add(menubuuton);
            leftpanel.Controls.Add(historybutton);
            leftpanel.Controls.Add(aboutbutton);
            leftpanel.Controls.Add(Menubutton);
            leftpanel.Cursor = Cursors.Hand;
            leftpanel.Dock = DockStyle.Left;
            leftpanel.Location = new Point(0, 75);
            leftpanel.Name = "leftpanel";
            leftpanel.Size = new Size(110, 554);
            leftpanel.TabIndex = 5;
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
            itinbutton.Click += itinbutton_Click;
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
            menubuuton.Click += menubuuton_Click;
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
            historybutton.Click += historybutton_Click;
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
            Menubutton.Click += Menubutton_Click;
            // 
            // midpanel
            // 
            midpanel.BackColor = Color.LightGray;
            midpanel.Controls.Add(label4);
            midpanel.Controls.Add(label2);
            midpanel.Controls.Add(tableLayoutPanel1);
            midpanel.Cursor = Cursors.IBeam;
            midpanel.Dock = DockStyle.Fill;
            midpanel.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            midpanel.Location = new Point(110, 75);
            midpanel.Margin = new Padding(8);
            midpanel.Name = "midpanel";
            midpanel.Size = new Size(849, 554);
            midpanel.TabIndex = 6;
            midpanel.Paint += midpanel_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(21, 13);
            label4.Name = "label4";
            label4.Size = new Size(91, 24);
            label4.TabIndex = 2;
            label4.Text = "Welcome ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Monotype Corsiva", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(18, 44);
            label2.Name = "label2";
            label2.Size = new Size(174, 28);
            label2.TabIndex = 1;
            label2.Text = "Trending.............";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.3378372F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.6621628F));
            tableLayoutPanel1.Controls.Add(smartplanner, 0, 2);
            tableLayoutPanel1.Controls.Add(budgetbutton, 0, 1);
            tableLayoutPanel1.Controls.Add(msteriousbutton, 1, 2);
            tableLayoutPanel1.Controls.Add(POPULARBUTTON, 1, 0);
            tableLayoutPanel1.Controls.Add(hiddengembutton, 0, 0);
            tableLayoutPanel1.Controls.Add(OFFBEAT, 1, 1);
            tableLayoutPanel1.Cursor = Cursors.AppStarting;
            tableLayoutPanel1.Location = new Point(18, 75);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.2527466F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.7472534F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(335, 160);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // smartplanner
            // 
            smartplanner.BackColor = Color.LightSalmon;
            smartplanner.BackgroundImage = Properties.Resources.travel4;
            smartplanner.BackgroundImageLayout = ImageLayout.Stretch;
            smartplanner.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            smartplanner.ForeColor = Color.White;
            smartplanner.Location = new Point(3, 112);
            smartplanner.Name = "smartplanner";
            smartplanner.Size = new Size(162, 45);
            smartplanner.TabIndex = 4;
            smartplanner.Text = "Smart Planner";
            smartplanner.UseVisualStyleBackColor = false;
            smartplanner.Click += smartplanner_Click_1;
            // 
            // budgetbutton
            // 
            budgetbutton.BackColor = Color.LightSalmon;
            budgetbutton.BackgroundImage = Properties.Resources.travel4;
            budgetbutton.BackgroundImageLayout = ImageLayout.Stretch;
            budgetbutton.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            budgetbutton.ForeColor = Color.White;
            budgetbutton.Location = new Point(3, 54);
            budgetbutton.Name = "budgetbutton";
            budgetbutton.Size = new Size(162, 46);
            budgetbutton.TabIndex = 1;
            budgetbutton.Text = "Budget";
            budgetbutton.UseVisualStyleBackColor = false;
            budgetbutton.Click += budgetbutton_Click;
            // 
            // msteriousbutton
            // 
            msteriousbutton.BackColor = Color.LightSalmon;
            msteriousbutton.BackgroundImage = Properties.Resources.travel4;
            msteriousbutton.BackgroundImageLayout = ImageLayout.Stretch;
            msteriousbutton.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            msteriousbutton.ForeColor = Color.White;
            msteriousbutton.Location = new Point(171, 112);
            msteriousbutton.Name = "msteriousbutton";
            msteriousbutton.Size = new Size(161, 45);
            msteriousbutton.TabIndex = 5;
            msteriousbutton.Text = " Gems";
            msteriousbutton.UseVisualStyleBackColor = false;
            msteriousbutton.Click += button1_Click;
            // 
            // POPULARBUTTON
            // 
            POPULARBUTTON.BackColor = Color.LightSalmon;
            POPULARBUTTON.BackgroundImage = Properties.Resources.travel4;
            POPULARBUTTON.BackgroundImageLayout = ImageLayout.Stretch;
            POPULARBUTTON.Cursor = Cursors.AppStarting;
            POPULARBUTTON.Font = new Font("Arial Unicode MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            POPULARBUTTON.ForeColor = Color.White;
            POPULARBUTTON.Location = new Point(171, 3);
            POPULARBUTTON.Name = "POPULARBUTTON";
            POPULARBUTTON.Size = new Size(161, 45);
            POPULARBUTTON.TabIndex = 2;
            POPULARBUTTON.Text = "Popular";
            POPULARBUTTON.UseVisualStyleBackColor = true;
            POPULARBUTTON.Click += POPULARBUTTON_Click;
            POPULARBUTTON.KeyDown += POPULARBUTTON_KeyDown;
            // 
            // hiddengembutton
            // 
            hiddengembutton.BackColor = Color.LightSalmon;
            hiddengembutton.BackgroundImage = Properties.Resources.travel4;
            hiddengembutton.BackgroundImageLayout = ImageLayout.Stretch;
            hiddengembutton.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hiddengembutton.ForeColor = Color.White;
            hiddengembutton.Location = new Point(3, 3);
            hiddengembutton.Name = "hiddengembutton";
            hiddengembutton.Size = new Size(162, 45);
            hiddengembutton.TabIndex = 3;
            hiddengembutton.Text = "Hidden Gems";
            hiddengembutton.UseVisualStyleBackColor = false;
            hiddengembutton.Click += hiddengembutton_Click;
            // 
            // OFFBEAT
            // 
            OFFBEAT.BackColor = Color.LightSalmon;
            OFFBEAT.BackgroundImage = Properties.Resources.travel4;
            OFFBEAT.BackgroundImageLayout = ImageLayout.Stretch;
            OFFBEAT.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OFFBEAT.ForeColor = Color.White;
            OFFBEAT.Location = new Point(171, 54);
            OFFBEAT.Name = "OFFBEAT";
            OFFBEAT.Size = new Size(161, 46);
            OFFBEAT.TabIndex = 0;
            OFFBEAT.Text = "OffBeat";
            OFFBEAT.UseVisualStyleBackColor = false;
            OFFBEAT.Click += OFFBEAT_Click;
            // 
            // rightpanel
            // 
            rightpanel.BackColor = SystemColors.ActiveCaption;
            rightpanel.Cursor = Cursors.Cross;
            rightpanel.Dock = DockStyle.Right;
            rightpanel.Location = new Point(959, 75);
            rightpanel.Name = "rightpanel";
            rightpanel.Size = new Size(83, 589);
            rightpanel.TabIndex = 3;
            rightpanel.Paint += rightpanel_Paint;
            // 
            // MainHomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 664);
            Controls.Add(midpanel);
            Controls.Add(leftpanel);
            Controls.Add(bottompanel);
            Controls.Add(rightpanel);
            Controls.Add(toppanel);
            KeyPreview = true;
            Name = "MainHomePage";
            Text = "MainHomePage";
            Load += MainHomePage_Load;
            KeyDown += MainHomePage_KeyDown;
            toppanel.ResumeLayout(false);
            toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            bottompanel.ResumeLayout(false);
            leftpanel.ResumeLayout(false);
            midpanel.ResumeLayout(false);
            midpanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void smartplanner_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel toppanel;
        private Label labelTagline;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel bottompanel;
        private Panel leftpanel;
        private Button Menubutton;
        private Button aboutbutton;
        private Button historybutton;
        private Button menubuuton;
        private Button logoutbutton;
        private Panel midpanel;
        private Label label4;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button budgetbutton;
        private Button POPULARBUTTON;
        private Button hiddengembutton;
        private Button OFFBEAT;
        private Button itinbutton;
        private Panel rightpanel;
        private Button msteriousbutton;
        private Button smartplanner;
        private Button contactbutton;
    }
}