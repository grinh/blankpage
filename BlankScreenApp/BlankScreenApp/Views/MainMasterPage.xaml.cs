using MvvmCross.Forms.Views.Attributes;

namespace BlankScreenApp.Views
{
    [MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Master, NoHistory = true, WrapInNavigationPage = false)]
    public partial class MainMasterPage
    {
        public MainMasterPage()
        {
            InitializeComponent();
        }
    }
}