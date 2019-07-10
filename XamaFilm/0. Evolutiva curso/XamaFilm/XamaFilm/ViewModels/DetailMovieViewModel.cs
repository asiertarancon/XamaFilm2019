using System;
using System.Collections.Generic;
using System.Text;
using XamaFilm.Models;
using XamaFilm.ViewModels.Base;

namespace XamaFilm.ViewModels
{
	public class DetailMovieViewModel : ViewModelBase
	{
		public DetailMovieViewModel(Movie movie)
		{
			Movie = movie;
		}

		private Movie _movie;
		public Movie Movie
		{
			get => _movie;
			set => SetProperty(ref _movie, value);
		}
	}
}
