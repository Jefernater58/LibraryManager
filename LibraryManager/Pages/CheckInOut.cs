using Microsoft.Data.Sqlite;
using System.Data;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            bookAlreadyBorrowedLabel.Visible = false;
            bookBorrowedLabel.Visible = false;
            bookReturnedLabel.Visible = false;

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
                    WHERE CheckedOutStudentId = $studentid AND Id = $bookid;
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
                    SELECT CheckedOut, CheckedOutDate, CheckedOutStudentId
                    FROM Books
                    WHERE Id = $bookid;
                ";
                infoCmd.Parameters.AddWithValue("$bookid", int.Parse(bookIdString));

                // cast the data to usable types
                DateTime checkedOutDate;
                DateTime now;
                long studentId;
                using (var reader = infoCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // cancel operation if the book isnt borrowed
                        if ((long)reader["CheckedOut"] == 0)
                        {
                            bookNotBorrowedLabel.Visible = true;
                            return;
                        }

                        checkedOutDate = Convert.ToDateTime(reader["CheckedOutDate"]);
                        now = DateTime.Now;

                        // if the user is wrong, cancel
                        studentId = (long) reader["CheckedOutStudentId"];
                        if (studentId != studentIdInt)
                        {
                            bookNotBorrowedLabel.Visible = true;
                            return;
                        }
                    }
                    else
                    {
                        Debug.WriteLine("No record found");
                        return;
                    }
                }

                int checkedOutDays = (now - checkedOutDate).Days;
                bool overdue = checkedOutDays > parentForm.MaxBorrowDays;

                // calculate the overdue fee if the book is overdue
                if (overdue)
                {
                    float overdueFee = parentForm.OverdueDailyFee * (checkedOutDays - parentForm.MaxBorrowDays);
                    if (overdueFee > parentForm.OverdueMaxFee) overdueFee = parentForm.OverdueMaxFee;

                    // display to the user
                    bookOverdueLabel.Visible = true;
                    bookOverdueLabel.Text = $"This book has been returned {checkedOutDays - parentForm.MaxBorrowDays} days late. Please collect £{overdueFee:0.00}";
                }

                // update the database
                var removeBorrowedBookCmd = connection.CreateCommand();
                removeBorrowedBookCmd.CommandText =
                @"
                    UPDATE Books
                    SET CheckedOut=0, CheckedOutDate=null, CheckedOutStudentId=null
                    WHERE Id=$BookID
                ";
                removeBorrowedBookCmd.Parameters.AddWithValue("$BookID", bookIdInt);
                removeBorrowedBookCmd.ExecuteNonQuery();

                // show appropriate message to the user
                bookReturnedLabel.Visible = true;
            }
        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            bookDoesNotExistLabel.Visible = false;
            studentDoesNotExistLabel.Visible = false;
            bookNotBorrowedLabel.Visible = false;
            bookOverdueLabel.Visible = false;
            bookAlreadyBorrowedLabel.Visible = false;
            bookBorrowedLabel.Visible = false;
            bookReturnedLabel.Visible = false; 

            string studentIdString = studentIDTextBox.TextBoxText;
            string bookIdString = bookIDTextBox.TextBoxText;
            // check database if the book is checked in and update the database
            // show appropriate message to the user

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
                    WHERE CheckedOutStudentId = $studentid AND Id = $bookid;
                ";
                bookBorrowedCmd.Parameters.AddWithValue("$studentid", int.Parse(studentIdString));
                bookBorrowedCmd.Parameters.AddWithValue("$bookid", int.Parse(bookIdString));
                long result = (long)bookBorrowedCmd.ExecuteScalar();

                if (result > 0)
                {
                    bookAlreadyBorrowedLabel.Visible = true;
                    return;
                }

                // update database
                var addBorrowedBookCmd = connection.CreateCommand();
                addBorrowedBookCmd.CommandText =
                @"
                    UPDATE Books
                    SET CheckedOut=1, CheckedOutDate=DATE(@date), CheckedOutStudentId=$studentID
                    WHERE Id=$BookID
                ";
                addBorrowedBookCmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                addBorrowedBookCmd.Parameters.AddWithValue("$BookID", bookIdInt);
                addBorrowedBookCmd.Parameters.AddWithValue("$studentID", studentIdInt);
                addBorrowedBookCmd.ExecuteNonQuery();

                // show appropriate message to the user
                bookBorrowedLabel.Visible = true;
            }
        }
    }
}
