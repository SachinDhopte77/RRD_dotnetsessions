namespace LoginWinFormsApp
{
    partial class LoginForm
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
            label1_UserName = new Label();
            label1_Password = new Label();
            btnSubmit = new Button();
            textUser = new TextBox();
            textPassword = new TextBox();
            SuspendLayout();
            // 
            // label1_UserName
            // 
            label1_UserName.AutoSize = true;
            label1_UserName.Location = new Point(173, 90);
            label1_UserName.Name = "label1_UserName";
            label1_UserName.Padding = new Padding(5);
            label1_UserName.Size = new Size(75, 25);
            label1_UserName.TabIndex = 0;
            label1_UserName.Text = "User Name";
            // 
            // label1_Password
            // 
            label1_Password.AutoSize = true;
            label1_Password.Location = new Point(181, 134);
            label1_Password.Name = "label1_Password";
            label1_Password.Padding = new Padding(5);
            label1_Password.Size = new Size(67, 25);
            label1_Password.TabIndex = 1;
            label1_Password.Text = "Password";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(327, 184);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // textUser
            // 
            textUser.Location = new Point(279, 91);
            textUser.Name = "textUser";
            textUser.Size = new Size(195, 23);
            textUser.TabIndex = 3;
            textUser.Text = "User Name";
            textUser.TextChanged += textUser_TextChanged;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(279, 136);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(195, 23);
            textPassword.TabIndex = 4;
            textPassword.Text = "Password";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textPassword);
            Controls.Add(textUser);
            Controls.Add(btnSubmit);
            Controls.Add(label1_Password);
            Controls.Add(label1_UserName);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1_UserName;
        private Label label1_Password;
        private Button btnSubmit;
        private TextBox textUser;
        private TextBox textPassword;
    }
}