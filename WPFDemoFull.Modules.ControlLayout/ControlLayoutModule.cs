using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using WPFDemoFull.Core;
using WPFDemoFull.Modules.ControlLayout.ViewModels.Layout;
using WPFDemoFull.Modules.ControlLayout.ViewModels;
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
        //导航区域
        _regionManager.RequestNavigate(RegionNames.ContentRegion, nameof(ControlLayoutMainView));
    }

    public void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterForNavigation<ControlLayoutMainView, ControlLayoutMainViewModel>();

        containerRegistry.RegisterForNavigation<GridDemoView, GridDemoViewModel>();
        containerRegistry.RegisterForNavigation<CanvasDemoView, CanvasDemoViewModel>();
        containerRegistry.RegisterForNavigation<StackPanelDemoView, StackPanelDemoViewModel>();
        containerRegistry.RegisterForNavigation<DockPanelDemoView, DockPanelDemoViewModel>();
        containerRegistry.RegisterForNavigation<ExpanderDemoView, ExpanderDemoViewModel>();
        containerRegistry.RegisterForNavigation<StackPanelDemoView, StackPanelDemoViewModel>();
        containerRegistry.RegisterForNavigation<UniformGridDemoView, UniformGridDemoViewModel>();
        containerRegistry.RegisterForNavigation<ViewBoxDemoView, ViewBoxDemoViewModel>();
        containerRegistry.RegisterForNavigation<WrapPanelDemoView, WrapPanelDemoViewModel>();
    }
}