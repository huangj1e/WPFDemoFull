using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using WPFDemoFull.Core.Mvvm;
using WPFDemoFull.LangResource.Interface;

namespace WPFDemoFull.Modules.ControlLayout.ViewModels.Layout;

public class StackPanelDemoViewModel : ViewModelBase
{
    public StackPanelDemoViewModel(ILanguageService languageService) : base(languageService)
    {

    }
}
