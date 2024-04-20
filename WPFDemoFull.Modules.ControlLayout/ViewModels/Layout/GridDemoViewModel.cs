using Prism.Commands;
using WPFDemoFull.Core.Models;
using WPFDemoFull.Core.Mvvm;
using WPFDemoFull.LangResource.Interface;

namespace WPFDemoFull.Modules.ControlLayout.ViewModels.Layout;

public class GridDemoViewModel : ViewModelBase
{
    public GridInfo GridInfo { get; set; } = new GridInfo();

    public GridDemoViewModel(ILanguageService languageService) : base(languageService)
    {
        GridInfo.ChangeName(LanguageService.GetValue("GridDefName"));
    }
}
