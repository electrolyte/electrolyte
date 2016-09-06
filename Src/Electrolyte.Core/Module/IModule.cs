namespace Electrolyte.Core.Module
{
    public interface IModule
    {
        Electrolyte.Core.Settings.IManager Manager { get; set; }
        Electrolyte.Core.Logging.ILog Log { get; set; }
        void Install();
        void Uninstall();
    }
}