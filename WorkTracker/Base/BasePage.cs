using Xamarin.Forms;
namespace WorkTracker.Base
{
    public class BasePage : ContentPage
    {
        public BasePage()
        {
            NavigationPage.SetBackButtonTitle(this, "");
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var baseViewModel = BindingContext as BaseViewModel;
            baseViewModel?.OnPageAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            var baseViewModel = BindingContext as BaseViewModel;
            baseViewModel?.OnPageDisappearing();
        }
    }
}
