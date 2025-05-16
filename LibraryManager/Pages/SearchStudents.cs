namespace LibraryManager.Pages
{
    public partial class SearchStudents : UserControl
    {
        public SearchStudents()
        {
            InitializeComponent();

            // temporary to show the design
            dataGrid.Rows.Add(0, "John Smith", 7);
            dataGrid.Rows.Add(1, "Jane Doe", 8);
            dataGrid.Rows.Add(2, "Alice Johnson", 9);
            dataGrid.Rows.Add(3, "Bob Brown", 10);
            dataGrid.Rows.Add(4, "Charlie White", 11);
            dataGrid.Rows.Add(5, "Daisy Green", 12);
            dataGrid.Rows.Add(6, "Eve Black", 7);
            dataGrid.Rows.Add(7, "Frank Blue", 8);
            dataGrid.Rows.Add(8, "Grace Yellow", 9);
            dataGrid.Rows.Add(9, "Hank Purple", 10);
            dataGrid.Rows.Add(10, "Ivy Orange", 11);

            // TODO: add search functionality to search the database for students
        }
    }
}
