using Prism.Commands;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Documents;
using WPFDemoFull.Core.Models;
using WPFDemoFull.Core.Mvvm;
using WPFDemoFull.LangResource.Interface;

namespace WPFDemoFull.Modules.ControlLayout.ViewModels.Layout;


public class DockPanelDemoViewModel : ViewModelBase
{
    #region 属性

    private bool _lastChildFill;

    public bool LastChildFill
    {
        get { return _lastChildFill; }
        set { SetProperty(ref _lastChildFill, value); }
    }


    private ObservableCollection<DockInfo> _dockInfoDemoList;


    /// <summary>
    /// 因为要绑定到 ItemsControl 的 ItemsSource，所以要用 ObservableCollection
    /// ObservableCollection 的元素增减会通知 UI 刷新，List 的不会
    /// </summary>
    public ObservableCollection<DockInfo> DockInfoDemoList
    {
        get { return _dockInfoDemoList; }
        set { SetProperty(ref _dockInfoDemoList, value); }
    }

    #endregion

    public DockPanelDemoViewModel(ILanguageService languageService) : base(languageService)
    {
        CreatDockInfoDemoList();
    }

    #region Dock 窗口的 6个子控件

    private List<DockInfo> _dockInfoDemoList2;

    public List<DockInfo> DockInfoDemoList2
    {
        get { return _dockInfoDemoList2; }
        set { SetProperty(ref _dockInfoDemoList2, value); }
    }

    #endregion

    /// <summary>
    /// 初始化 所有的子控件
    /// </summary>
    private void CreatDockInfoDemoList()
    {
        DockInfoDemoList = new();

        for (int i = 1; i < 7; i++)
        {
            DockInfoDemoList.Add(new(i, true, 120, 200));
        }

        //之所以不放在For循环里面，是因为这样会导致每次都会触发UI刷新，数组大小是变化的，而导致绑定报错
        //比如 xaml 中，固定绑定 DockInfoDemoList2[5] 但是在循环中
        DockInfoDemoList2 = new()
        {
            new(1, true),
            new(2, true),
            new(3, true),
            new(4, true),
            new(5, true),
            new(6, true)
        };
    }

    #region 绑定的命令

    private DelegateCommand _resetControlsCommand;
    /// <summary>
    /// 重置控件
    /// </summary>
    public DelegateCommand ResetControlsCommand => _resetControlsCommand ??= new DelegateCommand(CreatDockInfoDemoList);

    private DelegateCommand<string> _changeDockInfoDemo;
    /// <summary>
    /// 添加和删除 DockInfoDemoList 的子集
    /// </summary>
    public DelegateCommand<string> ChangeDockInfoDemo => _changeDockInfoDemo ??= new DelegateCommand<string>(ExecuteChangeDockInfoDemo);

    void ExecuteChangeDockInfoDemo(string parameter)
    {
        switch (parameter)
        {
            case "add":
                DockInfoDemoList.Add(new(DockInfoDemoList.Count + 1, true, 120, 200));
                break;
            case "remove":
                if (DockInfoDemoList.Count > 0)
                    DockInfoDemoList.RemoveAt(DockInfoDemoList.Count - 1);
                break;
            default:
                break;
        }
    }
    #endregion
}
