using System.ComponentModel;
using System.Runtime.InteropServices;

namespace LibraryManager
{
    [DefaultEvent(nameof(Click))]
    public partial class TitleBar : UserControl
    {
        // Constants for Windows API, so that we can move the window
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        // get the form that the title bar is on
        private Form parentForm;

        // make the title property visible in the properties window, so that it can be changed for each form
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Title
        {
            get => title.Text;
            set => title.Text = value;
        }

        public TitleBar()
        {
            InitializeComponent();
        }

        public void titleBar_mouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(parentForm.Handle, 0xA1, 0x2, 0);
            }
        }

        public void minimiseButton_click(object sender, EventArgs e)
        {
            Form form = (Form)((Button)sender).Parent.Parent;
            form.WindowState = FormWindowState.Minimized;
        }

        public void toggleButton_click(object sender, EventArgs e)
        {
            Form form = (Form)((Button)sender).Parent.Parent;
            if (!(form.WindowState == FormWindowState.Maximized))
            {
                form.WindowState = FormWindowState.Maximized;
                toggleButton.Text = "";
            }
            else
            {
                form.WindowState = FormWindowState.Normal;
                toggleButton.Text = "";
            }
        }

        public void closeButton_click(object sender, EventArgs e)
        {
            Form form = (Form)((Button)sender).Parent.Parent;
            form.Close();
        }

        protected override void OnLoad(EventArgs e)
        {
            parentForm = FindForm();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }
    }
}
