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
    public partial class SeriesListView : ContentPage
    {
        public SeriesListView()
        {
            InitializeComponent();

            BindingContext = new SeriesViewModel();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (listview.SelectedItem == null)
                return;
            Navigation.PushAsync(new DetailSerieView(listview.SelectedItem as Serie));
            listview.SelectedItem = null;
        }
    }
}