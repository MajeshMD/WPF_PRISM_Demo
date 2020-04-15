using Prism.Modularity;
using Prism.Unity;
using System.Windows;

namespace WPF_Project
{
    [System.Obsolete]
    class Bootstrapper: UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return new Shell();
        }
        protected override void InitializeShell()
        {
            base.InitializeShell();

            App.Current.MainWindow = (Window)this.Shell;
            App.Current.MainWindow.Show();
        }
        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
            ModuleCatalog moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
            //moduleCatalog.AddModule(typeof(EmployeeModule.EmployeeModule));
        }
    }
}
