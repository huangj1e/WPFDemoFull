using Prism.Commands;
using System.Collections.ObjectModel;
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

    private ObservableCollection<DockInfo> _dockInfoDemo2List;

    public ObservableCollection<DockInfo> DockInfoDemo2List
    {
        get { return _dockInfoDemo2List; }
        set { SetProperty(ref _dockInfoDemo2List, value); }
    }

    #endregion

    /// <summary>
    /// 初始化 所有的子控件
    /// </summary>
    private void CreatDockInfoDemoList()
    {
        DockInfoDemoList = new();
        DockInfoDemo2List = new();
        for (int i = 1; i < 7; i++)
        {
            DockInfoDemoList.Add(new(i, 120, 200));
            DockInfoDemo2List.Add(new(i));
        }
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
                DockInfoDemoList.Add(new(DockInfoDemoList.Count + 1, 120, 200));
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
