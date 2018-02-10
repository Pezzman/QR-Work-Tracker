using System;
using Xamarin.Forms;

namespace WorkTracker.Converters
{
    public class IsNotNullBooleanConverter : IValueConverter
    {
        public static IsNotNullBooleanConverter Instance = new IsNotNullBooleanConverter();

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return !string.IsNullOrEmpty(value?.ToString()) && value?.ToString() != "01/01/0001 00:00:00";
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
