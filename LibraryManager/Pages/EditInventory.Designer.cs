namespace LibraryManager.Pages
{
    partial class EditInventory
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
            newBookTitleTextBox = new CustomTextBox();
            label1 = new Label();
            removeBookIDTextBox = new CustomTextBox();
            label2 = new Label();
            addBookAuthorTextBox = new CustomTextBox();
            addBookButton = new Button();
            removeBookButton = new Button();
            bookAddedLabel = new Label();
            emptyFieldLabel = new Label();
            bookRemovedLabel = new Label();
            bookDoesNotExistLabel = new Label();
            SuspendLayout();
            // 
            // sideBar1
            // 
            sideBar1.BackColor = Color.FromArgb(220, 224, 232);
            sideBar1.CurrentFormIndex = 4;
            sideBar1.Location = new Point(0, 0);
            sideBar1.Name = "sideBar1";
            sideBar1.Size = new Size(198, 398);
            sideBar1.TabIndex = 0;
            // 
            // newBookTitleTextBox
            // 
            newBookTitleTextBox.BackColor = Color.FromArgb(204, 208, 218);
            newBookTitleTextBox.IconText = "";
            newBookTitleTextBox.Location = new Point(230, 67);
            newBookTitleTextBox.Name = "newBookTitleTextBox";
            newBookTitleTextBox.PasswordChar = '\0';
            newBookTitleTextBox.Size = new Size(260, 36);
            newBookTitleTextBox.TabIndex = 2;
            newBookTitleTextBox.TextBoxPlaceholder = "Title";
            newBookTitleTextBox.TextBoxText = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(76, 79, 105);
            label1.Location = new Point(312, 32);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 3;
            label1.Text = "Add a new book";
            // 
            // removeBookIDTextBox
            // 
            removeBookIDTextBox.BackColor = Color.FromArgb(204, 208, 218);
            removeBookIDTextBox.IconText = "";
            removeBookIDTextBox.Location = new Point(509, 67);
            removeBookIDTextBox.Name = "removeBookIDTextBox";
            removeBookIDTextBox.PasswordChar = '\0';
            removeBookIDTextBox.Size = new Size(260, 36);
            removeBookIDTextBox.TabIndex = 2;
            removeBookIDTextBox.TextBoxPlaceholder = "BookID";
            removeBookIDTextBox.TextBoxText = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(76, 79, 105);
            label2.Location = new Point(563, 32);
            label2.Name = "label2";
            label2.Size = new Size(148, 15);
            label2.TabIndex = 3;
            label2.Text = "Remove an existing book";
            // 
            // addBookAuthorTextBox
            // 
            addBookAuthorTextBox.BackColor = Color.FromArgb(204, 208, 218);
            addBookAuthorTextBox.IconText = "";
            addBookAuthorTextBox.Location = new Point(230, 121);
            addBookAuthorTextBox.Name = "addBookAuthorTextBox";
            addBookAuthorTextBox.PasswordChar = '\0';
            addBookAuthorTextBox.Size = new Size(260, 36);
            addBookAuthorTextBox.TabIndex = 2;
            addBookAuthorTextBox.TextBoxPlaceholder = "Author";
            addBookAuthorTextBox.TextBoxText = "";
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
            addBookButton.Location = new Point(230, 177);
            addBookButton.Name = "addBookButton";
            addBookButton.Size = new Size(260, 36);
            addBookButton.TabIndex = 8;
            addBookButton.Text = "ADD";
            addBookButton.UseVisualStyleBackColor = false;
            addBookButton.Click += addBookButton_Click;
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
            removeBookButton.Location = new Point(509, 121);
            removeBookButton.Name = "removeBookButton";
            removeBookButton.Size = new Size(260, 36);
            removeBookButton.TabIndex = 9;
            removeBookButton.Text = "REMOVE";
            removeBookButton.UseVisualStyleBackColor = false;
            removeBookButton.Click += removeBookButton_Click;
            // 
            // bookAddedLabel
            // 
            bookAddedLabel.AutoSize = true;
            bookAddedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bookAddedLabel.ForeColor = Color.FromArgb(15, 210, 57);
            bookAddedLabel.Location = new Point(273, 216);
            bookAddedLabel.Name = "bookAddedLabel";
            bookAddedLabel.Size = new Size(169, 15);
            bookAddedLabel.TabIndex = 28;
            bookAddedLabel.Text = "New book added successfully";
            bookAddedLabel.Visible = false;
            // 
            // emptyFieldLabel
            // 
            emptyFieldLabel.AutoSize = true;
            emptyFieldLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            emptyFieldLabel.ForeColor = Color.FromArgb(210, 15, 57);
            emptyFieldLabel.Location = new Point(285, 216);
            emptyFieldLabel.Name = "emptyFieldLabel";
            emptyFieldLabel.Size = new Size(147, 15);
            emptyFieldLabel.TabIndex = 29;
            emptyFieldLabel.Text = "Fields must not be empty";
            emptyFieldLabel.Visible = false;
            // 
            // bookRemovedLabel
            // 
            bookRemovedLabel.AutoSize = true;
            bookRemovedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bookRemovedLabel.ForeColor = Color.FromArgb(15, 210, 57);
            bookRemovedLabel.Location = new Point(553, 160);
            bookRemovedLabel.Name = "bookRemovedLabel";
            bookRemovedLabel.Size = new Size(158, 15);
            bookRemovedLabel.TabIndex = 31;
            bookRemovedLabel.Text = "Book removed successfully";
            bookRemovedLabel.Visible = false;
            // 
            // bookDoesNotExistLabel
            // 
            bookDoesNotExistLabel.AutoSize = true;
            bookDoesNotExistLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bookDoesNotExistLabel.ForeColor = Color.FromArgb(210, 15, 57);
            bookDoesNotExistLabel.Location = new Point(546, 160);
            bookDoesNotExistLabel.Name = "bookDoesNotExistLabel";
            bookDoesNotExistLabel.Size = new Size(193, 15);
            bookDoesNotExistLabel.TabIndex = 30;
            bookDoesNotExistLabel.Text = "The specified book does not exist";
            bookDoesNotExistLabel.Visible = false;
            // 
            // EditInventory
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(239, 241, 245);
            Controls.Add(bookRemovedLabel);
            Controls.Add(bookDoesNotExistLabel);
            Controls.Add(emptyFieldLabel);
            Controls.Add(bookAddedLabel);
            Controls.Add(removeBookButton);
            Controls.Add(addBookButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(removeBookIDTextBox);
            Controls.Add(addBookAuthorTextBox);
            Controls.Add(newBookTitleTextBox);
            Controls.Add(sideBar1);
            Margin = new Padding(0);
            Name = "EditInventory";
            Size = new Size(798, 398);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.SideBar sideBar1;
        private CustomTextBox newBookTitleTextBox;
        private Label label1;
        private CustomTextBox removeBookIDTextBox;
        private Label label2;
        private CustomTextBox addBookAuthorTextBox;
        private Button addBookButton;
        private Button removeBookButton;
        private Label bookAddedLabel;
        private Label emptyFieldLabel;
        private Label bookRemovedLabel;
        private Label bookDoesNotExistLabel;
    }
}
