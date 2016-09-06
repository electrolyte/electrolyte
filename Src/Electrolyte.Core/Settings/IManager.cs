namespace Electrolyte.Core.Settings
{
    public interface IManager
    {
        string Get(string module, string key);
        void Set(string module, string key, string value);
    }
}