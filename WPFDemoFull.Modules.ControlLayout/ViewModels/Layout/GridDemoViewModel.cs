using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;
using WPFDemoFull.Core.Mvvm;
using WPFDemoFull.LangResource.Interface;
using WPFDemoFull.LangResource.Service;

namespace WPFDemoFull.Modules.ControlLayout.Layout.ViewModels;

public class GridDemoViewModel : ViewModelBase
{
    private List<CultureInfo> _cultureInfoList;

    public List<CultureInfo> CultureInfoList
    {
        get { return _cultureInfoList; }
        set {
            SetProperty(ref _cultureInfoList, value);
        }
    }

    private CultureInfo _cultureInfoActive;

    public CultureInfo CultureInfoActive
    {
        get { return _cultureInfoActive; }
        set { 
            LanguageService.ChangeLanguage(value.TextInfo.CultureName);
            SetProperty(ref _cultureInfoActive, value);
        }
    }
    private int _count;

    public int Count
    {
        get { return _count; }
        set { SetProperty(ref _count, value); }
    }

    public GridDemoViewModel(ILanguageService languageService) : base(languageService)
    {
        Count = 123;
        CultureInfoList = LanguageService.GetAllLanguage().ToList();
    }

}
