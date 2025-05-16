namespace LibraryManager.Pages
{
    public partial class SearchBooks : UserControl
    {
        public SearchBooks()
        {
            InitializeComponent();

            // temporary to show the design
            dataGrid.Rows.Add(0, "1984", "George Orwell", "5/5", true);
            dataGrid.Rows.Add(1, "To Kill a Mockingbird", "Harper Lee", "4/5", false);
            dataGrid.Rows.Add(2, "The Great Gatsby", "F. Scott Fitzgerald", "3/5", true);
            dataGrid.Rows.Add(3, "Brave New World", "Aldous Huxley", "4/5", true);
            dataGrid.Rows.Add(4, "Moby Dick", "Herman Melville", "2/5", false);
            dataGrid.Rows.Add(5, "Pride and Prejudice", "Jane Austen", "5/5", true);
            dataGrid.Rows.Add(6, "The Catcher in the Rye", "J.D. Salinger", "3/5", false);
            dataGrid.Rows.Add(7, "The Hobbit", "J.R.R. Tolkien", "5/5", true);
            dataGrid.Rows.Add(8, "Fahrenheit 451", "Ray Bradbury", "4/5", true);
            dataGrid.Rows.Add(9, "Jane Eyre", "Charlotte Brontë", "4/5", false);
            dataGrid.Rows.Add(10, "The Odyssey", "Homer", "5/5", true);

            // TODO: add search functionality to search the database for books
        }
    }
}
