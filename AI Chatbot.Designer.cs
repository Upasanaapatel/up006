namespace traveliti
{
    partial class AI_Chatbot
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
            chatBox = new RichTextBox();
            txtUser = new TextBox();
            btnSend = new Button();
            btnAI = new Button();
            SuspendLayout();
            // 
            // chatBox
            // 
            chatBox.Location = new Point(31, 12);
            chatBox.Name = "chatBox";
            chatBox.Size = new Size(133, 96);
            chatBox.TabIndex = 0;
            chatBox.Text = "";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(31, 126);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(133, 23);
            txtUser.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(31, 167);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 2;
            btnSend.Text = "button1";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnAI
            // 
            btnAI.Location = new Point(31, 209);
            btnAI.Name = "btnAI";
            btnAI.Size = new Size(121, 23);
            btnAI.TabIndex = 3;
            btnAI.Text = " AI Travel Assistant";
            btnAI.UseVisualStyleBackColor = true;
            btnAI.Click += btnAI_Click;
            // 
            // AI_Chatbot
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 450);
            Controls.Add(btnAI);
            Controls.Add(btnSend);
            Controls.Add(txtUser);
            Controls.Add(chatBox);
            Name = "AI_Chatbot";
            Text = "AI_Chatbot";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox chatBox;
        private TextBox txtUser;
        private Button btnSend;
        private Button btnAI;
    }
}