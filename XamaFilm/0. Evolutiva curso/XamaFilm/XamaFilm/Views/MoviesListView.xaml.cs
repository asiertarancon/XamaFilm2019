using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaFilm.Models;
using XamaFilm.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamaFilm.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MoviesListView : ContentPage
	{
		public MoviesListView()
		{
			InitializeComponent();

			BindingContext = new MoviesListViewModel();
		}

		private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
		{
			await Navigation.PushAsync(new DetailMovieView(e.Item as Movie));

		}
	}
}