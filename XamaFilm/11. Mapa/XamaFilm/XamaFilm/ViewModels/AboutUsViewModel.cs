using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamaFilm.Models;
using XamaFilm.ViewModels.Base;
using Xamarin.Forms.Maps;

namespace XamaFilm.ViewModels
{
	public class AboutUsViewModel : ViewModelBase
	{
		public AboutUsViewModel()
		{
			Company = new MyCompany()
			{
				Name = "Rioja{dotnet}",
				Delegations = new List<Delegation>()
				{
					new Delegation() { Name = "Rioja{dotnet}", City = "Logroño", Position = new Position(42.461108, -2.427075) },
					new Delegation() { Name = "DotNetters", City = "Zaragoza", Position = new Position(41.646682, -0.908887) },
					new Delegation() { Name = "Gasteiz developers", City = "Vitoria", Position = new Position(42.851078, -2.688660) },
				}
			};
		}

		private MyCompany _company;
		public MyCompany Company
		{
			get => _company;
			set => SetProperty(ref _company, value);
		}
	}
}
