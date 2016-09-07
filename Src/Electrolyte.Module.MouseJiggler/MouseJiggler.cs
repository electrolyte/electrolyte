using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Electrolyte.Core.Logging;
using Electrolyte.Core.Settings;

namespace Electrolyte.Module.MouseJiggler
{
    public class MouseJiggler : Electrolyte.Core.Module.IModule
    {
        public IManager Manager { get; set; }
        public ILog Log { get; set; }
        public UserControl Options { get; }

        public MouseJiggler()
        {
            Options = new MouseJigglerSettings();
        }

        public void Install()
        {
            throw new NotImplementedException();
        }

        public void Uninstall()
        {
            throw new NotImplementedException();
        }

        public void Run(string command)
        {
            throw new NotImplementedException();
        }
    }
}
