namespace LibraryManager
{
    public partial class MainForm : Form
    {
        // constant for the window title
        private const string windowTitle = "Library Manager";

        public MainForm()
        {
            InitializeComponent();
            // open the login page on startup
            openPage(new Pages.Login(), "Login");
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
            page.Name = "currentPage";
            page.Location = new Point(1, titleBar.Height + 1);

            // add the to the form
            Controls.Add(page);
        }
    }
}
