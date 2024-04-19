using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using WPFDemoFull.Core;
using WPFDemoFull.LangResource.Interface;
using WPFDemoFull.LangResource.Service;
using WPFDemoFull.Modules.ControlLayout.Layout.ViewModels;
using WPFDemoFull.Modules.ControlLayout.Views;
using WPFDemoFull.Modules.ControlLayout.Views.Layout;

namespace WPFDemoFull.Modules.ControlLayout;

public class ControlLayoutModule : IModule
{
    private readonly IRegionManager _regionManager;

    public ControlLayoutModule(IRegionManager regionManager)
    {
        _regionManager = regionManager;
    }

    public void OnInitialized(IContainerProvider containerProvider)
    {
        _regionManager.RequestNavigate(RegionNames.ContentRegion, nameof(GridDemoView));
    }

    public void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterForNavigation<GridDemoView, GridDemoViewModel>();
        containerRegistry.RegisterSingleton<ILanguageService, LanguageService>();
    }
}