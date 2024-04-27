using WPFDemoFull.Core.Models;
using WPFDemoFull.Core.Mvvm;
using WPFDemoFull.LangResource.Interface;

namespace WPFDemoFull.Modules.ControlLayout.ViewModels.Layout;

public class StackPanelDemoViewModel : ViewModelBase
{
    public StackPanelDemoViewModel(ILanguageService languageService) : base(languageService)
    {
        DockInfo = new(1);
    }

    private DockInfo _dockInfo;

    public DockInfo DockInfo
    {
        get { return _dockInfo; }
        set { SetProperty(ref _dockInfo, value); }
    }
}
