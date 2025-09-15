using Microsoft.Data.Sqlite;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;

namespace LibraryManager.Pages
{
    public partial class Login : UserControl
    {
        private MainForm? parentForm;

        public Login()
        {
            InitializeComponent();
        }

        // get the parent form of the control, when it loads, so that we can change the page
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            parentForm = (MainForm?)FindForm();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // get the username and password from the textboxes
            string username = usernameTextBox.TextBoxText;
            string password = passwordTextBox.TextBoxText;

            // if the username or password is empty, show an error message
            if (username == "" || password == "" || username == null || password == null)
            {
                incorrectCredentialsLabel.Visible = false;
                emptyFieldLabel.Visible = true;
            }

            // generate a hash of the password
            string hashString;
            using (var md5 = MD5.Create())
            {
                byte[] hashBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
                hashString = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }

            bool authenticated = false;
            bool isAdmin = false;

            // connect to the database
            string connectionString = "Data Source=db.sqlite";
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                // create the Users table if it doesn't exist
                var createCmd = connection.CreateCommand();
                createCmd.CommandText =
                @"
                    CREATE TABLE IF NOT EXISTS Users (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        PasswordHash TEXT NOT NULL,
                        Admin BOOLEAN NOT NULL DEFAULT 0
                    );
                ";
                createCmd.ExecuteNonQuery();

                // check if the user exists
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText =
                @"
                    SELECT COUNT(*) FROM Users
                    WHERE Name = $name AND PasswordHash = $passwordHash;
                ";
                // using a parameterized query to prevent SQL injection
                selectCmd.Parameters.AddWithValue("$name", username);
                selectCmd.Parameters.AddWithValue("$passwordHash", hashString);
                long result = (long)selectCmd.ExecuteScalar();
                if (result == 1) 
                {
                    authenticated = true;

                    // get whether the user is administrator
                    var adminCmd = connection.CreateCommand();
                    adminCmd.CommandText =
                        @"
                            SELECT Admin FROM Users
                            WHERE Name = $name AND PasswordHash = $passwordHash;
                        ";
                    adminCmd.Parameters.AddWithValue("$name", username);
                    adminCmd.Parameters.AddWithValue("$passwordHash", hashString);
                    isAdmin = (long)adminCmd.ExecuteScalar() != 0;
                }
                else if (result > 1)
                {
                    throw new Exception("Database error: multiple users with the same username and password. Please contact your administrator.");
                }
            }

            if (authenticated)
            {
                // open the home page
                incorrectCredentialsLabel.Visible = false;
                emptyFieldLabel.Visible = false;
                parentForm.openPage(new Pages.Home(), "Home");

                // set isAdmin in MainForm to appropriate value
                parentForm.IsAdmin = isAdmin;
            }
            else
            {
                // tell the user that the credentials are incorrect
                emptyFieldLabel.Visible = false;
                incorrectCredentialsLabel.Visible = true;
            }
        }
    }
}