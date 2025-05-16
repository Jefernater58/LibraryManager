using System.ComponentModel;

namespace LibraryManager
{
    [DefaultEvent(nameof(Click))]
    public partial class CustomTextBox : UserControl
    {
        // make sure the text can be accessed by the parent class
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string TextBoxText
        {
            get => textBox.Text;
            set => textBox.Text = value;
        }
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string IconText
        {
            get => iconLabel.Text;
            set => iconLabel.Text = value;
        }

        // this property must be able to be set in the designer
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string TextBoxPlaceholder
        {
            get => textBox.PlaceholderText;
            set => textBox.PlaceholderText = value;
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public char PasswordChar
        {
            get => textBox.PasswordChar;
            set => textBox.PasswordChar = value;
        }

        // this event needs to be accessed by the parent class
        [Browsable(true)]
        public new event EventHandler? TextChanged
        {
            add => textBox.TextChanged += value;
            remove => textBox.TextChanged -= value;
        }

        public CustomTextBox()
        {
            InitializeComponent();
        }
    }
}
