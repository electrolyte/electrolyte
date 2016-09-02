namespace Electrolyte.Core.Module
{
    public interface IModule
    {
        Electrolyte.Core.Settings.IManager Manager { get; set; }
        log4net.ILog Logger { get; set; }
        void Install();
        void Uninstall();
    }
}