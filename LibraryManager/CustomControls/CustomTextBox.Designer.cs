namespace LibraryManager
{
    partial class CustomTextBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            iconLabel = new Label();
            textBox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(44, 49, 59);
            panel1.Controls.Add(iconLabel);
            panel1.Controls.Add(textBox);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(298, 34);
            panel1.TabIndex = 1;
            // 
            // iconLabel
            // 
            iconLabel.AutoSize = true;
            iconLabel.Font = new Font("Segoe Fluent Icons", 15F);
            iconLabel.ForeColor = Color.Gray;
            iconLabel.Location = new Point(3, 7);
            iconLabel.Name = "iconLabel";
            iconLabel.Size = new Size(29, 20);
            iconLabel.TabIndex = 2;
            iconLabel.Text = "";
            // 
            // textBox
            // 
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox.BackColor = Color.FromArgb(44, 49, 59);
            textBox.BorderStyle = BorderStyle.None;
            textBox.Font = new Font("Segoe UI", 9F);
            textBox.ForeColor = Color.White;
            textBox.Location = new Point(34, 9);
            textBox.Name = "textBox";
            textBox.PlaceholderText = "PlaceholderText";
            textBox.Size = new Size(256, 16);
            textBox.TabIndex = 1;
            // 
            // CustomTextBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 59, 71);
            Controls.Add(panel1);
            Name = "CustomTextBox";
            Size = new Size(300, 36);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox;
        private Label iconLabel;
    }
}
