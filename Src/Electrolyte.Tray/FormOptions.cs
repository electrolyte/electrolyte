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
    public partial class FormOptions : Form
    {
        private static FormOptions _formSingleton = null;
        public static FormOptions GetInstance()
        {
            if (_formSingleton == null)
            {
                _formSingleton = new FormOptions();
                _formSingleton.FormClosed += delegate { _formSingleton = null; };
            }
            return _formSingleton;
        }

        public FormOptions()
        {
            InitializeComponent();
            // Load all options

            // Expand the tree and remove the root node lines
            TreeView_Options.ExpandAll();
            TreeView_Options.ShowRootLines = false;
        }

        private void TreeView_Options_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var optionControl = (Control)Activator.CreateInstance(Type.GetType("Electrolyte.Tray.Options.General"));
            optionPanel.Controls.Add(optionControl);
        }
    }
}
