using System.Windows.Input;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace BlankScreenApp.ViewModels
{
    public class MainMasterViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _NavigationService;
        public ICommand NavigateToLoginPage { get; }
        public ICommand NavigateToQuickGuidePage { get; }

        public MainMasterViewModel(IMvxNavigationService navigationService)
        {
            _NavigationService = navigationService;
            NavigateToQuickGuidePage = new MvxCommand(NavigateToQuickGuideCommandHandler);
            NavigateToLoginPage = new MvxCommand(NavigateToLoginPageCommandHandler);
        }

        private void NavigateToQuickGuideCommandHandler()
        {
            _NavigationService.Navigate<QuickGuideViewModel>();
        }

        private void NavigateToLoginPageCommandHandler()
        {
            _NavigationService.Navigate<LoginViewModel>();
        }
    }
}