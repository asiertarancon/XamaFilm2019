using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamaFilm.Models;
using XamaFilm.Services;
using XamaFilm.ViewModels.Base;

namespace XamaFilm.ViewModels
{    
    public class DetailMovieViewModel : ViewModelBase
    {        
        public DetailMovieViewModel()
        {
        }

        public string Id
        {
            set
            {
                LoadMovie(value);
            }
        }

        private async Task LoadMovie(string id)
        {
            Movie movie = await _dataService.GetMovieByIdAsync(id);

            if (movie != null)
            {
                Item = _movie;
                //Name = monkey.Name;
                //Location = monkey.Location;
                //Details = monkey.Details;
                //ImageUrl = monkey.ImageUrl;
                //OnPropertyChanged("Name");
                //OnPropertyChanged("Location");
                //OnPropertyChanged("Details");
                //OnPropertyChanged("ImageUrl");
            }
        }

        private Movie _movie;
        public Movie Item
        {
            get => _movie;
            set { SetProperty(ref _movie, value); }            
        }
    }
}
