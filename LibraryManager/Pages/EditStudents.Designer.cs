namespace LibraryManager.Pages
{
    partial class EditStudents
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
            removeStudentButton = new Button();
            addStudentButton = new Button();
            label2 = new Label();
            label1 = new Label();
            removeStudentIDTextBox = new CustomTextBox();
            addStudentLastNameTextBox = new CustomTextBox();
            addStudentFirstNameTextBox = new CustomTextBox();
            addStudentYearGroupTextBox = new CustomTextBox();
            studentRemovedLabel = new Label();
            studentDoesNotExistLabel = new Label();
            studentAddedLabel = new Label();
            emptyFieldLabel = new Label();
            invalidYearGroupLabel = new Label();
            SuspendLayout();
            // 
            // sideBar1
            // 
            sideBar1.BackColor = Color.FromArgb(220, 224, 232);
            sideBar1.CurrentFormIndex = 5;
            sideBar1.Location = new Point(0, 0);
            sideBar1.Name = "sideBar1";
            sideBar1.Size = new Size(198, 398);
            sideBar1.TabIndex = 0;
            // 
            // removeStudentButton
            // 
            removeStudentButton.BackColor = Color.FromArgb(79, 158, 235);
            removeStudentButton.FlatAppearance.BorderColor = Color.FromArgb(35, 133, 231);
            removeStudentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(113, 176, 239);
            removeStudentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(99, 168, 238);
            removeStudentButton.FlatStyle = FlatStyle.Flat;
            removeStudentButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            removeStudentButton.ForeColor = Color.White;
            removeStudentButton.Location = new Point(508, 120);
            removeStudentButton.Name = "removeStudentButton";
            removeStudentButton.Size = new Size(260, 36);
            removeStudentButton.TabIndex = 16;
            removeStudentButton.Text = "REMOVE";
            removeStudentButton.UseVisualStyleBackColor = false;
            removeStudentButton.Click += removeStudentButton_Click;
            // 
            // addStudentButton
            // 
            addStudentButton.BackColor = Color.FromArgb(79, 158, 235);
            addStudentButton.FlatAppearance.BorderColor = Color.FromArgb(35, 133, 231);
            addStudentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(113, 176, 239);
            addStudentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(99, 168, 238);
            addStudentButton.FlatStyle = FlatStyle.Flat;
            addStudentButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            addStudentButton.ForeColor = Color.White;
            addStudentButton.Location = new Point(229, 220);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new Size(260, 36);
            addStudentButton.TabIndex = 15;
            addStudentButton.Text = "ADD";
            addStudentButton.UseVisualStyleBackColor = false;
            addStudentButton.Click += addStudentButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(76, 79, 105);
            label2.Location = new Point(562, 31);
            label2.Name = "label2";
            label2.Size = new Size(163, 15);
            label2.TabIndex = 13;
            label2.Text = "Remove an existing student";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(76, 79, 105);
            label1.Location = new Point(311, 31);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 14;
            label1.Text = "Add a new student";
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
            removeStudentIDTextBox.TextBoxPlaceholder = "StudentID";
            removeStudentIDTextBox.TextBoxText = "";
            // 
            // addStudentLastNameTextBox
            // 
            addStudentLastNameTextBox.BackColor = Color.FromArgb(204, 208, 218);
            addStudentLastNameTextBox.IconText = "";
            addStudentLastNameTextBox.Location = new Point(229, 120);
            addStudentLastNameTextBox.Name = "addStudentLastNameTextBox";
            addStudentLastNameTextBox.PasswordChar = '\0';
            addStudentLastNameTextBox.Size = new Size(260, 36);
            addStudentLastNameTextBox.TabIndex = 11;
            addStudentLastNameTextBox.TextBoxPlaceholder = "Last Name";
            addStudentLastNameTextBox.TextBoxText = "";
            // 
            // addStudentFirstNameTextBox
            // 
            addStudentFirstNameTextBox.BackColor = Color.FromArgb(204, 208, 218);
            addStudentFirstNameTextBox.IconText = "";
            addStudentFirstNameTextBox.Location = new Point(229, 66);
            addStudentFirstNameTextBox.Name = "addStudentFirstNameTextBox";
            addStudentFirstNameTextBox.PasswordChar = '\0';
            addStudentFirstNameTextBox.Size = new Size(260, 36);
            addStudentFirstNameTextBox.TabIndex = 12;
            addStudentFirstNameTextBox.TextBoxPlaceholder = "First Name";
            addStudentFirstNameTextBox.TextBoxText = "";
            // 
            // addStudentYearGroupTextBox
            // 
            addStudentYearGroupTextBox.BackColor = Color.FromArgb(204, 208, 218);
            addStudentYearGroupTextBox.IconText = "";
            addStudentYearGroupTextBox.Location = new Point(229, 169);
            addStudentYearGroupTextBox.Name = "addStudentYearGroupTextBox";
            addStudentYearGroupTextBox.PasswordChar = '\0';
            addStudentYearGroupTextBox.Size = new Size(260, 36);
            addStudentYearGroupTextBox.TabIndex = 17;
            addStudentYearGroupTextBox.TextBoxPlaceholder = "Year Group";
            addStudentYearGroupTextBox.TextBoxText = "";
            // 
            // studentRemovedLabel
            // 
            studentRemovedLabel.AutoSize = true;
            studentRemovedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            studentRemovedLabel.ForeColor = Color.FromArgb(15, 210, 57);
            studentRemovedLabel.Location = new Point(551, 159);
            studentRemovedLabel.Name = "studentRemovedLabel";
            studentRemovedLabel.Size = new Size(174, 15);
            studentRemovedLabel.TabIndex = 29;
            studentRemovedLabel.Text = "Student removed successfully";
            studentRemovedLabel.Visible = false;
            // 
            // studentDoesNotExistLabel
            // 
            studentDoesNotExistLabel.AutoSize = true;
            studentDoesNotExistLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            studentDoesNotExistLabel.ForeColor = Color.FromArgb(210, 15, 57);
            studentDoesNotExistLabel.Location = new Point(535, 159);
            studentDoesNotExistLabel.Name = "studentDoesNotExistLabel";
            studentDoesNotExistLabel.Size = new Size(208, 15);
            studentDoesNotExistLabel.TabIndex = 28;
            studentDoesNotExistLabel.Text = "The specified student does not exist";
            studentDoesNotExistLabel.Visible = false;
            // 
            // studentAddedLabel
            // 
            studentAddedLabel.AutoSize = true;
            studentAddedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            studentAddedLabel.ForeColor = Color.FromArgb(15, 210, 57);
            studentAddedLabel.Location = new Point(273, 259);
            studentAddedLabel.Name = "studentAddedLabel";
            studentAddedLabel.Size = new Size(184, 15);
            studentAddedLabel.TabIndex = 27;
            studentAddedLabel.Text = "New student added successfully";
            studentAddedLabel.Visible = false;
            // 
            // emptyFieldLabel
            // 
            emptyFieldLabel.AutoSize = true;
            emptyFieldLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            emptyFieldLabel.ForeColor = Color.FromArgb(210, 15, 57);
            emptyFieldLabel.Location = new Point(291, 259);
            emptyFieldLabel.Name = "emptyFieldLabel";
            emptyFieldLabel.Size = new Size(147, 15);
            emptyFieldLabel.TabIndex = 25;
            emptyFieldLabel.Text = "Fields must not be empty";
            emptyFieldLabel.Visible = false;
            // 
            // invalidYearGroupLabel
            // 
            invalidYearGroupLabel.AutoSize = true;
            invalidYearGroupLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            invalidYearGroupLabel.ForeColor = Color.FromArgb(210, 15, 57);
            invalidYearGroupLabel.Location = new Point(273, 259);
            invalidYearGroupLabel.Name = "invalidYearGroupLabel";
            invalidYearGroupLabel.Size = new Size(175, 15);
            invalidYearGroupLabel.TabIndex = 30;
            invalidYearGroupLabel.Text = "The given year group is invalid";
            invalidYearGroupLabel.Visible = false;
            // 
            // EditStudents
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(239, 241, 245);
            Controls.Add(invalidYearGroupLabel);
            Controls.Add(studentRemovedLabel);
            Controls.Add(studentDoesNotExistLabel);
            Controls.Add(studentAddedLabel);
            Controls.Add(emptyFieldLabel);
            Controls.Add(addStudentYearGroupTextBox);
            Controls.Add(removeStudentButton);
            Controls.Add(addStudentButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(removeStudentIDTextBox);
            Controls.Add(addStudentLastNameTextBox);
            Controls.Add(addStudentFirstNameTextBox);
            Controls.Add(sideBar1);
            Margin = new Padding(0);
            Name = "EditStudents";
            Size = new Size(798, 398);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.SideBar sideBar1;
        private Button removeStudentButton;
        private Button addStudentButton;
        private Label label2;
        private Label label1;
        private CustomTextBox removeStudentIDTextBox;
        private CustomTextBox addStudentLastNameTextBox;
        private CustomTextBox addStudentFirstNameTextBox;
        private CustomTextBox addStudentYearGroupTextBox;
        private Label studentRemovedLabel;
        private Label studentDoesNotExistLabel;
        private Label studentAddedLabel;
        private Label emptyFieldLabel;
        private Label invalidYearGroupLabel;
    }
}
