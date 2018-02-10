using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Navigation;
using WorkTracker.Base;
using Xamarin.Forms;

namespace WorkTracker.ViewModels
{
    public class ScanJobViewModel : BaseViewModel
    {
        INavigationService _navigationService;

        public ICommand ScanQRCommand { get; set; }

        public ScanJobViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            ScanQRCommand = new Command(async () => await ScanQRCode());

            Task.Run(async () => await ScanQRCode());
        }

        async Task ScanQRCode()
        {
            #if __ANDROID__
                                        // Initialize the scanner first so it can track the current context
            MobileBarcodeScanner.Initialize (Application);
            #endif

            var scanner = new ZXing.Mobile.MobileBarcodeScanner();

            var result = await scanner.Scan();

            if (result != null)
                ScanResult = result.Text;

            ScanResult = "Example Job Name";
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
