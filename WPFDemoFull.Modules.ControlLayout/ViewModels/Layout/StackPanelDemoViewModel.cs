using Prism.Commands;
using System.Collections.ObjectModel;
using WPFDemoFull.Core.Models;
using WPFDemoFull.Core.Mvvm;
using WPFDemoFull.LangResource.Interface;

namespace WPFDemoFull.Modules.ControlLayout.ViewModels.Layout;

public class StackPanelDemoViewModel : ViewModelBase
{
    public StackPanelDemoViewModel(ILanguageService languageService) : base(languageService)
    {
        InitPanelChild();
    }


    private bool _selectOrientation;

    /// <summary>
    /// false=> Horizontal :控件或布局应为水平方向（默认值）
    /// <br/>
    /// true => Vertical:控件或布局应为垂直方向
    /// </summary>
    public bool SelectOrientation
    {
        get { return _selectOrientation; }
        set { SetProperty(ref _selectOrientation, value); }
    }


    private ObservableCollection<DockInfo> _dockInfoList;

    public ObservableCollection<DockInfo> DockInfoList
    {
        get { return _dockInfoList; }
        set { SetProperty(ref _dockInfoList, value); }
    }


    private DelegateCommand _resetControlsCommand;
    public DelegateCommand ResetControlsCommand => _resetControlsCommand ??= new DelegateCommand(ExecuteResetControlsCommand);

    void ExecuteResetControlsCommand() => InitPanelChild();


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
