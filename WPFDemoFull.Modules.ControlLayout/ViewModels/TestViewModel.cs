using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using WPFDemoFull.Core.Models;

namespace WPFDemoFull.Modules.ControlLayout.ViewModels;

public class TestViewModel : BindableBase
{
    public TestViewModel()
    {
        SidePropertyPanelModel = new()
        {
            Command = ResetCommand,
            GroupBoxTitle = "测试标题",
        };
    }

    private SidePropertyPanelModel _sidePropertyPanelModel;

    public SidePropertyPanelModel SidePropertyPanelModel
    {
        get { return _sidePropertyPanelModel; }
        set { SetProperty(ref _sidePropertyPanelModel, value); }
    }

    private DelegateCommand _resetCommand;
    public DelegateCommand ResetCommand =>_resetCommand ??= new DelegateCommand(ExecuteResetCommand);

    void ExecuteResetCommand()
    {

    }
}
