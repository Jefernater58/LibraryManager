namespace LibraryManager.CustomControls
{
    partial class SideBar
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
            editStudentsIcon = new Label();
            editInventoryIcon = new Label();
            checkInOutIcon = new Label();
            searchBooksIcon = new Label();
            searchStudentsIcon = new Label();
            homeIcon = new Label();
            editStudentsButton = new Button();
            editInventoryButton = new Button();
            checkInOutButton = new Button();
            searchBooksButton = new Button();
            searchStudentsButton = new Button();
            homeButton = new Button();
            SuspendLayout();
            // 
            // editStudentsIcon
            // 
            editStudentsIcon.AutoSize = true;
            editStudentsIcon.Font = new Font("Segoe Fluent Icons", 15F);
            editStudentsIcon.ForeColor = Color.FromArgb(92, 95, 119);
            editStudentsIcon.Location = new Point(3, 367);
            editStudentsIcon.Name = "editStudentsIcon";
            editStudentsIcon.Size = new Size(29, 20);
            editStudentsIcon.TabIndex = 9;
            editStudentsIcon.Text = "";
            // 
            // editInventoryIcon
            // 
            editInventoryIcon.AutoSize = true;
            editInventoryIcon.Font = new Font("Segoe Fluent Icons", 15F);
            editInventoryIcon.ForeColor = Color.FromArgb(92, 95, 119);
            editInventoryIcon.Location = new Point(2, 179);
            editInventoryIcon.Name = "editInventoryIcon";
            editInventoryIcon.Size = new Size(29, 20);
            editInventoryIcon.TabIndex = 11;
            editInventoryIcon.Text = "";
            // 
            // checkInOutIcon
            // 
            checkInOutIcon.AutoSize = true;
            checkInOutIcon.Font = new Font("Segoe Fluent Icons", 15F);
            checkInOutIcon.ForeColor = Color.FromArgb(92, 95, 119);
            checkInOutIcon.Location = new Point(2, 137);
            checkInOutIcon.Name = "checkInOutIcon";
            checkInOutIcon.Size = new Size(29, 20);
            checkInOutIcon.TabIndex = 12;
            checkInOutIcon.Text = "";
            // 
            // searchBooksIcon
            // 
            searchBooksIcon.AutoSize = true;
            searchBooksIcon.Font = new Font("Segoe Fluent Icons", 15F);
            searchBooksIcon.ForeColor = Color.FromArgb(92, 95, 119);
            searchBooksIcon.Location = new Point(2, 95);
            searchBooksIcon.Name = "searchBooksIcon";
            searchBooksIcon.Size = new Size(29, 20);
            searchBooksIcon.TabIndex = 13;
            searchBooksIcon.Text = "";
            // 
            // searchStudentsIcon
            // 
            searchStudentsIcon.AutoSize = true;
            searchStudentsIcon.Font = new Font("Segoe Fluent Icons", 15F);
            searchStudentsIcon.ForeColor = Color.FromArgb(92, 95, 119);
            searchStudentsIcon.Location = new Point(2, 53);
            searchStudentsIcon.Name = "searchStudentsIcon";
            searchStudentsIcon.Size = new Size(29, 20);
            searchStudentsIcon.TabIndex = 14;
            searchStudentsIcon.Text = "";
            // 
            // homeIcon
            // 
            homeIcon.AutoSize = true;
            homeIcon.Font = new Font("Segoe Fluent Icons", 15F);
            homeIcon.ForeColor = Color.FromArgb(92, 95, 119);
            homeIcon.Location = new Point(2, 11);
            homeIcon.Name = "homeIcon";
            homeIcon.Size = new Size(29, 20);
            homeIcon.TabIndex = 15;
            homeIcon.Text = "";
            // 
            // editStudentsButton
            // 
            editStudentsButton.FlatAppearance.BorderSize = 0;
            editStudentsButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(204, 208, 218);
            editStudentsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 224, 232);
            editStudentsButton.FlatStyle = FlatStyle.Flat;
            editStudentsButton.ForeColor = Color.FromArgb(92, 95, 119);
            editStudentsButton.Location = new Point(32, 356);
            editStudentsButton.Name = "editStudentsButton";
            editStudentsButton.Size = new Size(166, 42);
            editStudentsButton.TabIndex = 2;
            editStudentsButton.Text = "Edit students (admin)";
            editStudentsButton.TextAlign = ContentAlignment.MiddleLeft;
            editStudentsButton.UseVisualStyleBackColor = true;
            editStudentsButton.Click += editStudentsButton_Click;
            // 
            // editInventoryButton
            // 
            editInventoryButton.FlatAppearance.BorderSize = 0;
            editInventoryButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(204, 208, 218);
            editInventoryButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 224, 232);
            editInventoryButton.FlatStyle = FlatStyle.Flat;
            editInventoryButton.ForeColor = Color.FromArgb(92, 95, 119);
            editInventoryButton.Location = new Point(31, 168);
            editInventoryButton.Name = "editInventoryButton";
            editInventoryButton.Size = new Size(166, 42);
            editInventoryButton.TabIndex = 4;
            editInventoryButton.Text = "Edit inventory";
            editInventoryButton.TextAlign = ContentAlignment.MiddleLeft;
            editInventoryButton.UseVisualStyleBackColor = true;
            editInventoryButton.Click += editInventoryButton_Click;
            // 
            // checkInOutButton
            // 
            checkInOutButton.FlatAppearance.BorderSize = 0;
            checkInOutButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(204, 208, 218);
            checkInOutButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 224, 232);
            checkInOutButton.FlatStyle = FlatStyle.Flat;
            checkInOutButton.ForeColor = Color.FromArgb(92, 95, 119);
            checkInOutButton.Location = new Point(31, 126);
            checkInOutButton.Name = "checkInOutButton";
            checkInOutButton.Size = new Size(166, 42);
            checkInOutButton.TabIndex = 5;
            checkInOutButton.Text = "Borrow / return books";
            checkInOutButton.TextAlign = ContentAlignment.MiddleLeft;
            checkInOutButton.UseVisualStyleBackColor = true;
            checkInOutButton.Click += checkInOutButton_Click;
            // 
            // searchBooksButton
            // 
            searchBooksButton.FlatAppearance.BorderSize = 0;
            searchBooksButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(204, 208, 218);
            searchBooksButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 224, 232);
            searchBooksButton.FlatStyle = FlatStyle.Flat;
            searchBooksButton.ForeColor = Color.FromArgb(92, 95, 119);
            searchBooksButton.Location = new Point(31, 84);
            searchBooksButton.Name = "searchBooksButton";
            searchBooksButton.Size = new Size(166, 42);
            searchBooksButton.TabIndex = 6;
            searchBooksButton.Text = "Search for books";
            searchBooksButton.TextAlign = ContentAlignment.MiddleLeft;
            searchBooksButton.UseVisualStyleBackColor = true;
            searchBooksButton.Click += searchBooksButton_Click;
            // 
            // searchStudentsButton
            // 
            searchStudentsButton.FlatAppearance.BorderSize = 0;
            searchStudentsButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(204, 208, 218);
            searchStudentsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 224, 232);
            searchStudentsButton.FlatStyle = FlatStyle.Flat;
            searchStudentsButton.ForeColor = Color.FromArgb(92, 95, 119);
            searchStudentsButton.Location = new Point(31, 42);
            searchStudentsButton.Name = "searchStudentsButton";
            searchStudentsButton.Size = new Size(166, 42);
            searchStudentsButton.TabIndex = 7;
            searchStudentsButton.Text = "Search for students";
            searchStudentsButton.TextAlign = ContentAlignment.MiddleLeft;
            searchStudentsButton.UseVisualStyleBackColor = true;
            searchStudentsButton.Click += searchStudentsButton_Click;
            // 
            // homeButton
            // 
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(204, 208, 218);
            homeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 224, 232);
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.ForeColor = Color.FromArgb(92, 95, 119);
            homeButton.Location = new Point(31, 0);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(166, 42);
            homeButton.TabIndex = 8;
            homeButton.Text = "Home";
            homeButton.TextAlign = ContentAlignment.MiddleLeft;
            homeButton.UseVisualStyleBackColor = true;
            homeButton.Click += homeButton_Click;
            // 
            // SideBar
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(220, 224, 232);
            Controls.Add(editStudentsIcon);
            Controls.Add(editInventoryIcon);
            Controls.Add(checkInOutIcon);
            Controls.Add(searchBooksIcon);
            Controls.Add(searchStudentsIcon);
            Controls.Add(homeIcon);
            Controls.Add(editStudentsButton);
            Controls.Add(editInventoryButton);
            Controls.Add(checkInOutButton);
            Controls.Add(searchBooksButton);
            Controls.Add(searchStudentsButton);
            Controls.Add(homeButton);
            Name = "SideBar";
            Size = new Size(198, 398);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label editStudentsIcon;
        private Label editInventoryIcon;
        private Label checkInOutIcon;
        private Label searchBooksIcon;
        private Label searchStudentsIcon;
        private Label homeIcon;
        private Button editStudentsButton;
        private Button editInventoryButton;
        private Button checkInOutButton;
        private Button searchBooksButton;
        private Button searchStudentsButton;
        private Button homeButton;
    }
}
