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
        public DetailMovieViewModel(Movie movie)
        {
            Item = movie;
        }        

        private Movie _movie;
        public Movie Item
        {
            get => _movie;
            set { SetProperty(ref _movie, value); }            
        }
    }
}
