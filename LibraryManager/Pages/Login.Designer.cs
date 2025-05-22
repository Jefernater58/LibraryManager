namespace LibraryManager.Pages
{
    partial class Login
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
            welcomeLabel = new Label();
            usernameTextBox = new CustomTextBox();
            passwordTextBox = new CustomTextBox();
            loginButton = new Button();
            incorrectCredentialsLabel = new Label();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            welcomeLabel.ForeColor = Color.FromArgb(76, 79, 105);
            welcomeLabel.Location = new Point(346, 66);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(108, 30);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome";
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = Color.FromArgb(204, 208, 218);
            usernameTextBox.IconText = "";
            usernameTextBox.Location = new Point(250, 116);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.PasswordChar = '\0';
            usernameTextBox.Size = new Size(300, 36);
            usernameTextBox.TabIndex = 0;
            usernameTextBox.TextBoxPlaceholder = "Username";
            usernameTextBox.TextBoxText = "";
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.FromArgb(204, 208, 218);
            passwordTextBox.IconText = "";
            passwordTextBox.Location = new Point(250, 172);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '•';
            passwordTextBox.Size = new Size(300, 36);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.TextBoxPlaceholder = "Password";
            passwordTextBox.TextBoxText = "";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(79, 158, 235);
            loginButton.FlatAppearance.BorderColor = Color.FromArgb(35, 133, 231);
            loginButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(113, 176, 239);
            loginButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(99, 168, 238);
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(250, 228);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(300, 36);
            loginButton.TabIndex = 2;
            loginButton.Text = "LOGIN";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // incorrectCredentialsLabel
            // 
            incorrectCredentialsLabel.AutoSize = true;
            incorrectCredentialsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            incorrectCredentialsLabel.ForeColor = Color.FromArgb(210, 15, 57);
            incorrectCredentialsLabel.Location = new Point(338, 280);
            incorrectCredentialsLabel.Name = "incorrectCredentialsLabel";
            incorrectCredentialsLabel.Size = new Size(124, 15);
            incorrectCredentialsLabel.TabIndex = 4;
            incorrectCredentialsLabel.Text = "Incorrect Credentials";
            incorrectCredentialsLabel.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 233, 239);
            Controls.Add(incorrectCredentialsLabel);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(welcomeLabel);
            Name = "Login";
            Size = new Size(798, 398);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeLabel;
        private CustomTextBox usernameTextBox;
        private CustomTextBox passwordTextBox;
        private Button loginButton;
        private Label incorrectCredentialsLabel;
    }
}
