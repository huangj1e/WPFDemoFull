using Prism.Mvvm;
using Prism.Navigation;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using WPFDemoFull.LangResource.Interface;

namespace WPFDemoFull.Core.Mvvm;

public abstract class ViewModelBase : BindableBase, IDestructible
{
    public ILanguageService LanguageService;

    private  List<ResourceDictionary> _languageList;

    public List<ResourceDictionary> LanguageList
    {
        get { return LanguageService.DictionaryList; }
        set { SetProperty(ref _languageList, value); }
    }


    private ResourceDictionary _activeLanguage;

    public ResourceDictionary ActiveLanguage
    {
        get { return LanguageService.ResourceDictionary; }
        set {
            LanguageService.SwitchDictionary(value);
            SetProperty(ref _activeLanguage, value);
        }
    }


    protected ViewModelBase(ILanguageService languageService)
    {
        LanguageService = languageService;
    }

    public virtual void Destroy()
    {

    }
}
