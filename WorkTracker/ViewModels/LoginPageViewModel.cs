using System.Windows.Input;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;
namespace WorkTracker.ViewModels
{
    public class LoginPageViewModel : BindableBase
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
