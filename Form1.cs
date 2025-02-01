using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkCatcher
{
    public partial class MainForm : Form
    {

        string[] args = Environment.GetCommandLineArgs();

        public MainForm()
        {
            InitializeComponent();
        }

            

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenURLButton_Click(object sender, EventArgs e)
        {
            string URL = URLTextbox.Text;
            Process.Start("chrome.exe", URL);
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (args.Length > 1)
            {
                URLTextbox.Text = args[1];
                
                if (args.Length > 2)
                {
                    URLTextbox.Text += ("\r\n\r\nAddition arguments were provided: \r\n");

                    foreach (var arg in args)
                        URLTextbox.Text += arg.ToString() + "\r\n";
                }

            }
            else
            {
                URLTextbox.Text = args[0];
            }
        }

        private void URLTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
