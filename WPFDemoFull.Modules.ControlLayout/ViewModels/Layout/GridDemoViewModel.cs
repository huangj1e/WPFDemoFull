using Prism.Commands;
using System.Linq;
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

    private DelegateCommand<string> _moveToDefinitionCommand;
    public DelegateCommand<string> MoveToDefinitionCommand => _moveToDefinitionCommand ??= new DelegateCommand<string>(ExecuteMoveToDefinitionCommand);

    void ExecuteMoveToDefinitionCommand(string parameter)
    {
        int[] rowColArray = parameter.Split(',').Select(int.Parse).ToArray();

        GridInfo.Row = rowColArray[0];
        GridInfo.Column = rowColArray[1];
    }
}
