using Microsoft.Data.Sqlite;
using System.Security.Cryptography;
using System.Text;

namespace LibraryManager.Pages
{
    public partial class EditUsers : UserControl
    {
        public EditUsers()
        {
            InitializeComponent();
        }

        private void addUserButton_click(object sender, EventArgs e)
        {
            emptyFieldLabel.Visible = false;
            passwordMatchLabel.Visible = false;
            userExistsLabel.Visible = false;
            userAddedLabel.Visible = false;

            // get the inputs
            string username = addUserUsernameTextbox.TextBoxText;
            string password = addUserPasswordTextbox.TextBoxText;
            string confirmPassword = addUserConfirmPasswordTextbox.TextBoxText;
            bool admin = addUserAdminCheckBox.Checked;

            // if the inputs are empty, notify user
            if (username == "" || password == "" || confirmPassword == "")
            {
                emptyFieldLabel.Visible = true;
                return;
            }

            string hashString;
            string confirmHashString;
            using (var md5 = MD5.Create())
            {
                byte[] hashBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
                hashString = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

                byte[] confirmHashBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(confirmPassword));
                confirmHashString = BitConverter.ToString(confirmHashBytes).Replace("-", "").ToLower();
            }

            if (!(hashString == confirmHashString))
            {
                passwordMatchLabel.Visible = true;
                return;
            }

            // connect to the database
            string connectionString = "Data Source=db.sqlite";
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                // check if the user exists
                var userExistsCmd = connection.CreateCommand();
                userExistsCmd.CommandText =
                @"
                    SELECT COUNT(*) FROM Users
                    WHERE Name = $username;
                ";
                userExistsCmd.Parameters.AddWithValue("$username", username);
                long result = (long)userExistsCmd.ExecuteScalar();

                if (result > 0)
                {
                    userExistsLabel.Visible = true;
                    return;
                }


                // add the user to the database
                var addUserCmd = connection.CreateCommand();
                addUserCmd.CommandText =
                @"
                    INSERT INTO Users (Name, PasswordHash, Admin)
                    VALUES (
                        $username,
                        $passwordHash,
                        $admin
                    );
                ";
                addUserCmd.Parameters.AddWithValue("$username", username);
                addUserCmd.Parameters.AddWithValue("$passwordHash", hashString);
                addUserCmd.Parameters.AddWithValue("$admin", admin);
                addUserCmd.ExecuteNonQuery();

                userAddedLabel.Visible = true;
            }
        }

        private void removeUserButton_click(object sender, EventArgs e)
        {
            userRemovedLabel.Visible = false;
            userDoesNotExistLabel.Visible = false;

            string username = removeUserUsernameTextBox.TextBoxText;

            // open SQL connection
            string connectionString = "Data Source=db.sqlite";
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                // check if the user exists
                var userExistsCmd = connection.CreateCommand();
                userExistsCmd.CommandText =
                @"
                    SELECT COUNT(*) FROM Users
                    WHERE Name = $username;
                ";
                userExistsCmd.Parameters.AddWithValue("$username", username);
                long result = (long)userExistsCmd.ExecuteScalar();

                if (result == 0)
                {
                    // there are no users with this username, so return
                    userDoesNotExistLabel.Visible = true;
                    return;
                }

                // remove the user
                var removeUserCmd = connection.CreateCommand();
                removeUserCmd.CommandText =
                @"
                    DELETE FROM Users
                    WHERE Name = $username;
                ";
                removeUserCmd.Parameters.AddWithValue("$username", username);
                removeUserCmd.ExecuteNonQuery();

                userRemovedLabel.Visible = true;
            }
        }
    }
}
