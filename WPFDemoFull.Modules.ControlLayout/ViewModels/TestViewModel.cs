using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WPFDemoFull.Modules.ControlLayout.ViewModels;

public class TestViewModel : BindableBase
{
    public TestViewModel()
    {

    }

    private DelegateCommand _resetCommand;
    public DelegateCommand ResetCommand =>_resetCommand ??= new DelegateCommand(ExecuteResetCommand);

    void ExecuteResetCommand()
    {

    }
}
