using System;
using System.Collections.Generic;
using Electrolyte.Core.Logging;

namespace Electrolyte.Core.Settings
{
    /// <summary>
    /// 
    /// </summary>
    public class Manager : IManager
    {
        private readonly string _settingsFile;
        private readonly Electrolyte.Core.Logging.ILog _log;
        private Dictionary<string, Dictionary<string, string>> Items { get; set; }
        public ILog Log { get; set; }

        /// <summary>
        /// Constructor for the settings manager
        /// </summary>
        /// <param name="log">Electrolyte.Core.Logging.ILog</param>
        /// <param name="settingsFile">string</param>
        public Manager(Electrolyte.Core.Logging.ILog log, string settingsFile)
        {
            _log = log;
            _settingsFile = settingsFile;
            Items = new Dictionary<string, Dictionary<string, string>>();
            Load();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="module"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Set(string module, string key, string value)
        {
            if (String.IsNullOrEmpty(module))
            {
                throw new ArgumentException("Specified module not valid", module);
            }
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentException("Specified key not valid", key);
            }

            if (!Items.ContainsKey(module))
            {
                Items.Add(module, new Dictionary<string, string>());
            }
            Items[module][key] = value;
            Save();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="module"></param>
        /// <param name="key"></param>
        public string Get(string module, string key)
        {
            Load();
            if (Items.ContainsKey(module))
            {
                if (Items[module].ContainsKey(key))
                {
                    return Items[module][key];
                }
                return null;
            }
            return null;
        }

        private void Load()
        {
            if (_log.IsDebugEnabled)
            {
                _log.Debug("Load() - Loading settings file '{0}'.", _settingsFile);
            }
            var deserializer = new YamlDotNet.Serialization.Deserializer();
            // check for file before we bother loading
            if (System.IO.File.Exists(_settingsFile))
            {
                using (var streamReader = new System.IO.StreamReader(_settingsFile))
                {
                    Items = deserializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(streamReader);
                }
            }

    }

        private void Save()
        {
            if (_log.IsDebugEnabled)
            {
                _log.Debug("Save() - Saving settings file '{0}'.", _settingsFile);
            }
            var serializer = new YamlDotNet.Serialization.Serializer();

            using (var streamWriter = new System.IO.StreamWriter(_settingsFile))
            {
                serializer.Serialize(streamWriter, Items);
            }
        }
    }
}