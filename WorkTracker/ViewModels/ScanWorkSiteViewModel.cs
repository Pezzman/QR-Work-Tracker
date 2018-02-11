using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Navigation;
using WorkTracker.Base;
using Xamarin.Forms;
using WorkTracker.Services.Interfaces;

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

            Device.BeginInvokeOnMainThread(async () => 
            {
                await ScanQRCode();
            });
        }

        async Task ScanQRCode()
        {
            var response = await _barcodeScannerService.ScanBarcode();
            ScanResult = response.Text;
        }

        void Continue()
        {
            _navigationService.NavigateAsync("ScanJobPage");
        }

        string _scanResult;
        public string ScanResult
        {
            get { return _scanResult; }
            set { SetProperty(ref _scanResult, value); }
        }
    }
}
