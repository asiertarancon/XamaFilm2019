using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamaFilm.Models;
using XamaFilm.ViewModels.Base;

namespace XamaFilm.ViewModels
{
	public class MoviesListViewModel : ViewModelBase
	{
		public MoviesListViewModel()
		{
			LoadData();
		}

		private async void LoadData()
		{
			Movies = new ObservableCollection<Movie>(await _dataService.GetMoviesAsync());
		}

		private ObservableCollection<Movie> _movies;
		public ObservableCollection<Movie> Movies
		{
			get => _movies;
			set => SetProperty(ref _movies, value);
		}
	}
}

