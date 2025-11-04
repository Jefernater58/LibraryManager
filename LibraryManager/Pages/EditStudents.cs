using Microsoft.Data.Sqlite;
using System.Security.Cryptography;
using System.Text;

namespace LibraryManager.Pages
{
    public partial class EditStudents : UserControl
    {
        public EditStudents()
        {
            InitializeComponent();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            emptyFieldLabel.Visible = false;
            studentAddedLabel.Visible = false;

            // get the inputs
            string firstName = addStudentFirstNameTextBox.TextBoxText;
            string lastName = addStudentLastNameTextBox.TextBoxText;
            string yearGroup = addStudentYearGroupTextBox.TextBoxText;


            // if the inputs are empty, notify user
            if (firstName == "" || lastName == "" || yearGroup == "")
            {
                emptyFieldLabel.Visible = true;
                return;
            }

            // validate year group input
            if (!int.TryParse(yearGroup, out int year) || year < 1 || year > 13)
            {
                invalidYearGroupLabel.Visible = true;
                return;
            }

            // connect to the database
            string connectionString = "Data Source=db.sqlite";
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                // add the student to the database
                var addStudentCommand = connection.CreateCommand();
                addStudentCommand.CommandText =
                @"
                    INSERT INTO Students (FirstName, LastName, AmountOwed)
                    VALUES (
                        $firstname,
                        $lastname,
                        $amountowed
                    );
                ";
                addStudentCommand.Parameters.AddWithValue("$firstname", firstName);
                addStudentCommand.Parameters.AddWithValue("$lastname", lastName);
                addStudentCommand.Parameters.AddWithValue("$amountowed", 0);
                addStudentCommand.ExecuteNonQuery();

                studentAddedLabel.Visible = true;
            }
        }

        private void removeStudentButton_Click(object sender, EventArgs e)
        {
            studentRemovedLabel.Visible = false;
            studentDoesNotExistLabel.Visible = false;

            string studentId = removeStudentIDTextBox.TextBoxText;

            // validate id
            if (!int.TryParse(studentId, out int studentIdInt))
            {
                studentDoesNotExistLabel.Visible = true;
                return;
            }

            // open SQL connection
            string connectionString = "Data Source=db.sqlite";
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                // check if the student exists
                var studentExistsCmd = connection.CreateCommand();
                studentExistsCmd.CommandText =
                @"
                    SELECT COUNT(*) FROM Students
                    WHERE Id = $studentid;
                ";
                studentExistsCmd.Parameters.AddWithValue("$studentid", int.Parse(studentId));
                long result = (long)studentExistsCmd.ExecuteScalar();

                if (result == 0)
                {
                    // there are no student with this ID, so return
                    studentDoesNotExistLabel.Visible = true;
                    return;
                }

                // remove the student
                var removeStudentCmd = connection.CreateCommand();
                removeStudentCmd.CommandText =
                @"
                    DELETE FROM Students
                    WHERE Id = $studentid;
                ";
                removeStudentCmd.Parameters.AddWithValue("$studentid", int.Parse(studentId));
                removeStudentCmd.ExecuteNonQuery();

                studentRemovedLabel.Visible = true;
            }
        }
    }
}
