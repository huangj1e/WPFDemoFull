using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using WPFDemoFull.Lang;
using WPFDemoFull.Modules.ControlLayout;
using WPFDemoFull.Modules.ModuleName;
using WPFDemoFull.Services;
using WPFDemoFull.Services.Interfaces;
using WPFDemoFull.Views;

namespace WPFDemoFull
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IMessageService, MessageService>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            //moduleCatalog.AddModule<ModuleNameModule>();
            moduleCatalog.AddModule<ControlLayoutModule>();
        }
    }
}
