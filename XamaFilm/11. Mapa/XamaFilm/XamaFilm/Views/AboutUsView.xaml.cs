using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaFilm.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace XamaFilm.Views
{
	public partial class AboutUsView : ContentPage
	{
		public AboutUsView ()
		{
			InitializeComponent ();
			BindingContext = new AboutUsViewModel();

			MapSpan.FromCenterAndRadius(new Position(42.461108, -2.427075), new Distance(10000));
		}
	}
}