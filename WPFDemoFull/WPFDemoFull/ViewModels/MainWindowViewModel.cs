using Prism.Mvvm;
using System.Linq;
using WPFDemoFull.Lang;

namespace WPFDemoFull.ViewModels;

public class MainWindowViewModel : BindableBase
{
    private ILanguage _language;

    private string _title = "Prism Application";
    public string Title
    {
        get { return _title; }
        set { SetProperty(ref _title, value); }
    }

    public MainWindowViewModel()
    {
        _language = Language.GetLanguages().LastOrDefault();
        _title = _language.AppTitle;
    }
}
