namespace LibraryManager.Pages
{
    partial class SearchBooks
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            sideBar1 = new CustomControls.SideBar();
            dataGrid = new DataGridView();
            BookID = new DataGridViewTextBoxColumn();
            BookTitle = new DataGridViewTextBoxColumn();
            BookAuthor = new DataGridViewTextBoxColumn();
            BookRating = new DataGridViewTextBoxColumn();
            InLibrary = new DataGridViewCheckBoxColumn();
            searchButton = new Button();
            searchTextBox = new CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // sideBar1
            // 
            sideBar1.BackColor = Color.FromArgb(230, 233, 239);
            sideBar1.CurrentFormIndex = 2;
            sideBar1.Location = new Point(0, 0);
            sideBar1.Name = "sideBar1";
            sideBar1.Size = new Size(198, 398);
            sideBar1.TabIndex = 0;
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.BackgroundColor = Color.FromArgb(230, 233, 239);
            dataGrid.BorderStyle = BorderStyle.None;
            dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(220, 224, 232);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(76, 79, 105);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { BookID, BookTitle, BookAuthor, BookRating, InLibrary });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(230, 233, 239);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(76, 79, 105);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.GridColor = Color.FromArgb(230, 233, 239);
            dataGrid.Location = new Point(230, 100);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.RowHeadersVisible = false;
            dataGrid.Size = new Size(536, 266);
            dataGrid.TabIndex = 8;
            // 
            // BookID
            // 
            BookID.HeaderText = "ID";
            BookID.Name = "BookID";
            BookID.ReadOnly = true;
            BookID.Resizable = DataGridViewTriState.False;
            BookID.Width = 48;
            // 
            // BookTitle
            // 
            BookTitle.HeaderText = "Title";
            BookTitle.Name = "BookTitle";
            BookTitle.ReadOnly = true;
            BookTitle.Resizable = DataGridViewTriState.False;
            BookTitle.Width = 171;
            // 
            // BookAuthor
            // 
            BookAuthor.HeaderText = "Author";
            BookAuthor.Name = "BookAuthor";
            BookAuthor.ReadOnly = true;
            BookAuthor.Resizable = DataGridViewTriState.False;
            BookAuthor.Width = 171;
            // 
            // BookRating
            // 
            BookRating.HeaderText = "Rating";
            BookRating.Name = "BookRating";
            BookRating.ReadOnly = true;
            BookRating.Resizable = DataGridViewTriState.False;
            BookRating.Width = 48;
            // 
            // InLibrary
            // 
            InLibrary.HeaderText = "In Library";
            InLibrary.Name = "InLibrary";
            InLibrary.ReadOnly = true;
            InLibrary.Resizable = DataGridViewTriState.False;
            InLibrary.SortMode = DataGridViewColumnSortMode.Automatic;
            InLibrary.Width = 80;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.FromArgb(79, 158, 235);
            searchButton.FlatAppearance.BorderColor = Color.FromArgb(35, 133, 231);
            searchButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(113, 176, 239);
            searchButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(99, 168, 238);
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(562, 32);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(204, 36);
            searchButton.TabIndex = 7;
            searchButton.Text = "SEARCH";
            searchButton.UseVisualStyleBackColor = false;
            // 
            // searchTextBox
            // 
            searchTextBox.BackColor = Color.FromArgb(204, 208, 218);
            searchTextBox.IconText = "";
            searchTextBox.Location = new Point(230, 32);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PasswordChar = '\0';
            searchTextBox.Size = new Size(300, 36);
            searchTextBox.TabIndex = 6;
            searchTextBox.TextBoxPlaceholder = "Enter search term...";
            searchTextBox.TextBoxText = "";
            // 
            // SearchBooks
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(239, 241, 245);
            Controls.Add(dataGrid);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(sideBar1);
            Margin = new Padding(0);
            Name = "SearchBooks";
            Size = new Size(798, 398);
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.SideBar sideBar1;
        private DataGridView dataGrid;
        private Button searchButton;
        private CustomTextBox searchTextBox;
        private DataGridViewTextBoxColumn BookID;
        private DataGridViewTextBoxColumn BookTitle;
        private DataGridViewTextBoxColumn BookAuthor;
        private DataGridViewTextBoxColumn BookRating;
        private DataGridViewCheckBoxColumn InLibrary;
    }
}
