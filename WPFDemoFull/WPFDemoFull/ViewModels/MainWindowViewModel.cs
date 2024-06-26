﻿using Prism.Mvvm;

namespace WPFDemoFull.ViewModels;

public class MainWindowViewModel : BindableBase
{
    private string _title = "WPFDemoFull Application";

    public string Title
    {
        get { return _title; }
        set { SetProperty(ref _title, value); }
    }

    public MainWindowViewModel()
    {

    }
}
