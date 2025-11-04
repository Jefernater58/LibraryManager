using Microsoft.Data.Sqlite;

namespace LibraryManager.Pages
{
    public partial class EditInventory : UserControl
    {
        public EditInventory()
        {
            InitializeComponent();
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            emptyFieldLabel.Visible = false;
            bookAddedLabel.Visible = false;

            // get the inputs
            string title = newBookTitleTextBox.TextBoxText;
            string author = addBookAuthorTextBox.TextBoxText;


            // if the inputs are empty, notify user
            if (title == "" || author == "")
            {
                emptyFieldLabel.Visible = true;
                return;
            }

            // connect to the database
            string connectionString = "Data Source=db.sqlite";
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                // add the book to the database
                var addBookCmd = connection.CreateCommand();
                addBookCmd.CommandText =
                @"
                    INSERT INTO Books (Title, Author, RatingsJson, CheckedOut, CheckedOutDate, CheckedOutStudentId)
                    VALUES (
                        $title,
                        $author,
                        NULL,
                        0,
                        NULL,
                        NULL
                    );
                ";
                addBookCmd.Parameters.AddWithValue("$title", title);
                addBookCmd.Parameters.AddWithValue("$author", author);
                addBookCmd.ExecuteNonQuery();

                bookAddedLabel.Visible = true;
            }
        }

        private void removeBookButton_Click(object sender, EventArgs e)
        {
            bookRemovedLabel.Visible = false;
            bookDoesNotExistLabel.Visible = false;

            string bookId = removeBookIDTextBox.TextBoxText;

            // validate id
            if (!int.TryParse(bookId, out int bookIdInt))
            {
                bookDoesNotExistLabel.Visible = true;
                return;
            }

            // open SQL connection
            string connectionString = "Data Source=db.sqlite";
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                // check if the book exists
                var bookExistsCmd = connection.CreateCommand();
                bookExistsCmd.CommandText =
                @"
                    SELECT COUNT(*) FROM Books
                    WHERE Id = $bookid;
                ";
                bookExistsCmd.Parameters.AddWithValue("$bookid", int.Parse(bookId));
                long result = (long)bookExistsCmd.ExecuteScalar();

                if (result == 0)
                {
                    // there are no student with this ID, so return
                    bookDoesNotExistLabel.Visible = true;
                    return;
                }

                // remove the book
                var removeBookCmd = connection.CreateCommand();
                removeBookCmd.CommandText =
                @"
                    DELETE FROM Books
                    WHERE Id = $bookid;
                ";
                removeBookCmd.Parameters.AddWithValue("$bookid", int.Parse(bookId));
                removeBookCmd.ExecuteNonQuery();

                bookRemovedLabel.Visible = true;
            }
        }
    }
}
