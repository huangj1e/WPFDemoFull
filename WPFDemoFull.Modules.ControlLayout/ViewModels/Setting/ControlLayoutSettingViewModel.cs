using Prism.Mvvm;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using WPFDemoFull.Core.Mvvm;
using WPFDemoFull.LangResource.Interface;

namespace WPFDemoFull.Modules.ControlLayout.ViewModels.Setting;

public class ControlLayoutSettingViewModel : ViewModelBase
{
    public ControlLayoutSettingViewModel(ILanguageService languageService) : base(languageService)
    {
        CultureInfoList = LanguageService.GetAllLanguage().ToList();
    }

    private List<CultureInfo> _cultureInfoList;

    public List<CultureInfo> CultureInfoList
    {
        get { return _cultureInfoList; }
        set
        {
            SetProperty(ref _cultureInfoList, value);
        }
    }

    private CultureInfo _cultureInfoActive;

    public CultureInfo CultureInfoActive
    {
        get { return _cultureInfoActive; }
        set
        {
            LanguageService.ChangeLanguage(value.TextInfo.CultureName);
            SetProperty(ref _cultureInfoActive, value);
        }
    }
}
