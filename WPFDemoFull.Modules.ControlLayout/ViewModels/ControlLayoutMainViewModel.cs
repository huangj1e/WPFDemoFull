using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using WPFDemoFull.Core.Models;
using WPFDemoFull.Modules.ControlLayout.Views.Layout;

namespace WPFDemoFull.Modules.ControlLayout.ViewModels;

public class ControlLayoutMainViewModel : BindableBase
{
    private readonly IRegionManager _regionManager;

    public ControlLayoutMainViewModel(IRegionManager regionManager)
    {
        _regionManager = regionManager;
        CreatMenuBars();
    }

    private void CreatMenuBars()
    {
        MenuBars = new List<MenuBar>
        {
            new(){
                Name = "Grid",
                Title = "Grid",
                Icon="Grid",
                NavViewName=nameof(GridDemoView)
            },
            new(){
                Name = "Stack\r\nPanel" ,
                Title = "StackPanel",
                Icon="ChartBarStacked" ,
                NavViewName=nameof(StackPanelDemoView)
            },
            new(){
                Name = "Canvas" ,
                Title = "Canvas",
                Icon="Artboard" ,
                NavViewName=nameof(CanvasDemoView)
            },
            new(){
                Name = "Dock\r\nPanel" ,
                Title = "DockPanel",
                Icon="DockTop" ,
                NavViewName=nameof(DockPanelDemoView)
            },
            new(){
                Name = "Expander" ,
                Title = "Expander",
                Icon="ArrowDownBoldCircleOutline" ,
                NavViewName=nameof(ExpanderDemoView)
            },
            new(){
                Name = "Uniform\r\nGrid" ,
                Title = "UniformGrid",
                Icon="ViewGridPlus" ,
                NavViewName=nameof(UniformGridDemoView)
            },
            new(){
                Name = "ViewBox" ,
                Title = "ViewBox",
                Icon="AlphaVBoxOutline" ,
                NavViewName=nameof(ViewBoxDemoView)
            },
            new(){
                Name = "Wrap\r\nPanel" ,
                Title = "WrapnPanel",
                Icon="FormatWrapInline" ,
                NavViewName=nameof(WrapPanelDemoView)
            },
        };
    }

    private MenuBar _selectedMenuBar;

    /// <summary>
    /// 选中的菜单
    /// </summary>
    public MenuBar SelectedMenuBar
    {
        get { return _selectedMenuBar; }
        set
        {
            NavigationParameters pairs = new() {
                { "ViewTitle",value.Title}
            };
            _regionManager.RequestNavigate(Core.RegionNames.ControlLayoutMainRegion, value.NavViewName, pairs);
            SetProperty(ref _selectedMenuBar, value);
        }
    }



    private List<MenuBar> _menuBars;

    /// <summary>
    /// 菜单列表
    /// </summary>
    public List<MenuBar> MenuBars
    {
        get { return _menuBars; }
        set { SetProperty(ref _menuBars, value); }
    }


    private DelegateCommand<string> _navigateCommand;
    public DelegateCommand<string> NavigateCommand =>
        _navigateCommand ??= new DelegateCommand<string>(Navigate);

    private void Navigate(string obj)
    {

    }
}
