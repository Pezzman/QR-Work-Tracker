using System;
using Prism.Mvvm;

namespace WorkTracker.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        public MainPageViewModel()
        {
            WelcomeText = "Hello World";
        }

        string _welcomeText;
        public string WelcomeText
        {
            get { return _welcomeText; }
            set { SetProperty(ref _welcomeText, value); }
        }
    }
}
