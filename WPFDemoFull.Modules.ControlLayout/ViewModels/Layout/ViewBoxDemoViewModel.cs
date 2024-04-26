using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using WPFDemoFull.Core.Mvvm;
using WPFDemoFull.LangResource.Interface;

namespace WPFDemoFull.Modules.ControlLayout.ViewModels.Layout;

public class ViewBoxDemoViewModel : ViewModelBase
{
    public ViewBoxDemoViewModel(ILanguageService languageService) : base(languageService)
    {

    }
}
