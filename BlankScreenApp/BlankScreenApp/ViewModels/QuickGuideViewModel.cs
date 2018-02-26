using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace BlankScreenApp.ViewModels
{
    public class QuickGuideViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _NavigationService;
        public ICommand NavigateToMainPage { get; }

        public QuickGuideViewModel(IMvxNavigationService navigationService)
        {
            _NavigationService = navigationService;
            NavigateToMainPage = new MvxCommand(NavigateToMainPageCommandHandler);
        }

        private void NavigateToMainPageCommandHandler()
        {
            _NavigationService.Navigate<MainDetailsViewModel>();
            _NavigationService.Navigate<MainMasterViewModel>();
        }
    }
}