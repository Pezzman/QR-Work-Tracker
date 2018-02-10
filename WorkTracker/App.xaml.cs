using Xamarin.Forms;

namespace WorkTracker
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new WorkTrackerPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
