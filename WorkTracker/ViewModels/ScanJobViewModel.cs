using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Navigation;
using WorkTracker.Base;
using WorkTracker.Services.Interfaces;
using Xamarin.Forms;
using WorkTracker.Models;

namespace WorkTracker.ViewModels
{
    public class ScanJobViewModel : BaseViewModel
    {
        INavigationService _navigationService;
        IBarcodeScannerService _barcodeScannerService;

        public ICommand ScanQRCommand { get; set; }
        public ICommand ConfirmCommand { get; set; }

        public ScanJobViewModel(INavigationService navigationService, IBarcodeScannerService barcodeScannerService)
        {
            _navigationService = navigationService;
            _barcodeScannerService = barcodeScannerService;

            ScanQRCommand = new Command(async () => await ScanQRCode());
            ConfirmCommand = new Command(Continue);
        }

        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            ScanJobModel = (ScanJobModel)parameters[nameof(ScanJobModel)];
        }

        async Task ScanQRCode()
        {
            var response = await _barcodeScannerService.ScanBarcode();
            ScanResult = response.Text;
            ScanJobModel.Job = response.Text;
        }

        void Continue()
        {
            var param = new NavigationParameters
            {
                { nameof(ConfirmJobViewModel.ScanJobModel), ScanJobModel }
            };

            _navigationService.NavigateAsync("ConfirmJobPage", param);
        }

        public ScanJobModel ScanJobModel { get; set; }

        string _scanResult;
        public string ScanResult
        {
            get { return _scanResult; }
            set { SetProperty(ref _scanResult, value); }
        }
    }
}
