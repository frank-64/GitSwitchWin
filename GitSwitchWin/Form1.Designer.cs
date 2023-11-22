namespace GitSwitchWin
{
    partial class GitSwitch
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addAccountButton = new Button();
            removeAccountButton = new Button();
            currentUsernameLabel = new Label();
            currentEmailLabel = new Label();
            account1Button = new Button();
            account2Button = new Button();
            account3Button = new Button();
            SuspendLayout();
            // 
            // addAccountButton
            // 
            addAccountButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            addAccountButton.Location = new Point(43, 147);
            addAccountButton.Name = "addAccountButton";
            addAccountButton.Size = new Size(142, 37);
            addAccountButton.TabIndex = 0;
            addAccountButton.Text = "Add Account";
            addAccountButton.UseVisualStyleBackColor = true;
            addAccountButton.Click += addAccountButton_Click;
            // 
            // removeAccountButton
            // 
            removeAccountButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            removeAccountButton.Location = new Point(209, 147);
            removeAccountButton.Name = "removeAccountButton";
            removeAccountButton.Size = new Size(164, 37);
            removeAccountButton.TabIndex = 1;
            removeAccountButton.Text = "Remove Account";
            removeAccountButton.UseVisualStyleBackColor = true;
            removeAccountButton.Click += removeAccountButton_Click;
            // 
            // currentUsernameLabel
            // 
            currentUsernameLabel.AutoSize = true;
            currentUsernameLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            currentUsernameLabel.Location = new Point(33, 27);
            currentUsernameLabel.Name = "currentUsernameLabel";
            currentUsernameLabel.Size = new Size(263, 38);
            currentUsernameLabel.TabIndex = 2;
            currentUsernameLabel.Text = "Current Username:";
            // 
            // currentEmailLabel
            // 
            currentEmailLabel.AutoSize = true;
            currentEmailLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            currentEmailLabel.Location = new Point(33, 86);
            currentEmailLabel.Name = "currentEmailLabel";
            currentEmailLabel.Size = new Size(204, 38);
            currentEmailLabel.TabIndex = 3;
            currentEmailLabel.Text = "Current Email:";
            // 
            // account1Button
            // 
            account1Button.BackColor = Color.CornflowerBlue;
            account1Button.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            account1Button.Location = new Point(44, 208);
            account1Button.Name = "account1Button";
            account1Button.Size = new Size(204, 181);
            account1Button.TabIndex = 4;
            account1Button.Text = "Add Account";
            account1Button.TextImageRelation = TextImageRelation.TextAboveImage;
            account1Button.UseVisualStyleBackColor = false;
            account1Button.Visible = false;
            account1Button.Click += account1Button_Click;
            // 
            // account2Button
            // 
            account2Button.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            account2Button.Location = new Point(277, 208);
            account2Button.Name = "account2Button";
            account2Button.Size = new Size(204, 181);
            account2Button.TabIndex = 5;
            account2Button.Text = "Add Account";
            account2Button.UseVisualStyleBackColor = true;
            account2Button.Visible = false;
            account2Button.Click += account2Button_Click;
            // 
            // account3Button
            // 
            account3Button.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            account3Button.Location = new Point(510, 208);
            account3Button.Name = "account3Button";
            account3Button.Size = new Size(204, 181);
            account3Button.TabIndex = 6;
            account3Button.Text = "Add Account";
            account3Button.UseVisualStyleBackColor = true;
            account3Button.Visible = false;
            account3Button.Click += account3Button_Click;
            // 
            // GitSwitch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(763, 417);
            Controls.Add(account3Button);
            Controls.Add(account2Button);
            Controls.Add(account1Button);
            Controls.Add(currentEmailLabel);
            Controls.Add(currentUsernameLabel);
            Controls.Add(removeAccountButton);
            Controls.Add(addAccountButton);
            Name = "GitSwitch";
            Text = "GitSwitch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addAccountButton;
        private Button removeAccountButton;
        private Label currentUsernameLabel;
        private Label currentEmailLabel;
        private Button accountButton1;
        private Button accountButton2;
        private Button accountButton3;
        private Button account1Button;
        private Button account2Button;
        private Button account3Button;
    }
}