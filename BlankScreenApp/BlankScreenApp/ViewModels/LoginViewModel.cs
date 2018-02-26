using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace BlankScreenApp.ViewModels
{
    public class LoginViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _NavigationService;
        public ICommand NavigateToMainPage { get; }
        public ICommand NavigateToQuickGuidePage { get; }


        public LoginViewModel(IMvxNavigationService navigationService)
        {
            _NavigationService = navigationService;
            NavigateToMainPage = new MvxCommand(NavigateToMainPageCommandHandler);
            NavigateToQuickGuidePage = new MvxCommand(NavigateToQuickGuideCommandHandler);
        }

        private async void NavigateToMainPageCommandHandler()
        {
            await _NavigationService.Navigate<MainDetailsViewModel>();
            await _NavigationService.Navigate<MainMasterViewModel>();
        }

        private async void NavigateToQuickGuideCommandHandler()
        {
            await _NavigationService.Navigate<QuickGuideViewModel>();
        }
    }
}
