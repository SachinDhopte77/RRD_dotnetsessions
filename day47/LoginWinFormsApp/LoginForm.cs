using LoginWinFormsApp.AuthenticationService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace LoginWinFormsApp
{
    public partial class LoginForm : Form
    {
        public static string userName = "admin";
        public static string password = "admin";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            userName = textUser.Text;
            password = textPassword.Text;

            if (userName == "admin" && password == "admin")
               {

                DisplayUserDetail displayUserDetail = new DisplayUserDetail();
                this.Hide();
                displayUserDetail.Show();
               }
            else { MessageBox.Show("Login Unsuccessful"); }



        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
