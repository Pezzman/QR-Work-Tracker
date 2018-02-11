using System;
using System.Threading.Tasks;
using ZXing;

namespace WorkTracker.Services.Interfaces
{
    public interface IBarcodeScannerService
    {
        Task<Result> ScanBarcode();
    }
}
