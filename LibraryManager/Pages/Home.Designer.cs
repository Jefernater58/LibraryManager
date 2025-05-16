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
            SuspendLayout();
            // 
            // sideBar1
            // 
            sideBar1.BackColor = Color.FromArgb(38, 44, 54);
            sideBar1.CurrentFormIndex = 0;
            sideBar1.Location = new Point(0, 0);
            sideBar1.Name = "sideBar1";
            sideBar1.Size = new Size(198, 398);
            sideBar1.TabIndex = 0;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 49, 59);
            Controls.Add(sideBar1);
            Margin = new Padding(0);
            Name = "Home";
            Size = new Size(798, 398);
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.SideBar sideBar1;
    }
}
