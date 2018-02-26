using BlankScreenApp.ViewModels;
using MvvmCross.Core.ViewModels;

namespace BlankScreenApp
{
    public class CoreApp : MvxApplication
    {
        public override void Initialize()
        {
            RegisterNavigationServiceAppStart<LoginViewModel>();
        }
    }
}