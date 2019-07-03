using ListView.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace ListView.ViewModel
{
    public class MainViewModel : BindableObject
    {
		private ObservableCollection<Event> _listaEventos;
		public ObservableCollection<Event> ListaEventos
		{
			get => _listaEventos;
			set
			{
				_listaEventos = value;
				OnPropertyChanged();
			}
		}

		public MainViewModel()
		{
			ListaEventos = new ObservableCollection<Event>()
			{
				new Event(){ Name = "Curso Xamarin Forms", Location = "ThinkTIC", Date = DateTime.Today},
				new Event(){ Name = "Microservicios", Location = "Ibercaja", Date = DateTime.Today.AddMonths(-7)},
				new Event(){ Name = "Docker", Location = "Universidad", Date = DateTime.Today.AddMonths(-3)}
			};
		}
		
	}
}
