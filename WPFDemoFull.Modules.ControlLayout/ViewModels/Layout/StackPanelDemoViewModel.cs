using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Documents;
using WPFDemoFull.Core.Models;
using WPFDemoFull.Core.Mvvm;
using WPFDemoFull.LangResource.Interface;

namespace WPFDemoFull.Modules.ControlLayout.ViewModels.Layout;

public class StackPanelDemoViewModel : ViewModelBase
{
    public StackPanelDemoViewModel(ILanguageService languageService) : base(languageService)
    {
        InitPanelChild();
    }


    private bool _selectOrientation;

    /// <summary>
    /// false=> Horizontal :控件或布局应为水平方向（默认值）
    /// <br/>
    /// true => Vertical:控件或布局应为垂直方向
    /// </summary>
    public bool SelectOrientation
    {
        get { return _selectOrientation; }
        set { SetProperty(ref _selectOrientation, value); }
    }


    private ObservableCollection<DockInfo> _dockInfoList;

    public ObservableCollection<DockInfo> DockInfoList
    {
        get { return _dockInfoList; }
        set { SetProperty(ref _dockInfoList, value); }
    }


    private void InitPanelChild()
    {
        DockInfoList = new();
        for (int i = 0; i < 6; i++)
        {
            DockInfoList.Add(new(i));
        }
    }
}
