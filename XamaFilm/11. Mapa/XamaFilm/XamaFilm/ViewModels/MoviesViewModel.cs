using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using XamaFilm.Models;
using XamaFilm.Services;
using XamaFilm.ViewModels.Base;
using Xamarin.Forms;

namespace XamaFilm.ViewModels
{    
    public class MoviesViewModel : ViewModelBase
    {
        public MoviesViewModel()
        {            
            InitializeAsync(null);
        }
        public async override Task InitializeAsync(object navigationData)
        {
            Movies = new ObservableCollection<Movie>(await _dataService.GetMoviesAsync());
        }

        private ObservableCollection<Movie> _movies;
        public ObservableCollection<Movie> Movies
        {
            get => _movies;
            set { SetProperty(ref _movies, value); }
        }

        public ICommand MovieItemSelectedCommand => new Command<Movie>(OnItemSelected);

        private async void OnItemSelected(Movie movie)
        {
            var navigationState = Shell.Current.CurrentState;
            await Shell.Current.GoToAsync($"{navigationState.Location}/moviedetail?id={movie.ImdbId}");

            Shell.Current.FlyoutIsPresented = false;
        }
    }
}
