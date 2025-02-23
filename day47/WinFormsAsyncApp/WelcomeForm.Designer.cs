namespace WinFormsAsyncApp
{
    partial class WelcomeForm
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
            btnPrint = new Button();
            btnHello = new Button();
            btnViaThread = new Button();
            btnViaTask = new Button();
            btnViaTaskButAwait = new Button();
            btn_AwaitwithResult = new Button();
            SuspendLayout();
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(271, 64);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(126, 46);
            btnPrint.TabIndex = 0;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnHello
            // 
            btnHello.Location = new Point(271, 12);
            btnHello.Name = "btnHello";
            btnHello.Size = new Size(126, 46);
            btnHello.TabIndex = 1;
            btnHello.Text = "Hello";
            btnHello.UseVisualStyleBackColor = true;
            btnHello.Click += btnHelloClick;
            // 
            // btnViaThread
            // 
            btnViaThread.Location = new Point(271, 116);
            btnViaThread.Name = "btnViaThread";
            btnViaThread.Size = new Size(126, 46);
            btnViaThread.TabIndex = 2;
            btnViaThread.Text = "PrintViaThread";
            btnViaThread.UseVisualStyleBackColor = true;
            btnViaThread.Click += PrintViaThreadClick_Handler;
            // 
            // btnViaTask
            // 
            btnViaTask.Location = new Point(271, 168);
            btnViaTask.Name = "btnViaTask";
            btnViaTask.Size = new Size(126, 46);
            btnViaTask.TabIndex = 3;
            btnViaTask.Text = "PrintViaTask";
            btnViaTask.UseVisualStyleBackColor = true;
            btnViaTask.Click += btnViaTaskClick_Handler;
            // 
            // btnViaTaskButAwait
            // 
            btnViaTaskButAwait.Location = new Point(271, 238);
            btnViaTaskButAwait.Name = "btnViaTaskButAwait";
            btnViaTaskButAwait.Size = new Size(126, 46);
            btnViaTaskButAwait.TabIndex = 4;
            btnViaTaskButAwait.Text = "PrintViaTaskButAwait";
            btnViaTaskButAwait.UseVisualStyleBackColor = true;
            btnViaTaskButAwait.Click += btnViaTaskAwait_handler;
            // 
            // btn_AwaitwithResult
            // 
            btn_AwaitwithResult.Location = new Point(462, 238);
            btn_AwaitwithResult.Name = "btn_AwaitwithResult";
            btn_AwaitwithResult.Size = new Size(126, 46);
            btn_AwaitwithResult.TabIndex = 5;
            btn_AwaitwithResult.Text = "PrintViaTaskButAwaitwithResult";
            btn_AwaitwithResult.UseVisualStyleBackColor = true;
            btn_AwaitwithResult.Click += PrintViaTaskButClickAwaitwithResult_Handler;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_AwaitwithResult);
            Controls.Add(btnViaTaskButAwait);
            Controls.Add(btnViaTask);
            Controls.Add(btnViaThread);
            Controls.Add(btnHello);
            Controls.Add(btnPrint);
            Name = "WelcomeForm";
            Text = "WelcomeForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPrint;
        private Button btnHello;
        private Button btnViaThread;
        private Button btnViaTask;
        private Button btnViaTaskButAwait;
        private Button btn_AwaitwithResult;
    }
}