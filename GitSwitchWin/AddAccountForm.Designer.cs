namespace GitSwitchWin
{
    partial class AddAccountForm
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
            emailInput = new TextBox();
            usernameInput = new TextBox();
            button1 = new Button();
            accountTypeInput = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // emailInput
            // 
            emailInput.Location = new Point(134, 54);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(273, 27);
            emailInput.TabIndex = 0;
            // 
            // usernameInput
            // 
            usernameInput.Location = new Point(134, 95);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(273, 27);
            usernameInput.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(24, 136);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // accountTypeInput
            // 
            accountTypeInput.Location = new Point(134, 12);
            accountTypeInput.Name = "accountTypeInput";
            accountTypeInput.Size = new Size(273, 27);
            accountTypeInput.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 15);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 4;
            label4.Text = "Account Type:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 57);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 5;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 102);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 6;
            label3.Text = "Username:";
            // 
            // AddAccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 180);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(accountTypeInput);
            Controls.Add(button1);
            Controls.Add(usernameInput);
            Controls.Add(emailInput);
            Name = "AddAccountForm";
            Text = "Add Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private TextBox textBox4;
        private Label label4;
        private Label label2;
        private Label label3;
        private TextBox emailInput;
        private TextBox usernameInput;
        private TextBox accountTypeInput;
    }
}