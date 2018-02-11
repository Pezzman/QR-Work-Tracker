using System;
using WorkTracker.Base;
using WorkTracker.Models;
using Prism.Navigation;
using System.Windows.Input;
using Xamarin.Forms;
namespace WorkTracker.ViewModels
{
    public class ConfirmJobViewModel : BaseViewModel
    {
        INavigationService _navigationService;

        public ICommand ConfirmCommand { get; set; }

        public ConfirmJobViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            ConfirmCommand = new Command(ConfirmJob);
        }

        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            ScanJobModel = (ScanJobModel)parameters[nameof(ScanJobModel)];
            SetDummyData();
        }

        void SetDummyData()
        {
            ScanJobModel.WorkSite = "Bristol Terrace";
            ScanJobModel.Description = "Bathroom";
            ScanJobModel.Abbreviation = "1ST BATH";
            ScanJobModel.Fix = "1st Fix";
            ScanJobModel.Unit = "EA";
            ScanJobModel.Price = 25;
        }

        void ConfirmJob()
        {
            _navigationService.GoBackToRootAsync();
        }

        ScanJobModel _scanJobModel;
        public ScanJobModel ScanJobModel
        {
            get { return _scanJobModel; }
            set { SetProperty(ref _scanJobModel, value); }
        }
    }
}
