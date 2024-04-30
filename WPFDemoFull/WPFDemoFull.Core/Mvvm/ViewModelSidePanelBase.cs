using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFDemoFull.Core.Models;
using WPFDemoFull.LangResource.Interface;

namespace WPFDemoFull.Core.Mvvm;

public class ViewModelSidePanelBase : ViewModelBase
{
    private SidePropertyPanelModel _sidePropertyPanelModel;

    public ViewModelSidePanelBase(ILanguageService languageService) : base(languageService)
    {
    }

    public SidePropertyPanelModel SidePropertyPanelModel
    {
        get { return _sidePropertyPanelModel; }
        set { SetProperty(ref _sidePropertyPanelModel, value); }
    }
    private DelegateCommand _resetCommand;
    public DelegateCommand ResetCommand => _resetCommand ??= new(ExecuteResetCommand);

    public virtual void ExecuteResetCommand()
    {

    }
}
