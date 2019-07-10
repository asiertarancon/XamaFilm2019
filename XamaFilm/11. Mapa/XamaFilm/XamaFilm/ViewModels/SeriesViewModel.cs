using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using XamaFilm.Models;
using XamaFilm.ViewModels.Base;
using Xamarin.Forms;

namespace XamaFilm.ViewModels
{
    public class SeriesViewModel : ViewModelBase
    {
        public SeriesViewModel()
        {
            InitializeAsync(null);
        }

        public async override Task InitializeAsync(object navigationData)
        {
            Series = new ObservableCollection<Serie>(await _dataService.GetSeriesAsync());
        }

        private ObservableCollection<Serie> _series;
        public ObservableCollection<Serie> Series
        {
            get => _series;
            set { SetProperty(ref _series, value); }            
        }

        //public ICommand SerieItemSelectedCommand => new Command<Serie>(OnSerieItemSelected);

        //private async void OnSerieItemSelected(Serie serie)
        //{
        //    await NavigationService.NavigateToAsync<DetailSerieViewModel>(serie);
        //}
    }
}
