using Microsoft.Data.Sqlite;

namespace LibraryManager.Pages
{
    public partial class CheckInOut : UserControl
    {
        public CheckInOut()
        {
            InitializeComponent();
        }

        private void checkInButton_Click(object sender, EventArgs e)
        {
            bookDoesNotExistLabel.Visible = false;
            studentDoesNotExistLabel.Visible = false;
            bookNotBorrowedLabel.Visible = false;

            string studentIdString = studentIDTextBox.TextBoxText;
            string bookIdString = bookIDTextBox.TextBoxText;

            // validate id
            if (!int.TryParse(bookIdString, out int bookIdInt))
            {
                bookDoesNotExistLabel.Visible = true;
                return;
            }
            if (!int.TryParse(studentIdString, out int studentIdInt))
            {
                studentDoesNotExistLabel.Visible = true;
                return;
            }

            // connect to the database
            string connectionString = "Data Source=db.sqlite";
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                // check if the student has borrowed the book
                var userExistsCmd = connection.CreateCommand();
                userExistsCmd.CommandText =
                @"
                    SELECT COUNT(*) FROM Books
                    WHERE CheckedOutStudentId = $studentid;
                    WHERE Id = $bookid;
                ";
                userExistsCmd.Parameters.AddWithValue("$studentid", int.Parse(studentIdString));
                userExistsCmd.Parameters.AddWithValue("$bookid", int.Parse(bookIdString));
                long result = (long)userExistsCmd.ExecuteScalar();

                if (result < 1)
                {
                    bookNotBorrowedLabel.Visible = true;
                    return;
                }

                // get checked out date, compare to current date. add to amount owed if overdue
                // update the database
                // show appropriate message to the user
            }
        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            string studentIdString = studentIDTextBox.TextBoxText;
            string bookIdString = bookIDTextBox.TextBoxText;
            // check database if the book is checked in and update the database
            // show appropriate message to the user
        }
    }
}
