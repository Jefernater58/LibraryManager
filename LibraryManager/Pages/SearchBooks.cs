using Microsoft.Data.Sqlite;

namespace LibraryManager.Pages
{

    public partial class SearchBooks : UserControl
    {

        public SearchBooks()
        {
            InitializeComponent();

            BookEntry[] data = loadData();

            // add the books to the displayed list
            for (int i = 0; i < data.Length; i++)
            {
                BookEntry entry = data[i];

                // TODO: calculate average rating
                dataGrid.Rows.Add(entry.Id, entry.Title, entry.Author, "null", !entry.CheckedOut);
            }
        }

        BookEntry[] loadData()
        {
            // connect to the database
            string connectionString = "Data Source=db.sqlite";
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                // create a command to get all books from the database table
                var getBooksCmd = connection.CreateCommand();
                getBooksCmd.CommandText =
                @"
                    SELECT * FROM Books;
                ";

                // iterate through results and create objects to use in code
                BookEntry[] allRecords;
                List<BookEntry> list = new List<BookEntry>();
                using (var reader = getBooksCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new BookEntry(reader.GetInt64(0),
                                               reader.GetString(1),
                                               reader.GetString(2),
                                               reader.GetString(3),
                                               reader.GetBoolean(4)));
                    }

                    allRecords = list.ToArray();
                }

                // return the data
                return allRecords;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string query = searchTextBox.TextBoxText;
            BookEntry[] data = loadData();

            dataGrid.Rows.Clear();
            for (int i = 0; i < data.Length; i++)
            {
                BookEntry entry = data[i];
                if (query == "" || entry.Title.ToLower().Contains(query.ToLower()) || entry.Author.ToLower().Contains(query.ToLower()))
                {
                    dataGrid.Rows.Add(entry.Id, entry.Title, entry.Author, "nil", !entry.CheckedOut);
                }
            }
        }
    }

    public class BookEntry
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string RatingsJson { get; set; }
        public bool CheckedOut { get; set; }

        public BookEntry(long Id, string Title, string Author, string RatingsJson, bool CheckedOut)
        {
            this.Id = Id;
            this.Title = Title;
            this.Author = Author;
            this.RatingsJson = RatingsJson;
            this.CheckedOut = CheckedOut;
        }
    }
}
