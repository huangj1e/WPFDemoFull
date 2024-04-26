using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Controls;
using WPFDemoFull.Core.Models;
using WPFDemoFull.Core.Mvvm;
using WPFDemoFull.LangResource.Interface;

namespace WPFDemoFull.Modules.ControlLayout.ViewModels.Layout;


public class DockPanelDemoViewModel : ViewModelBase
{

    private bool _lastChildFill;

    public bool LastChildFill
    {
        get { return _lastChildFill; }
        set { SetProperty(ref _lastChildFill, value); }
    }


    private DelegateCommand _resetControlsCommand;
    public DelegateCommand ResetControlsCommand => _resetControlsCommand ??= new DelegateCommand(CreatDockInfoDemoList);


    private ObservableCollection<DockInfo> _dockInfoDemoList;

    public ObservableCollection<DockInfo> DockInfoDemoList
    {
        get { return _dockInfoDemoList; }
        set { SetProperty(ref _dockInfoDemoList, value); }
    }

    public static IEnumerable<Dock> DockOptions { get => Enum.GetValues(typeof(Dock)) as IEnumerable<Dock>; }


    public DockPanelDemoViewModel(ILanguageService languageService) : base(languageService)
    {
        CreatDockInfoDemoList();
    }


    private DockInfo _dockCardItem1;

    public DockInfo DockCardItem1
    {
        get { return _dockCardItem1; }
        set { SetProperty(ref _dockCardItem1, value); }
    }

    private DockInfo _dockCardItem2;

    public DockInfo DockCardItem2
    {
        get { return _dockCardItem2; }
        set { SetProperty(ref _dockCardItem2, value); }
    }

    private DockInfo _dockCardItem3;

    public DockInfo DockCardItem3
    {
        get { return _dockCardItem3; }
        set { SetProperty(ref _dockCardItem3, value); }
    }

    private DockInfo _dockCardItem4;

    public DockInfo DockCardItem4
    {
        get { return _dockCardItem4; }
        set { SetProperty(ref _dockCardItem4, value); }
    }

    private DockInfo _dockCardItem5;

    public DockInfo DockCardItem5
    {
        get { return _dockCardItem5; }
        set { SetProperty(ref _dockCardItem5, value); }
    }

    private DockInfo _dockCardItem6;
    public DockInfo DockCardItem6
    {
        get { return _dockCardItem6; }
        set { SetProperty(ref _dockCardItem6, value); }
    }




    private void CreatDockInfoDemoList()
    {
        DockInfoDemoList = new();
        for (int i = 1; i < 5; i++)
        {
            DockInfoDemoList.Add(new(i, 120, 200));
        }

        DockCardItem1 = new(1, 120, 200);
        DockCardItem2 = new(2, 120, 200);
        DockCardItem3 = new(3, 120, 200);
        DockCardItem4 = new(4, 120, 200);
        DockCardItem5 = new(5, 120, 200);
        DockCardItem6 = new(6, 120, 200);
    }
}
