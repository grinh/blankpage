
using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Forms.Droid.Views;

namespace BlankScreenApp.Droid
{
    [Activity(Label = "BlankScreenApp", Icon = "@drawable/icon", Theme = "@style/MainTheme", ScreenOrientation = ScreenOrientation.Portrait, LaunchMode = LaunchMode.SingleTask)]
    public class MainActivity : MvxFormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            base.OnCreate(bundle);
        }
    }
}

