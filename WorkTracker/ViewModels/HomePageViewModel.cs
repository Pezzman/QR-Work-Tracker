using Prism.Mvvm;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WorkTracker.ViewModels
{
    public class HomePageViewModel : BindableBase 
    {
        public ICommand ScanQRCommand { get; set; }

        public HomePageViewModel()
        {
            ScanQRCommand = new Command(async () => await ScanQRCode());
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
                Debug.WriteLine("Scanned Barcode: " + result.Text);
        }
    }
}
