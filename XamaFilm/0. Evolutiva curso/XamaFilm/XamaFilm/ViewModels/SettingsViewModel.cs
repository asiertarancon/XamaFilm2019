using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using XamaFilm.ViewModels.Base;
using Xamarin.Forms;

namespace XamaFilm.ViewModels
{
	public class SettingsViewModel : ViewModelBase
	{
		public ICommand AboutUsCommand => new Command(async () =>
		{
			await Shell.Current.GoToAsync("aboutus");
		});

		public ICommand AcknowledgeCommand => new Command(async () =>
		{
			await Shell.Current.GoToAsync("acknowledge");
		});
	}
}
