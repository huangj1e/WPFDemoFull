using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using WPFDemoFull.Core.Mvvm;
using WPFDemoFull.LangResource.Interface;

namespace WPFDemoFull.Modules.ControlLayout.ViewModels.Layout;



public class GridInfo : BindableBase
{
    public void ChangeName(string name) => Name = name;

    private string name;

    public string Name
    {
        get { return name; }
        set { SetProperty(ref name, value); }
    }

    private int _col;

    public int Col
    {
        get { return _col; }
        set { SetProperty(ref _col, value); }
    }

    private int _row;

    public int Row
    {
        get { return _row; }
        set { SetProperty(ref _row, value); }
    }
}


public class GridDemoViewModel : ViewModelBase
{
    public GridInfo GridInfo { get; set; } = new GridInfo();

    private int _count;

    public int Count
    {
        get { return _count; }
        set { SetProperty(ref _count, value); }
    }

    public GridDemoViewModel(ILanguageService languageService) : base(languageService)
    {
        Count = 123;
        GridInfo.ChangeName("Name");
    }
}
