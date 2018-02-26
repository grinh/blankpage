using MvvmCross.Forms.Views.Attributes;

namespace BlankScreenApp.Views
{
    [MvxContentPagePresentation(NoHistory = true)]
    public partial class LoginPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
    }
}