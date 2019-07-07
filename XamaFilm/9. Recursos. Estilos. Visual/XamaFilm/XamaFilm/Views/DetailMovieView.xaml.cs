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

	public partial class DetailMovieView : ContentPage
	{
        public DetailMovieView()
        {
            InitializeComponent();
        }
        public DetailMovieView(Movie serie) : this()
        {
            BindingContext = new DetailMovieViewModel(serie);
        }
    }
}