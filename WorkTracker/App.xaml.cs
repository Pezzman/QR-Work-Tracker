using Prism.Ioc;
using Prism.Unity;
using WorkTracker.ViewModels;
using WorkTracker.Views;
using WorkTracker.Services.Interfaces;
using WorkTracker.Services;
using Xamarin.Forms;
using System.Globalization;

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

            var newCulture = new CultureInfo("en-GB");
            CultureInfo.DefaultThreadCurrentCulture = newCulture;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
			containerRegistry.RegisterForNavigation<RootPage>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
            containerRegistry.RegisterForNavigation<ScanWorkSitePage, ScanWorkSiteViewModel>();
            containerRegistry.RegisterForNavigation<ScanJobPage, ScanJobViewModel>();
            containerRegistry.RegisterForNavigation<ConfirmJobPage,ConfirmJobViewModel>();

            containerRegistry.Register<IBarcodeScannerService, BarcodeScannerService>();
        }
    }
}
