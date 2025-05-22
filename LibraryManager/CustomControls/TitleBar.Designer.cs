namespace LibraryManager
{
    partial class TitleBar
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
            minimiseButton = new Button();
            toggleButton = new Button();
            closeButton = new Button();
            title = new Label();
            SuspendLayout();
            // 
            // minimiseButton
            // 
            minimiseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimiseButton.FlatAppearance.BorderSize = 0;
            minimiseButton.FlatStyle = FlatStyle.Flat;
            minimiseButton.Font = new Font("Segoe Fluent Icons", 7F);
            minimiseButton.ForeColor = Color.FromArgb(76, 79, 105);
            minimiseButton.Location = new Point(708, 0);
            minimiseButton.Margin = new Padding(0);
            minimiseButton.Name = "minimiseButton";
            minimiseButton.Size = new Size(46, 32);
            minimiseButton.TabIndex = 98;
            minimiseButton.Text = "";
            minimiseButton.UseVisualStyleBackColor = true;
            minimiseButton.Click += minimiseButton_click;
            // 
            // toggleButton
            // 
            toggleButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toggleButton.FlatAppearance.BorderSize = 0;
            toggleButton.FlatStyle = FlatStyle.Flat;
            toggleButton.Font = new Font("Segoe Fluent Icons", 7F);
            toggleButton.ForeColor = Color.FromArgb(174, 179, 188);
            toggleButton.Location = new Point(708, 0);
            toggleButton.Margin = new Padding(0);
            toggleButton.Name = "toggleButton";
            toggleButton.Size = new Size(46, 32);
            toggleButton.TabIndex = 11;
            toggleButton.Text = "";
            toggleButton.UseVisualStyleBackColor = true;
            toggleButton.Visible = false;
            toggleButton.Click += toggleButton_click;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(147, 42, 49);
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Segoe Fluent Icons", 7F);
            closeButton.ForeColor = Color.FromArgb(76, 79, 105);
            closeButton.Location = new Point(754, 0);
            closeButton.Margin = new Padding(0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(46, 32);
            closeButton.TabIndex = 99;
            closeButton.Text = "";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.ForeColor = Color.FromArgb(76, 79, 105);
            title.Location = new Point(6, 9);
            title.Name = "title";
            title.Size = new Size(93, 15);
            title.TabIndex = 9;
            title.Text = "Library Manager";
            title.Click += title_Click;
            // 
            // TitleBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 224, 232);
            Controls.Add(minimiseButton);
            Controls.Add(toggleButton);
            Controls.Add(closeButton);
            Controls.Add(title);
            Margin = new Padding(0);
            Name = "TitleBar";
            Size = new Size(800, 32);
            MouseMove += titleBar_mouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button minimiseButton;
        private Button toggleButton;
        private Button closeButton;
        private Label title;
    }
}
