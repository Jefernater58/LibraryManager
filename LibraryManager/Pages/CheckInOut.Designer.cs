namespace LibraryManager.Pages
{
    partial class CheckInOut
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
            studentIDTextBox = new CustomTextBox();
            bookIDTextBox = new CustomTextBox();
            checkInButton = new Button();
            checkOutButton = new Button();
            successLabel = new Label();
            alreadyCheckedInLabel = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // sideBar1
            // 
            sideBar1.BackColor = Color.FromArgb(38, 44, 54);
            sideBar1.CurrentFormIndex = 3;
            sideBar1.Location = new Point(0, 0);
            sideBar1.Name = "sideBar1";
            sideBar1.Size = new Size(198, 398);
            sideBar1.TabIndex = 0;
            // 
            // studentIDTextBox
            // 
            studentIDTextBox.BackColor = Color.FromArgb(51, 59, 71);
            studentIDTextBox.IconText = "";
            studentIDTextBox.Location = new Point(345, 98);
            studentIDTextBox.Name = "studentIDTextBox";
            studentIDTextBox.PasswordChar = '\0';
            studentIDTextBox.Size = new Size(300, 36);
            studentIDTextBox.TabIndex = 1;
            studentIDTextBox.TextBoxPlaceholder = "Student ID";
            studentIDTextBox.TextBoxText = "";
            // 
            // bookIDTextBox
            // 
            bookIDTextBox.BackColor = Color.FromArgb(51, 59, 71);
            bookIDTextBox.IconText = "";
            bookIDTextBox.Location = new Point(345, 154);
            bookIDTextBox.Name = "bookIDTextBox";
            bookIDTextBox.PasswordChar = '\0';
            bookIDTextBox.Size = new Size(300, 36);
            bookIDTextBox.TabIndex = 2;
            bookIDTextBox.TextBoxPlaceholder = "Book ID";
            bookIDTextBox.TextBoxText = "";
            // 
            // checkInButton
            // 
            checkInButton.BackColor = Color.FromArgb(79, 158, 235);
            checkInButton.FlatAppearance.BorderColor = Color.FromArgb(35, 133, 231);
            checkInButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(113, 176, 239);
            checkInButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(99, 168, 238);
            checkInButton.FlatStyle = FlatStyle.Flat;
            checkInButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            checkInButton.ForeColor = Color.White;
            checkInButton.Location = new Point(345, 210);
            checkInButton.Name = "checkInButton";
            checkInButton.Size = new Size(140, 36);
            checkInButton.TabIndex = 3;
            checkInButton.Text = "CHECK IN";
            checkInButton.UseVisualStyleBackColor = false;
            checkInButton.Click += checkInButton_Click;
            // 
            // checkOutButton
            // 
            checkOutButton.BackColor = Color.FromArgb(79, 158, 235);
            checkOutButton.FlatAppearance.BorderColor = Color.FromArgb(35, 133, 231);
            checkOutButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(113, 176, 239);
            checkOutButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(99, 168, 238);
            checkOutButton.FlatStyle = FlatStyle.Flat;
            checkOutButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            checkOutButton.ForeColor = Color.White;
            checkOutButton.Location = new Point(505, 210);
            checkOutButton.Name = "checkOutButton";
            checkOutButton.Size = new Size(140, 36);
            checkOutButton.TabIndex = 3;
            checkOutButton.Text = "CHECK OUT";
            checkOutButton.UseVisualStyleBackColor = false;
            checkOutButton.Click += checkOutButton_Click;
            // 
            // successLabel
            // 
            successLabel.AutoSize = true;
            successLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            successLabel.ForeColor = Color.FromArgb(42, 147, 49);
            successLabel.Location = new Point(470, 261);
            successLabel.Name = "successLabel";
            successLabel.Size = new Size(54, 15);
            successLabel.TabIndex = 5;
            successLabel.Text = "Success!";
            successLabel.Visible = false;
            // 
            // alreadyCheckedInLabel
            // 
            alreadyCheckedInLabel.AutoSize = true;
            alreadyCheckedInLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            alreadyCheckedInLabel.ForeColor = Color.FromArgb(147, 42, 49);
            alreadyCheckedInLabel.Location = new Point(393, 261);
            alreadyCheckedInLabel.Name = "alreadyCheckedInLabel";
            alreadyCheckedInLabel.Size = new Size(212, 15);
            alreadyCheckedInLabel.TabIndex = 6;
            alreadyCheckedInLabel.Text = "Error! This book is already checked in";
            alreadyCheckedInLabel.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(147, 42, 49);
            label1.Location = new Point(384, 261);
            label1.Name = "label1";
            label1.Size = new Size(221, 15);
            label1.TabIndex = 7;
            label1.Text = "Error! This book is already checked out";
            label1.Visible = false;
            // 
            // CheckInOut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 49, 59);
            Controls.Add(label1);
            Controls.Add(alreadyCheckedInLabel);
            Controls.Add(successLabel);
            Controls.Add(checkOutButton);
            Controls.Add(checkInButton);
            Controls.Add(bookIDTextBox);
            Controls.Add(studentIDTextBox);
            Controls.Add(sideBar1);
            Margin = new Padding(0);
            Name = "CheckInOut";
            Size = new Size(798, 398);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.SideBar sideBar1;
        private CustomTextBox studentIDTextBox;
        private CustomTextBox bookIDTextBox;
        private Button checkInButton;
        private Button checkOutButton;
        private Label successLabel;
        private Label alreadyCheckedInLabel;
        private Label label1;
    }
}
