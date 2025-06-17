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
            sideBar1 = new CustomControls.SideBar();
            removeBookButton = new Button();
            addBookButton = new Button();
            label2 = new Label();
            label1 = new Label();
            removeStudentIDTextBox = new CustomTextBox();
            addStudentLastNameTextBox = new CustomTextBox();
            addStudentFirstNameTextBox = new CustomTextBox();
            addStudentYearGroupTextBox = new CustomTextBox();
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
            addBookButton.Location = new Point(229, 220);
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
            // EditStudents
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(239, 241, 245);
            Controls.Add(addStudentYearGroupTextBox);
            Controls.Add(removeBookButton);
            Controls.Add(addBookButton);
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
        private Button removeBookButton;
        private Button addBookButton;
        private Label label2;
        private Label label1;
        private CustomTextBox removeStudentIDTextBox;
        private CustomTextBox addStudentLastNameTextBox;
        private CustomTextBox addStudentFirstNameTextBox;
        private CustomTextBox addStudentYearGroupTextBox;
    }
}
