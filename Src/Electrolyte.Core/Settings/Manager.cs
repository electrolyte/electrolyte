using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;

namespace Electrolyte.Core.Settings
{
    /// <summary>
    /// 
    /// </summary>
    public class Manager : IManager
    {
        private readonly string _settingsFile;

        public Dictionary<string, Dictionary<string, string>> Items { get; set; }

        public Manager(string settingsFile)
        {
            _settingsFile = settingsFile;
            Items = new Dictionary<string, Dictionary<string, string>>();
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
            var deserializer = new YamlDotNet.Serialization.Deserializer();
            using (var streamReader = new StreamReader(_settingsFile))
            {
                Items = deserializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(streamReader);
            }
        }

        private void Save()
        {
            var serializer = new YamlDotNet.Serialization.Serializer();
            using (var streamWriter = new StreamWriter(_settingsFile))
            {
                serializer.Serialize(streamWriter, Items);
            }
        }
    }
}