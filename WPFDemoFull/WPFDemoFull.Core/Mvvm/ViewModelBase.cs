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

    protected ViewModelBase(ILanguageService languageService)
    {
        LanguageService = languageService;
    }

    public virtual void Destroy()
    {

    }
}
