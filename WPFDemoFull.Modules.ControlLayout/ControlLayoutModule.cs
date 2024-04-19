using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using WPFDemoFull.Core;
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
        _regionManager.RequestNavigate(RegionNames.MenuRegion, nameof(GridDemoView));
    }

    public void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterForNavigation<ViewA>();
        containerRegistry.RegisterForNavigation<GridDemoView>();
    }
}