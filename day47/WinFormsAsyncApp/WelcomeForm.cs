using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAsyncApp.Services;

namespace WinFormsAsyncApp
{
    public partial class WelcomeForm : Form
    {
        private PrintService _printService;
        public WelcomeForm()
        {
            _printService = new PrintService();
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            _printService.Print();
        }

        private void btnMyHelloClick_Handler(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Message 1");
        }

        private void btnHelloClick(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Message 2");
        }

        private void PrintViaThreadClick_Handler(object sender, EventArgs e)
        {
            _printService.PrintViaThread();
            MessageBox.Show("Thread Method is completed");
        }

        private void btnViaTaskClick_Handler(object sender, EventArgs e)
        {
            _printService.PrintViaTask();
            MessageBox.Show("Task Method is completed");
        }

        private async void btnViaTaskAwait_handler(object sender, EventArgs e)
        {
            await _printService.PrintViaTaskAwaitable();
            MessageBox.Show("Awaitable task Completed after 10 Sec");
        }

        private async void PrintViaTaskButClickAwaitwithResult_Handler(object sender, EventArgs e)
        {
          string result=await  _printService.PrintViaTaskAwaitableResult();
            MessageBox.Show("Task Completed after 10 sec result is : " + result);
        }
    }
}
