using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaFilm.Services;
using XamaFilm.ViewModels;
using XamaFilm.ViewModels.Base;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamaFilm.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SeriesListView : ContentPage
	{
        ViewModelBase VM;
		public SeriesListView ()
		{
			InitializeComponent ();

            VM = new SeriesListViewModel(DependencyService.Get<IDataService>());
            BindingContext = VM;
		}

        protected override void OnAppearing()
        {
            VM.InitializeAsync(null);
        }
    }
}