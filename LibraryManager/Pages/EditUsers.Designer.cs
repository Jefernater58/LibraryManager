namespace LibraryManager.Pages
{
    partial class EditUsers
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
            sideBar1 = new LibraryManager.CustomControls.SideBar();
            removeUserButton = new Button();
            addUserButton = new Button();
            label2 = new Label();
            label1 = new Label();
            removeUserUsernameTextBox = new CustomTextBox();
            addUserPasswordTextbox = new CustomTextBox();
            addUserUsernameTextbox = new CustomTextBox();
            addUserConfirmPasswordTextbox = new CustomTextBox();
            addUserAdminCheckBox = new CheckBox();
            emptyFieldLabel = new Label();
            passwordMatchLabel = new Label();
            userExistsLabel = new Label();
            userAddedLabel = new Label();
            userDoesNotExistLabel = new Label();
            userRemovedLabel = new Label();
            SuspendLayout();
            // 
            // sideBar1
            // 
            sideBar1.BackColor = Color.FromArgb(220, 224, 232);
            sideBar1.CurrentFormIndex = 6;
            sideBar1.Location = new Point(0, 0);
            sideBar1.Name = "sideBar1";
            sideBar1.Size = new Size(198, 398);
            sideBar1.TabIndex = 0;
            // 
            // removeUserButton
            // 
            removeUserButton.BackColor = Color.FromArgb(79, 158, 235);
            removeUserButton.FlatAppearance.BorderColor = Color.FromArgb(35, 133, 231);
            removeUserButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(113, 176, 239);
            removeUserButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(99, 168, 238);
            removeUserButton.FlatStyle = FlatStyle.Flat;
            removeUserButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            removeUserButton.ForeColor = Color.White;
            removeUserButton.Location = new Point(508, 120);
            removeUserButton.Name = "removeUserButton";
            removeUserButton.Size = new Size(260, 36);
            removeUserButton.TabIndex = 16;
            removeUserButton.Text = "REMOVE";
            removeUserButton.UseVisualStyleBackColor = false;
            removeUserButton.Click += removeUserButton_click;
            // 
            // addUserButton
            // 
            addUserButton.BackColor = Color.FromArgb(79, 158, 235);
            addUserButton.FlatAppearance.BorderColor = Color.FromArgb(35, 133, 231);
            addUserButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(113, 176, 239);
            addUserButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(99, 168, 238);
            addUserButton.FlatStyle = FlatStyle.Flat;
            addUserButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            addUserButton.ForeColor = Color.White;
            addUserButton.Location = new Point(229, 259);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(260, 36);
            addUserButton.TabIndex = 15;
            addUserButton.Text = "ADD";
            addUserButton.UseVisualStyleBackColor = false;
            addUserButton.Click += addUserButton_click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(76, 79, 105);
            label2.Location = new Point(562, 31);
            label2.Name = "label2";
            label2.Size = new Size(144, 15);
            label2.TabIndex = 13;
            label2.Text = "Remove an existing user";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(76, 79, 105);
            label1.Location = new Point(311, 31);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 14;
            label1.Text = "Add a new user";
            // 
            // removeUserUsernameTextBox
            // 
            removeUserUsernameTextBox.BackColor = Color.FromArgb(204, 208, 218);
            removeUserUsernameTextBox.IconText = "";
            removeUserUsernameTextBox.Location = new Point(508, 66);
            removeUserUsernameTextBox.Name = "removeUserUsernameTextBox";
            removeUserUsernameTextBox.PasswordChar = '\0';
            removeUserUsernameTextBox.Size = new Size(260, 36);
            removeUserUsernameTextBox.TabIndex = 10;
            removeUserUsernameTextBox.TextBoxPlaceholder = "Username";
            removeUserUsernameTextBox.TextBoxText = "";
            // 
            // addUserPasswordTextbox
            // 
            addUserPasswordTextbox.BackColor = Color.FromArgb(204, 208, 218);
            addUserPasswordTextbox.IconText = "";
            addUserPasswordTextbox.Location = new Point(229, 120);
            addUserPasswordTextbox.Name = "addUserPasswordTextbox";
            addUserPasswordTextbox.PasswordChar = '•';
            addUserPasswordTextbox.Size = new Size(260, 36);
            addUserPasswordTextbox.TabIndex = 11;
            addUserPasswordTextbox.TextBoxPlaceholder = "Password";
            addUserPasswordTextbox.TextBoxText = "";
            // 
            // addUserUsernameTextbox
            // 
            addUserUsernameTextbox.BackColor = Color.FromArgb(204, 208, 218);
            addUserUsernameTextbox.IconText = "";
            addUserUsernameTextbox.Location = new Point(229, 66);
            addUserUsernameTextbox.Name = "addUserUsernameTextbox";
            addUserUsernameTextbox.PasswordChar = '\0';
            addUserUsernameTextbox.Size = new Size(260, 36);
            addUserUsernameTextbox.TabIndex = 12;
            addUserUsernameTextbox.TextBoxPlaceholder = "Username";
            addUserUsernameTextbox.TextBoxText = "";
            // 
            // addUserConfirmPasswordTextbox
            // 
            addUserConfirmPasswordTextbox.BackColor = Color.FromArgb(204, 208, 218);
            addUserConfirmPasswordTextbox.IconText = "";
            addUserConfirmPasswordTextbox.Location = new Point(229, 171);
            addUserConfirmPasswordTextbox.Name = "addUserConfirmPasswordTextbox";
            addUserConfirmPasswordTextbox.PasswordChar = '•';
            addUserConfirmPasswordTextbox.Size = new Size(260, 36);
            addUserConfirmPasswordTextbox.TabIndex = 17;
            addUserConfirmPasswordTextbox.TextBoxPlaceholder = "Confirm Password";
            addUserConfirmPasswordTextbox.TextBoxText = "";
            // 
            // addUserAdminCheckBox
            // 
            addUserAdminCheckBox.AutoSize = true;
            addUserAdminCheckBox.ForeColor = Color.FromArgb(76, 79, 105);
            addUserAdminCheckBox.Location = new Point(311, 222);
            addUserAdminCheckBox.Name = "addUserAdminCheckBox";
            addUserAdminCheckBox.Size = new Size(99, 19);
            addUserAdminCheckBox.TabIndex = 18;
            addUserAdminCheckBox.Text = "Administrator";
            addUserAdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // emptyFieldLabel
            // 
            emptyFieldLabel.AutoSize = true;
            emptyFieldLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            emptyFieldLabel.ForeColor = Color.FromArgb(210, 15, 57);
            emptyFieldLabel.Location = new Point(221, 305);
            emptyFieldLabel.Name = "emptyFieldLabel";
            emptyFieldLabel.Size = new Size(276, 15);
            emptyFieldLabel.TabIndex = 19;
            emptyFieldLabel.Text = "Username or Password fields must not be empty";
            emptyFieldLabel.Visible = false;
            // 
            // passwordMatchLabel
            // 
            passwordMatchLabel.AutoSize = true;
            passwordMatchLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            passwordMatchLabel.ForeColor = Color.FromArgb(210, 15, 57);
            passwordMatchLabel.Location = new Point(275, 305);
            passwordMatchLabel.Name = "passwordMatchLabel";
            passwordMatchLabel.Size = new Size(165, 15);
            passwordMatchLabel.TabIndex = 20;
            passwordMatchLabel.Text = "The passwords do not match";
            passwordMatchLabel.Visible = false;
            // 
            // userExistsLabel
            // 
            userExistsLabel.AutoSize = true;
            userExistsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            userExistsLabel.ForeColor = Color.FromArgb(210, 15, 57);
            userExistsLabel.Location = new Point(243, 305);
            userExistsLabel.Name = "userExistsLabel";
            userExistsLabel.Size = new Size(229, 15);
            userExistsLabel.TabIndex = 21;
            userExistsLabel.Text = "A user with this username already exists";
            userExistsLabel.Visible = false;
            // 
            // userAddedLabel
            // 
            userAddedLabel.AutoSize = true;
            userAddedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            userAddedLabel.ForeColor = Color.FromArgb(15, 210, 57);
            userAddedLabel.Location = new Point(275, 305);
            userAddedLabel.Name = "userAddedLabel";
            userAddedLabel.Size = new Size(165, 15);
            userAddedLabel.TabIndex = 22;
            userAddedLabel.Text = "New user added successfully";
            userAddedLabel.Visible = false;
            // 
            // userDoesNotExistLabel
            // 
            userDoesNotExistLabel.AutoSize = true;
            userDoesNotExistLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            userDoesNotExistLabel.ForeColor = Color.FromArgb(210, 15, 57);
            userDoesNotExistLabel.Location = new Point(548, 171);
            userDoesNotExistLabel.Name = "userDoesNotExistLabel";
            userDoesNotExistLabel.Size = new Size(189, 15);
            userDoesNotExistLabel.TabIndex = 23;
            userDoesNotExistLabel.Text = "The specified user does not exist";
            userDoesNotExistLabel.Visible = false;
            // 
            // userRemovedLabel
            // 
            userRemovedLabel.AutoSize = true;
            userRemovedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            userRemovedLabel.ForeColor = Color.FromArgb(15, 210, 57);
            userRemovedLabel.Location = new Point(562, 171);
            userRemovedLabel.Name = "userRemovedLabel";
            userRemovedLabel.Size = new Size(155, 15);
            userRemovedLabel.TabIndex = 24;
            userRemovedLabel.Text = "User removed successfully";
            userRemovedLabel.Visible = false;
            // 
            // EditUsers
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(239, 241, 245);
            Controls.Add(userRemovedLabel);
            Controls.Add(userDoesNotExistLabel);
            Controls.Add(userAddedLabel);
            Controls.Add(userExistsLabel);
            Controls.Add(passwordMatchLabel);
            Controls.Add(emptyFieldLabel);
            Controls.Add(addUserAdminCheckBox);
            Controls.Add(addUserConfirmPasswordTextbox);
            Controls.Add(removeUserButton);
            Controls.Add(addUserButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(removeUserUsernameTextBox);
            Controls.Add(addUserPasswordTextbox);
            Controls.Add(addUserUsernameTextbox);
            Controls.Add(sideBar1);
            Margin = new Padding(0);
            Name = "EditUsers";
            Size = new Size(798, 398);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.SideBar sideBar1;
        private Button removeUserButton;
        private Button addUserButton;
        private Label label2;
        private Label label1;
        private CustomTextBox removeUserUsernameTextBox;
        private CustomTextBox addUserPasswordTextbox;
        private CustomTextBox addUserUsernameTextbox;
        private CustomTextBox addUserConfirmPasswordTextbox;
        private CheckBox addUserAdminCheckBox;
        private Label emptyFieldLabel;
        private Label passwordMatchLabel;
        private Label userExistsLabel;
        private Label userAddedLabel;
        private Label userDoesNotExistLabel;
        private Label userRemovedLabel;
    }
}
