using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamaFilm.Models;
using XamaFilm.ViewModels.Base;

namespace XamaFilm.ViewModels
{
	public class SeriesListViewModel : ViewModelBase
	{
		public SeriesListViewModel()
		{
			LoadData();
		}

		private async void LoadData()
		{
			Series = new ObservableCollection<Serie>(await _dataService.GetSeriesAsync());
		}

		private ObservableCollection<Serie> _series;
		public ObservableCollection<Serie> Series
		{
			get => _series;
			set => SetProperty(ref _series, value);
		}
	}
}
