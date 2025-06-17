using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class PasswordDialogue : Form
    {
        public PasswordDialogue()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            // TODO: store the password in database as a hash
            string adminPassword = "admin";

            if (passwordTextBox.TextBoxText == adminPassword)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Incorrect password");
            }
        }
    }
}
