using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace XamaFilm.Converters
{
	public class RatingToColorConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			double rating = 0;
			bool res = Double.TryParse(value.ToString(), out rating);

			if (!res)
				return Color.Black;
			//int rating = Int32.Parse(value.ToString());
			if (rating > 8)
			{
				return Color.Green;
			}
			else if (rating > 6)
			{
				return Color.Orange;
			}
			else
				return Color.Red;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
