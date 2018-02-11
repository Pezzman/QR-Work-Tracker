using System.Threading.Tasks;
using WorkTracker.Services.Interfaces;
using ZXing;

namespace WorkTracker.Services
{
    public class BarcodeScannerService : IBarcodeScannerService
    {
        public async Task<Result> ScanBarcode()
        {
            #if __ANDROID__
            // Initialize the scanner first so it can track the current context
            MobileBarcodeScanner.Initialize (Application);
            #endif

            var scanner = new ZXing.Mobile.MobileBarcodeScanner();

            var result = await scanner.Scan();

            //return result;
            return new Result("Example dummy data", null, null, BarcodeFormat.QR_CODE);
        }
    }
}
