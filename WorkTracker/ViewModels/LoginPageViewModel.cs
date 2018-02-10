using System.Windows.Input;
using Prism.Navigation;
using WorkTracker.Base;
using Xamarin.Forms;

namespace WorkTracker.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {
        INavigationService _navigationService;

        public ICommand LoginCommand { get; set; }

        public LoginPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            LoginCommand = new Command(Login);
        }

        void Login()
        {
            _navigationService.NavigateAsync("RootPage/HomePage");
        }
    }
}
