namespace Electrolyte.Core.Module
{
    public interface IModule
    {
        Electrolyte.Core.Settings.IManager Manager { get; set; }
        Electrolyte.Core.Logging.ILog Log { get; set; }
        System.Windows.Forms.UserControl Options { get; }
        void Install();
        void Uninstall();
        void Run(string command);
    }

}