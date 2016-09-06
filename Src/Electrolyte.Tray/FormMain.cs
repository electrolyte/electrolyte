using System;
using System.Windows.Forms;

namespace Electrolyte.Tray
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Setup System Tray
            SysTrayIcon.Icon = this.Icon;
            SysTrayIcon.Visible = true;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Make sure to close out everything
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Exit
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutForm = new FormAbout();
            aboutForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Tell the application to close
            System.Windows.Forms.Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://electrolyte.io");
        }
    }
}
