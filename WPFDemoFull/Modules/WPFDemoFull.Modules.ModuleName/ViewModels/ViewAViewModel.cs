using Prism.Regions;
using WPFDemoFull.Core.Mvvm;
using WPFDemoFull.LangResource.Interface;
using WPFDemoFull.Services.Interfaces;

namespace WPFDemoFull.Modules.ModuleName.ViewModels
{
    public class ViewAViewModel : RegionViewModelBase
    {
        private string _message;


        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ViewAViewModel(
            IRegionManager regionManager,
            ILanguageService languageService,
            IMessageService messageService) :
            base(languageService, regionManager)
        {
            Message = messageService.GetMessage();
        }


        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            //do something
        }
    }
}
