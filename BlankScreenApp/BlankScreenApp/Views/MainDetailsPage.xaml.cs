using MvvmCross.Forms.Views.Attributes;

namespace BlankScreenApp.Views
{

    [MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Detail, NoHistory = true)]
    public partial class MainDetailsPage
    {
        public MainDetailsPage()
        {
            InitializeComponent();
        }
    }
}