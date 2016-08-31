using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void button1_Click(object sender, EventArgs e)
        {
            var s = new Electrolyte.Core.Settings.Manager("settings.yaml");
            System.Diagnostics.Debug.WriteLine("MouseJiggler.Enabled = " + s.Get("MouseJiggler", "Enabled"));
            s.Set("alan", "iscool", "true");
        }
    }
}
