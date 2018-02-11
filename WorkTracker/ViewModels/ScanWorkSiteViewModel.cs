using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Navigation;
using WorkTracker.Base;
using Xamarin.Forms;
using WorkTracker.Services.Interfaces;
using WorkTracker.Models;
using WorkTracker.Views;

namespace WorkTracker.ViewModels
{
    public class ScanWorkSiteViewModel : BaseViewModel
    {
        INavigationService _navigationService;
        IBarcodeScannerService _barcodeScannerService;

        public ICommand ScanQRCommand { get; set; }
        public ICommand ConfirmCommand { get; set; }

        public ScanWorkSiteViewModel(INavigationService navigationService, IBarcodeScannerService barcodeScannerService)
        {
            _navigationService = navigationService;
            _barcodeScannerService = barcodeScannerService;

            ScanQRCommand = new Command(async () => await ScanQRCode());
            ConfirmCommand = new Command(Continue);
        }

        async Task ScanQRCode()
        {
            var response = await _barcodeScannerService.ScanBarcode();
            ScanResult = response.Text;
        }

        void Continue()
        {
            var param = new NavigationParameters
            {
                { nameof(ScanJobViewModel.ScanJobModel), new ScanJobModel { WorkSite = ScanResult } }
            };
            _navigationService.NavigateAsync("ScanJobPage", param);
        }

        string _scanResult;
        public string ScanResult
        {
            get { return _scanResult; }
            set { SetProperty(ref _scanResult, value); }
        }
    }
}
