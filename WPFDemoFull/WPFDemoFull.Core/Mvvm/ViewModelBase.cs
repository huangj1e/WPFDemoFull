using Prism.Mvvm;
using Prism.Navigation;
using Prism.Regions;
using WPFDemoFull.LangResource.Interface;

namespace WPFDemoFull.Core.Mvvm;

public abstract class ViewModelBase :
    BindableBase,
    IDestructible,
    INavigationAware
{
    public ILanguageService LanguageService;
    private string _viewTitle;

    public string ViewTitle
    {
        get { return _viewTitle; }
        set { SetProperty(ref _viewTitle, value); }
    }

    protected ViewModelBase(ILanguageService languageService)
    {
        LanguageService = languageService;
    }

    public virtual void Destroy()
    {

    }

    /// <summary>
    /// 进入
    /// </summary>
    /// <param name="navigationContext"></param>
    public void OnNavigatedTo(NavigationContext navigationContext)
    {
        ViewTitle = navigationContext.Parameters.GetValue<string>("ViewTitle");
    }

    public bool IsNavigationTarget(NavigationContext navigationContext) => true;

    /// <summary>
    /// 出去
    /// </summary>
    /// <param name="navigationContext"></param>
    public void OnNavigatedFrom(NavigationContext navigationContext)
    {
    }
}
