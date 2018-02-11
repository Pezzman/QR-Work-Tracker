using Prism.Mvvm;
using Prism.Navigation;
namespace WorkTracker.Base
{
    public class BaseViewModel : BindableBase, INavigationAware
    {
        public BaseViewModel() { }

        public virtual void OnPageAppearing() { }

        public virtual void OnPageDisappearing() { }

		public virtual void OnNavigatedFrom(NavigationParameters parameters) { }
		
		public virtual void OnNavigatedTo(NavigationParameters parameters) { }
		
		public virtual void OnNavigatingTo(NavigationParameters parameters) { }
    }
}
