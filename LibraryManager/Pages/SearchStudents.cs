using Microsoft.Data.Sqlite;

namespace LibraryManager.Pages
{
    public partial class SearchStudents : UserControl
    {
        public SearchStudents()
        {
            InitializeComponent();

            StudentEntry[] data = loadData();

            // add the students to the displayed list
            for (int i = 0; i < data.Length; i++)
            {
                StudentEntry entry = data[i];

                dataGrid.Rows.Add(entry.Id, entry.FirstName + " " + entry.LastName, "£" + entry.AmountOwed.ToString());
            }
        }

        StudentEntry[] loadData()
        {
            // connect to the database
            string connectionString = "Data Source=db.sqlite";
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                // create a command to get all students from the database table
                var getStudentsCmd = connection.CreateCommand();
                getStudentsCmd.CommandText =
                @"
                    SELECT * FROM Students;
                ";

                // iterate through results and create objects to use in code
                StudentEntry[] allRecords;
                List<StudentEntry> list = new List<StudentEntry>();
                using (var reader = getStudentsCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new StudentEntry(reader.GetInt64(0),
                                               reader.GetString(1),
                                               reader.GetString(2),
                                               reader.GetFloat(3)));
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
            StudentEntry[] data = loadData();

            dataGrid.Rows.Clear();
            for (int i = 0; i < data.Length; i++)
            {
                StudentEntry entry = data[i];
                if (query == "" || (entry.FirstName + " " + entry.LastName).ToLower().Contains(query.ToLower()))
                {
                    dataGrid.Rows.Add(entry.Id, entry.FirstName + " " + entry.LastName, "£" + entry.AmountOwed.ToString());
                }
            }
        }
    }

    public class StudentEntry
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float AmountOwed { get; set; }

        public StudentEntry(long Id, string FirstName, string LastName, float AmountOwed)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.AmountOwed = AmountOwed;
        }
    }
}
