using Prism.Regions;
using System;
using WPFDemoFull.LangResource.Interface;
using WPFDemoFull.LangResource.Service;

namespace WPFDemoFull.Core.Mvvm
{
    public class RegionViewModelBase : ViewModelBase, INavigationAware, IConfirmNavigationRequest
    {
        protected IRegionManager RegionManager { get; private set; }
        public RegionViewModelBase(ILanguageService languageService, IRegionManager regionManager) : base(languageService)
        {
            RegionManager = regionManager;
        }


        public virtual void ConfirmNavigationRequest(NavigationContext navigationContext, Action<bool> continuationCallback)
        {
            continuationCallback(true);
        }

        public virtual bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public virtual void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }

        public virtual void OnNavigatedTo(NavigationContext navigationContext)
        {

        }
    }
}
