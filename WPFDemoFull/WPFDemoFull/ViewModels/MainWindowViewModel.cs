using Prism.Mvvm;
using System;
using System.Linq;
using System.Windows;
using WPFDemoFull.LangResource.Interface;

namespace WPFDemoFull.ViewModels;

public class MainWindowViewModel : BindableBase
{
    private string _title = "Prism Application";

    public string Title
    {
        get { return _title; }
        set { SetProperty(ref _title, value); }
    }

    public MainWindowViewModel()
    {

    }
}
