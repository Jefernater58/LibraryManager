using System.Diagnostics;

namespace LibraryManager.Pages
{
    public partial class Login : UserControl
    {
        private MainForm parentForm;

        public Login()
        {
            InitializeComponent();
        }

        // get the parent form of the control, when it loads, so that we can change the page
        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            parentForm = (MainForm)FindForm();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // get the username and password from the textboxes
            string username = usernameTextBox.TextBoxText;
            string password = passwordTextBox.TextBoxText;

            // database functionality to be added here

            if (username != null && password != null)
            {
                if (username == "test" && password == "test")
                {
                    incorrectCredentialsLabel.Visible = false;

                    parentForm.openPage(new Pages.Home(), "Home");
                }
                else
                {
                    incorrectCredentialsLabel.Visible = true;
                }
            }
            else
            {
                Debug.WriteLine("Unexpected error: textbox value is null");
            }
        }
    }
}