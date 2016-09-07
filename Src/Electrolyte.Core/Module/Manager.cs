using System;
using System.Collections.Generic;
using System.Reflection;

namespace Electrolyte.Core.Module
{
    /// <summary>
    /// https://code.msdn.microsoft.com/windowsdesktop/Creating-a-simple-plugin-b6174b62
    /// </summary>
    public class Manager
    {
        public ICollection<IModule> LoadedModules { get; } = new List<IModule>();

        public Electrolyte.Core.Logging.ILog Log { get; set; }
        public Electrolyte.Core.Settings.IManager SettingsManager { get; set; }

        public void LoadFromDirectory()
        {
            var modulePath = SettingsManager.Get("Modules", "Path");

            if (!string.IsNullOrEmpty(modulePath))
            {
                if (System.IO.Directory.Exists(modulePath))
                {
                    foreach (var file in System.IO.Directory.GetFiles(modulePath))
                    {
                        var extension = System.IO.Path.GetExtension(file);
                        if (extension != null && extension.ToUpper() == "DLL")
                        {
                            Assembly assembly = Assembly.LoadFile(file);
                            if (assembly.GetType().ToString() == "")
                            {
                                var instance = Activator.CreateInstance(typeof(string));
                            }
                        }
                    }
                }
            }
        }
    }
}
