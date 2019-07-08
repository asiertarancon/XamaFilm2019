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
    public partial class MoviesListView : ContentPage
    {
        public MoviesListView()
        {
            InitializeComponent();

            BindingContext = new MoviesViewModel();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (listview.SelectedItem == null)
                return;
            Navigation.PushAsync(new DetailMovieView(listview.SelectedItem as Movie));
            listview.SelectedItem = null;
        }
    }
}