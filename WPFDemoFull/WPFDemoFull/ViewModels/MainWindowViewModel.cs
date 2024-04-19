using Prism.Mvvm;
using System;
using System.Linq;
using System.Windows;
using WPFDemoFull.LangResource.Interface;

namespace WPFDemoFull.ViewModels;

public class MainWindowViewModel : BindableBase
{

    private string _title = "Prism Application";
    private readonly ILanguageService _languageService;

    public string Title
    {
        get { return _title; }
        set { SetProperty(ref _title, value); }
    }

    public MainWindowViewModel(ILanguageService languageService)
    {
        _languageService = languageService;
        _languageService.OnChangeLanguage += _languageService_OnChangeLanguage;
    }

    private void _languageService_OnChangeLanguage(string lang)
    {

    }
}
