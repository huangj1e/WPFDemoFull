using Prism.Commands;
using System.Collections.ObjectModel;
using WPFDemoFull.Core.Models;
using WPFDemoFull.Core.Mvvm;
using WPFDemoFull.LangResource.Interface;

namespace WPFDemoFull.Modules.ControlLayout.ViewModels.Layout;

public class StackPanelDemoViewModel : ViewModelSidePanelBase
{
    public StackPanelDemoViewModel(ILanguageService languageService) : base(languageService)
    {
        InitSiderpanel();
        InitPanelChild();
    }

    private void InitSiderpanel()
    {
        string groupBoxTitle = ViewTitle;
        string sourceCodeUrl = "https://github.com/dotnet/wpf/blob/33343cb58a1b3967c2ffe3e43f3b1fd4b03f41dd/src/Microsoft.DotNet.Wpf/src/PresentationFramework/System/Windows/Controls/Stack.cs#L56";
        string controlDefinedUrl = "https://learn.microsoft.com/en-us/uwp/api/windows.ui.xaml.controls.stackpanel?view=winrt-22621";
        string demoViewUrl = "https://github.com/huangj1e/WPFDemoFull/blob/master/WPFDemoFull.Modules.ControlLayout/Views/Layout/StackPanelDemoView.xaml";
        string demoViewModelUrl = "https://github.com/huangj1e/WPFDemoFull/blob/master/WPFDemoFull.Modules.ControlLayout/ViewModels/Layout/StackPanelDemoViewModel.cs";


        SidePropertyPanelModel = new(
            groupBoxTitle,
            sourceCodeUrl,
            controlDefinedUrl,
            demoViewUrl,
            demoViewModelUrl,
            new DelegateCommand(InitPanelChild)
            );
    }

    private ObservableCollection<DockInfo> _dockInfoList;

    public ObservableCollection<DockInfo> DockInfoList
    {
        get { return _dockInfoList; }
        set { SetProperty(ref _dockInfoList, value); }
    }

    public override void ExecuteResetCommand() => InitPanelChild();

    private void InitPanelChild()
    {
        int index = 0;
        DockInfoList = new()
        {
             new(index++),
             new(index++),
             new(index++),
             new(index++),
             new(index++),
             new(index++),
        };
    }
}
