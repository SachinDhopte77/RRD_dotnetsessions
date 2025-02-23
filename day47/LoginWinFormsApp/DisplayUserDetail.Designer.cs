namespace LoginWinFormsApp
{
    partial class DisplayUserDetail
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
            UserInfoDisplay = new Label();
            SuspendLayout();
            // 
            // UserInfoDisplay
            // 
            UserInfoDisplay.AutoSize = true;
            UserInfoDisplay.Location = new Point(330, 120);
            UserInfoDisplay.MinimumSize = new Size(20, 20);
            UserInfoDisplay.Name = "UserInfoDisplay";
            UserInfoDisplay.Padding = new Padding(10);
            UserInfoDisplay.Size = new Size(150, 35);
            UserInfoDisplay.TabIndex = 0;
            UserInfoDisplay.Text = "label_DisplayUserName";
            UserInfoDisplay.Click += UserInfoDisplay_Click;
            // 
            // DisplayUserDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UserInfoDisplay);
            Name = "DisplayUserDetail";
            Load += DisplayUserDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserInfoDisplay;
    }
}