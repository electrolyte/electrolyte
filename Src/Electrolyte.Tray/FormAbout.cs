using System;
using System.Reflection;
using System.Windows.Forms;

namespace Electrolyte.Tray
{
    partial class FormAbout : Form
    {
        private static FormAbout _formSingleton = null;
        public static FormAbout GetInstance()
        {
            if (_formSingleton == null)
            {
                _formSingleton = new FormAbout();
                _formSingleton.FormClosed += delegate { _formSingleton = null; };
            }
            return _formSingleton;
        }

        public FormAbout()
        {
            InitializeComponent();
            Text = String.Format("About {0}", AssemblyProduct);
            labelProductName.Text = AssemblyProduct;
            labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            labelCopyright.Text = AssemblyCopyright;
            textBoxDescription.Text = AssemblyDescription;
            labelTrademark.Text = AssemblyTrademark;
            labelTrademark.Links.Add(new LinkLabel.Link(0, AssemblyTrademark.Length, AssemblyTrademark));
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }

        public string AssemblyTrademark
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTrademarkAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyTrademarkAttribute)attributes[0]).Trademark;
            }
        }
        #endregion

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void labelTrademark_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Link != null) System.Diagnostics.Process.Start((string) e.Link.LinkData);
        }

    }
}
