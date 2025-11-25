using Microsoft.Data.Sqlite;
using System.Diagnostics;

namespace LibraryManager.Pages
{
    public partial class CheckInOut : UserControl
    {
        private MainForm? parentForm;

        public CheckInOut()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            parentForm = (MainForm?)FindForm();
        }

        private void checkInButton_Click(object sender, EventArgs e)
        {
            bookDoesNotExistLabel.Visible = false;
            studentDoesNotExistLabel.Visible = false;
            bookNotBorrowedLabel.Visible = false;
            bookOverdueLabel.Visible = false;

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
                var bookBorrowedCmd = connection.CreateCommand();
                bookBorrowedCmd.CommandText =
                @"
                    SELECT COUNT(*) FROM Books
                    WHERE CheckedOutStudentId = $studentid;
                    WHERE Id = $bookid;
                ";
                bookBorrowedCmd.Parameters.AddWithValue("$studentid", int.Parse(studentIdString));
                bookBorrowedCmd.Parameters.AddWithValue("$bookid", int.Parse(bookIdString));
                long result = (long)bookBorrowedCmd.ExecuteScalar();

                if (result < 1)
                {
                    bookNotBorrowedLabel.Visible = true;
                    return;
                }

                // get information about the borrowed book
                var infoCmd = connection.CreateCommand();
                infoCmd.CommandText =
                @"
                    SELECT CheckedOutDate, CheckedOutStudentId
                    FROM Books
                    WHERE Id = $bookid;
                ";
                infoCmd.Parameters.AddWithValue("$bookid", int.Parse(bookIdString));

                DateTime checkedOutDate;
                DateTime now;
                long studentId;
                using (var reader = infoCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        checkedOutDate = Convert.ToDateTime(reader["CheckedOutDate"]);
                        now = DateTime.Now;

                        studentId = (long) reader["CheckedOutStudentId"];
                    }
                    else
                    {
                        Debug.WriteLine("No record found");
                        return;
                    }
                }

                int checkedOutDays = (now - checkedOutDate).Days;
                bool overdue = checkedOutDays > parentForm.MaxBorrowDays;
                Debug.WriteLine($"{checkedOutDays}, {overdue}");

                if (overdue)
                {
                    float overdueFee = parentForm.OverdueDailyFee * (checkedOutDays - parentForm.MaxBorrowDays);
                    if (overdueFee > parentForm.OverdueMaxFee)
                    {
                        overdueFee = parentForm.OverdueMaxFee;
                    }
                    Debug.WriteLine($"{overdueFee}");
                    bookOverdueLabel.Visible = true;
                    bookOverdueLabel.Text = $"This book has been returned {checkedOutDays - parentForm.MaxBorrowDays} days late. Please collect £{overdueFee:0.00}";
                }
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
