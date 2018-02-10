using System;

using Xamarin.Forms;

namespace WorkTracker.Views
{
    public class RootPage : ContentPage
    {
        public RootPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

