using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Forms.Droid.Platform;
using MvvmCross.Forms.Platform;
using MvvmCross.Platform.Platform;

namespace BlankScreenApp.Droid
{
    public class Setup : MvxFormsAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {

        }

        protected override MvxFormsApplication CreateFormsApplication()
        {
            return new BlankScreenApp.App();
        }

        protected override IMvxApplication CreateApp()
        {
            return new BlankScreenApp.CoreApp();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
    }
}
