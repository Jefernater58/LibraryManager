namespace LibraryManager.Pages
{
    public partial class CheckInOut : UserControl
    {
        public CheckInOut()
        {
            InitializeComponent();
        }

        private void checkInButton_Click(object sender, EventArgs e)
        {
            // check database if the book is checked out and update the database
            // show appropriate message to the user
        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            // check database if the book is checked in and update the database
            // show appropriate message to the user
        }
    }
}
