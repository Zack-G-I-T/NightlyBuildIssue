using CommunityToolkit.Maui.Layouts;

namespace NightlyBuildIssues
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }
    }

}
