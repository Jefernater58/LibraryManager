namespace LibraryManager
{
    public partial class MainForm : Form
    {
        // constant for the window title
        private const string windowTitle = "Library Manager";
        // the page to open on startup
        private UserControl startPage = new Pages.Login();

        public MainForm()
        {
            InitializeComponent();
            // open the login page on startup
            openPage(startPage, "Login");
        }

        public bool adminPrompt()
        {
            // open a password dialogue
            PasswordDialogue passwordDialogue = new PasswordDialogue();
            DialogResult result = passwordDialogue.ShowDialog();
            
            // return true if the result is OK
            return result == DialogResult.OK;
        }

        public void openPage(UserControl page, string pageTitle)
        {
            // close the current page if it exists
            if (Controls.ContainsKey("currentPage"))
            {
                Controls.RemoveByKey("currentPage");
            }

            // rename the title of the window and position the page
            titleBar.Title = windowTitle + " - " + pageTitle;
            page.Location = new Point(1, titleBar.Height + 1);

            // rename the page so that it can be removed later
            page.Name = "currentPage";

            // add the to the form
            Controls.Add(page);
        }
    }
}
