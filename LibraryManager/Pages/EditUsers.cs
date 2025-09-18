using System.Diagnostics;
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

            // TODO: add SQL statement
        }

        private void removeUserButton_click(object sender, EventArgs e)
        {

        }
    }
}
