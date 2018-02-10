using Prism.Ioc;
using Prism.Unity;
using WorkTracker.ViewModels;
using WorkTracker.Views;

namespace WorkTracker
{
    public partial class App : PrismApplication
    {
        protected override void OnInitialized()
        {
            InitializeComponent();

            //TODO: Uncomment login page
            NavigationService.NavigateAsync("RootPage/HomePage");
            //NavigationService.NavigateAsync("LoginPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
			containerRegistry.RegisterForNavigation<RootPage>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
        }
    }
}
