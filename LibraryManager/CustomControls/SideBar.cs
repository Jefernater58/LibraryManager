using System.ComponentModel;

namespace LibraryManager.CustomControls
{
    public partial class SideBar : UserControl
    {
        private MainForm? parentForm;

        // property for the current form, so that it can be highlighted in the sidebar
        private int _currentFormIndex = 0;
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int CurrentFormIndex
        {
            get => _currentFormIndex;
            set => _currentFormIndex = value;
        }

        // set the color for the highlight
        private Color highlightColor = Color.FromArgb(79, 158, 235);

        public SideBar()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            // get the parent form of the control, when it loads, so that we can change the page
            parentForm = (MainForm?)FindForm();

            // highlight the current form in the sidebar
            if (_currentFormIndex == 0)
            {
                homeButton.ForeColor = highlightColor;
                homeIcon.ForeColor = highlightColor;
            }
            else if (_currentFormIndex == 1)
            {
                searchStudentsButton.ForeColor = highlightColor;
                searchStudentsIcon.ForeColor = highlightColor;
            }
            else if (_currentFormIndex == 2)
            {
                searchBooksButton.ForeColor = highlightColor;
                searchBooksIcon.ForeColor = highlightColor;
            }
            else if (_currentFormIndex == 3)
            {
                checkInOutButton.ForeColor = highlightColor;
                checkInOutIcon.ForeColor = highlightColor;
            }
            else if (_currentFormIndex == 4)
            {
                editInventoryButton.ForeColor = highlightColor;
                editInventoryIcon.ForeColor = highlightColor;
            }
            else if (_currentFormIndex == 5)
            {
                editStudentsButton.ForeColor = highlightColor;
                editStudentsIcon.ForeColor = highlightColor;
            }

            base.OnLoad(e);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            parentForm?.openPage(new Pages.Home(), "Home");
        }

        private void searchStudentsButton_Click(object sender, EventArgs e)
        {
            parentForm?.openPage(new Pages.SearchStudents(), "Search for students");
        }

        private void searchBooksButton_Click(object sender, EventArgs e)
        {
            parentForm?.openPage(new Pages.SearchBooks(), "Search for books");
        }

        private void checkInOutButton_Click(object sender, EventArgs e)
        {
            parentForm?.openPage(new Pages.CheckInOut(), "Check in/out books");
        }

        private void editInventoryButton_Click(object sender, EventArgs e)
        {
            parentForm?.openPage(new Pages.EditInventory(), "Edit Inventory");
        }

        private void editStudentsButton_Click(object sender, EventArgs e)
        {
            // ask the user to enter the administrator password
            bool? result = parentForm?.adminPrompt();

            // only open the page if the password was entered correctly
            if ((bool)result) parentForm?.openPage(new Pages.EditStudents(), "Edit Students");
        }
    }
}
