namespace LibraryManager
{
    partial class PasswordDialogue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleBar1 = new TitleBar();
            panel1 = new Panel();
            confirmButton = new Button();
            passwordTextBox = new CustomTextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // titleBar1
            // 
            titleBar1.BackColor = Color.FromArgb(230, 233, 239);
            titleBar1.Location = new Point(1, 1);
            titleBar1.Margin = new Padding(0);
            titleBar1.Name = "titleBar1";
            titleBar1.Size = new Size(298, 32);
            titleBar1.TabIndex = 0;
            titleBar1.Title = "Admin Password";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(230, 233, 239);
            panel1.Controls.Add(confirmButton);
            panel1.Controls.Add(passwordTextBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(298, 166);
            panel1.TabIndex = 1;
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.FromArgb(79, 158, 235);
            confirmButton.FlatAppearance.BorderColor = Color.FromArgb(35, 133, 231);
            confirmButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(113, 176, 239);
            confirmButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(99, 168, 238);
            confirmButton.FlatStyle = FlatStyle.Flat;
            confirmButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            confirmButton.ForeColor = Color.White;
            confirmButton.Location = new Point(33, 105);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(225, 36);
            confirmButton.TabIndex = 17;
            confirmButton.Text = "CONFIRM";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.FromArgb(204, 208, 218);
            passwordTextBox.IconText = "";
            passwordTextBox.Location = new Point(33, 63);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '•';
            passwordTextBox.Size = new Size(225, 36);
            passwordTextBox.TabIndex = 16;
            passwordTextBox.TextBoxPlaceholder = "Password";
            passwordTextBox.TextBoxText = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(76, 79, 105);
            label1.Location = new Point(49, 29);
            label1.Name = "label1";
            label1.Size = new Size(190, 15);
            label1.TabIndex = 15;
            label1.Text = "Please enter the admin password";
            // 
            // PasswordDialogue
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(140, 143, 161);
            ClientSize = new Size(300, 200);
            Controls.Add(panel1);
            Controls.Add(titleBar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PasswordDialogue";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PasswordDialogue";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TitleBar titleBar1;
        private Panel panel1;
        private CustomTextBox passwordTextBox;
        private Label label1;
        private Button confirmButton;
    }
}