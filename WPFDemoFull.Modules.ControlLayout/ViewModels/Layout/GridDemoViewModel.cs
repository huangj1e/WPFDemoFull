using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using WPFDemoFull.Core.Mvvm;
using WPFDemoFull.LangResource.Interface;
using WPFDemoFull.LangResource.Service;

namespace WPFDemoFull.Modules.ControlLayout.Layout.ViewModels;

public class GridDemoViewModel : ViewModelBase
{
    public GridDemoViewModel(ILanguageService languageService) : base(languageService)
    {
        Count = 123;
    }

    private int _count;

    public int Count
    {
        get { return _count; }
        set { SetProperty(ref _count, value); }
    }
}
