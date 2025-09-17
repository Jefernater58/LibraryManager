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
            removeBookButton = new Button();
            addBookButton = new Button();
            label2 = new Label();
            label1 = new Label();
            removeStudentIDTextBox = new CustomTextBox();
            addUserPasswordTextbox = new CustomTextBox();
            addUserUsernameTextbox = new CustomTextBox();
            addUserConfirmPasswordTextbox = new CustomTextBox();
            addUserAdminCheckBox = new CheckBox();
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
            // removeBookButton
            // 
            removeBookButton.BackColor = Color.FromArgb(79, 158, 235);
            removeBookButton.FlatAppearance.BorderColor = Color.FromArgb(35, 133, 231);
            removeBookButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(113, 176, 239);
            removeBookButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(99, 168, 238);
            removeBookButton.FlatStyle = FlatStyle.Flat;
            removeBookButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            removeBookButton.ForeColor = Color.White;
            removeBookButton.Location = new Point(508, 120);
            removeBookButton.Name = "removeBookButton";
            removeBookButton.Size = new Size(260, 36);
            removeBookButton.TabIndex = 16;
            removeBookButton.Text = "REMOVE";
            removeBookButton.UseVisualStyleBackColor = false;
            // 
            // addBookButton
            // 
            addBookButton.BackColor = Color.FromArgb(79, 158, 235);
            addBookButton.FlatAppearance.BorderColor = Color.FromArgb(35, 133, 231);
            addBookButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(113, 176, 239);
            addBookButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(99, 168, 238);
            addBookButton.FlatStyle = FlatStyle.Flat;
            addBookButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            addBookButton.ForeColor = Color.White;
            addBookButton.Location = new Point(229, 259);
            addBookButton.Name = "addBookButton";
            addBookButton.Size = new Size(260, 36);
            addBookButton.TabIndex = 15;
            addBookButton.Text = "ADD";
            addBookButton.UseVisualStyleBackColor = false;
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
            // removeStudentIDTextBox
            // 
            removeStudentIDTextBox.BackColor = Color.FromArgb(204, 208, 218);
            removeStudentIDTextBox.IconText = "";
            removeStudentIDTextBox.Location = new Point(508, 66);
            removeStudentIDTextBox.Name = "removeStudentIDTextBox";
            removeStudentIDTextBox.PasswordChar = '\0';
            removeStudentIDTextBox.Size = new Size(260, 36);
            removeStudentIDTextBox.TabIndex = 10;
            removeStudentIDTextBox.TextBoxPlaceholder = "UserID";
            removeStudentIDTextBox.TextBoxText = "";
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
            // EditUsers
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(239, 241, 245);
            Controls.Add(addUserAdminCheckBox);
            Controls.Add(addUserConfirmPasswordTextbox);
            Controls.Add(removeBookButton);
            Controls.Add(addBookButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(removeStudentIDTextBox);
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
        private Button removeBookButton;
        private Button addBookButton;
        private Label label2;
        private Label label1;
        private CustomTextBox removeStudentIDTextBox;
        private CustomTextBox addUserPasswordTextbox;
        private CustomTextBox addUserUsernameTextbox;
        private CustomTextBox addUserConfirmPasswordTextbox;
        private CheckBox addUserAdminCheckBox;
    }
}
