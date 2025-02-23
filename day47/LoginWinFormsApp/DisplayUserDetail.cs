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

namespace LoginWinFormsApp
{
    public partial class DisplayUserDetail : Form
    {
        public DisplayUserDetail()
        {
            InitializeComponent();
            UserInfoDisplay.Text =LoginForm.userName;
        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        private void DisplayUserDetail_Load(object sender, EventArgs e)
        {


        }

        private void UserInfoDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
