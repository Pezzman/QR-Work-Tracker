using Prism.Mvvm;
namespace WorkTracker.Base
{
    public class BaseViewModel : BindableBase
    {
        public BaseViewModel() { }

        public virtual void OnPageAppearing() { }

        public virtual void OnPageDisappearing() { }
    }
}
