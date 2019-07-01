using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace EjConverters
{
    public class SemaphoreConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((Semaphore)value)
            {
                case Semaphore.green: return Color.Green;
                case Semaphore.yellow: return Color.Yellow;
                case Semaphore.red: return Color.Red;
                default:
                    return Color.Black;
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
