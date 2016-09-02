using System.Collections.Generic;

namespace Electrolyte.Core.Settings
{
    public interface IManager
    {
        Dictionary<string, Dictionary<string, string>> Items { get; set; }

        string Get(string module, string key);
        void Set(string module, string key, string value);
    }
}