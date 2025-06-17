namespace LibraryManager.Pages
{
    partial class Home
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
            sideBar1 = new LibraryManager.CustomControls.SideBar();
            label1 = new Label();
            SuspendLayout();
            // 
            // sideBar1
            // 
            sideBar1.BackColor = Color.FromArgb(220, 224, 232);
            sideBar1.CurrentFormIndex = 0;
            sideBar1.Location = new Point(0, 0);
            sideBar1.Name = "sideBar1";
            sideBar1.Size = new Size(198, 398);
            sideBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(76, 79, 105);
            label1.Location = new Point(405, 183);
            label1.Name = "label1";
            label1.Size = new Size(213, 15);
            label1.TabIndex = 15;
            label1.Text = "Some interesting data will show here";
            // 
            // Home
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(239, 241, 245);
            Controls.Add(label1);
            Controls.Add(sideBar1);
            Margin = new Padding(0);
            Name = "Home";
            Size = new Size(798, 398);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.SideBar sideBar1;
        private Label label1;
    }
}
