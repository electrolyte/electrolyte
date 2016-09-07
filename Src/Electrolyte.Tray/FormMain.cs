using System;
using System.Windows.Forms;

namespace Electrolyte.Tray
{
    public partial class FormMain : Form
    {
        private bool _appExiting;

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Setup System Tray and close hide main window on startup
            SysTrayIcon.Icon = Icon;
            SysTrayIcon.Visible = true;
            Hide();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Catch closing call from user clicking "X" then minmize and close
            if (!_appExiting)
            {
                e.Cancel = true;
                WindowState = FormWindowState.Minimized;
                Hide();
            }
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            // Hide form on minmize
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        #region " SysTrayIconMenu "

        private void SysTrayIconMenu_About_Click(object sender, EventArgs e)
        {
            // Show the about form
            Form aboutForm = FormAbout.GetInstance();
            aboutForm.Show();
        }

        private void SysTrayIconMenu_Exit_Click(object sender, EventArgs e)
        {
            // Tell the application to close
            _appExiting = true;
            System.Windows.Forms.Application.Exit();
        }

        private void SysTrayIconMenu_OnlineHelp_Click(object sender, EventArgs e)
        {
            // Open homepage on help selection
            System.Diagnostics.Process.Start("http://electrolyte.io");
        }

        private void SysTrayIconMenu_Open_Click(object sender, EventArgs e)
        {
            // Show the form and make sure it's set back to normal
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void SysTrayIconMenu_Options_Click(object sender, EventArgs e)
        {
            // Sow the options form
            Form optionsForm = FormOptions.GetInstance();
            optionsForm.Show();
        }

        #endregion

        #region " menuStrip "

        private void MenuStrip_OnlineHelp_Click(object sender, EventArgs e)
        {
            // Open homepage on help selection
            System.Diagnostics.Process.Start("http://electrolyte.io");
        }

        private void MenuStrip_HelpAbout_Click(object sender, EventArgs e)
        {
            // Show the about form
            Form aboutForm = FormAbout.GetInstance();
            aboutForm.Show();
        }

        private void MenuStrip_Options_Click(object sender, EventArgs e)
        {
            // Show the options form
            Form optionsForm = FormOptions.GetInstance();
            optionsForm.Show();
        }
        #endregion
    }
}
