namespace traveliti
{
    partial class DestinationDetail
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
            lblPlace = new Label();
            lblPrice = new Label();
            lblDays = new Label();
            lblHotel = new Label();
            pictureBox1 = new PictureBox();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblPlace
            // 
            lblPlace.AutoSize = true;
            lblPlace.Location = new Point(10, 9);
            lblPlace.Name = "lblPlace";
            lblPlace.Size = new Size(35, 15);
            lblPlace.TabIndex = 0;
            lblPlace.Text = "Place";
            lblPlace.Click += lblPlace_Click;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(10, 40);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "Price";
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Location = new Point(10, 67);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(32, 15);
            lblDays.TabIndex = 2;
            lblDays.Text = "Days";
            // 
            // lblHotel
            // 
            lblHotel.AutoSize = true;
            lblHotel.Location = new Point(9, 91);
            lblHotel.Name = "lblHotel";
            lblHotel.Size = new Size(36, 15);
            lblHotel.TabIndex = 3;
            lblHotel.Text = "Hotel";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_Jan_20__2026__02_12_27_AM;
            pictureBox1.Location = new Point(9, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 271);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // DestinationDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(pictureBox1);
            Controls.Add(lblHotel);
            Controls.Add(lblDays);
            Controls.Add(lblPrice);
            Controls.Add(lblPlace);
            Name = "DestinationDetail";
            Text = "DestinationDetail";
            Load += DestinationDetail_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPlace;
        private Label lblPrice;
        private Label lblDays;
        private Label lblHotel;
        private PictureBox pictureBox1;
        private Button btnBack;
    }
}