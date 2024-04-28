using WPFDemoFull.Core.Models;
using WPFDemoFull.Core.Mvvm;
using WPFDemoFull.LangResource.Interface;

namespace WPFDemoFull.Modules.ControlLayout.ViewModels.Layout;

public class StackPanelDemoViewModel : ViewModelBase
{
    public StackPanelDemoViewModel(ILanguageService languageService) : base(languageService)
    {
		Index = 8;
    }

	private int _index;

	public int Index
	{
		get { return _index; }
		set { SetProperty(ref _index, value); }
	}

}
