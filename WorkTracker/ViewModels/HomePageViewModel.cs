using System.Windows.Input;
using Prism.Navigation;
using WorkTracker.Base;
using Xamarin.Forms;

namespace WorkTracker.ViewModels
{
    public class HomePageViewModel : BaseViewModel 
    {
        INavigationService _navigationService;

        public ICommand ScanQRCommand { get; set; }

        public HomePageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            ScanQRCommand = new Command(NavigateToScanJob);
        }

        void NavigateToScanJob()
        {
            _navigationService.NavigateAsync("ScanWorkSitePage");
        }
    }
}
