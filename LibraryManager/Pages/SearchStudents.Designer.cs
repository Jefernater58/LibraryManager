namespace LibraryManager.Pages
{
    partial class SearchStudents
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            sideBar1 = new LibraryManager.CustomControls.SideBar();
            searchTextBox = new CustomTextBox();
            searchButton = new Button();
            dataGrid = new DataGridView();
            StudentID = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            StudentYearGroup = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // sideBar1
            // 
            sideBar1.BackColor = Color.FromArgb(38, 44, 54);
            sideBar1.CurrentFormIndex = 1;
            sideBar1.Location = new Point(0, 0);
            sideBar1.Name = "sideBar1";
            sideBar1.Size = new Size(198, 398);
            sideBar1.TabIndex = 0;
            // 
            // searchTextBox
            // 
            searchTextBox.BackColor = Color.FromArgb(51, 59, 71);
            searchTextBox.IconText = "";
            searchTextBox.Location = new Point(230, 32);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PasswordChar = '\0';
            searchTextBox.Size = new Size(300, 36);
            searchTextBox.TabIndex = 1;
            searchTextBox.TextBoxPlaceholder = "Enter search term...";
            searchTextBox.TextBoxText = "";
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
            searchButton.TabIndex = 3;
            searchButton.Text = "SEARCH";
            searchButton.UseVisualStyleBackColor = false;
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.BackgroundColor = Color.FromArgb(51, 59, 71);
            dataGrid.BorderStyle = BorderStyle.None;
            dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(51, 59, 71);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { StudentID, StudentName, StudentYearGroup });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(38, 44, 54);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.GridColor = Color.FromArgb(38, 44, 54);
            dataGrid.Location = new Point(230, 100);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.RowHeadersVisible = false;
            dataGrid.Size = new Size(536, 266);
            dataGrid.TabIndex = 5;
            // 
            // StudentID
            // 
            StudentID.HeaderText = "ID";
            StudentID.Name = "StudentID";
            StudentID.ReadOnly = true;
            StudentID.Resizable = DataGridViewTriState.False;
            StudentID.Width = 48;
            // 
            // StudentName
            // 
            StudentName.HeaderText = "Name";
            StudentName.Name = "StudentName";
            StudentName.ReadOnly = true;
            StudentName.Resizable = DataGridViewTriState.False;
            StudentName.Width = 370;
            // 
            // StudentYearGroup
            // 
            StudentYearGroup.HeaderText = "Year Group";
            StudentYearGroup.Name = "StudentYearGroup";
            StudentYearGroup.ReadOnly = true;
            StudentYearGroup.Resizable = DataGridViewTriState.False;
            // 
            // SearchStudents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 49, 59);
            Controls.Add(dataGrid);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(sideBar1);
            Margin = new Padding(0);
            Name = "SearchStudents";
            Size = new Size(798, 398);
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.SideBar sideBar1;
        private CustomTextBox searchTextBox;
        private Button searchButton;
        private DataGridView dataGrid;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn StudentYearGroup;
    }
}
