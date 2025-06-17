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

            // database functionality to be added here
            
            if (username != null && password != null)
            {
                if (username == "test" && password == "test")
                {
                    incorrectCredentialsLabel.Visible = false;

                    parentForm?.openPage(new Pages.Home(), "Home");
                }
                else if (username == "" || password == "")
                {
                    incorrectCredentialsLabel.Visible = false;
                    emptyFieldLabel.Visible = true;
                }

                else
                {
                    emptyFieldLabel.Visible = false;
                    incorrectCredentialsLabel.Visible = true;
                }
            }
            else
            {
                throw new Exception("An unexpected error occurred, username and password must not be null.");
            }
        }
    }
}