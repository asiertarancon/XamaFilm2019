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
	public partial class MoviesListView : ContentPage
	{
        ViewModelBase VM;
        public MoviesListView ()
		{
			InitializeComponent ();

            VM = new MoviesListViewModel(DependencyService.Get<IDataService>());
            BindingContext = VM;
        }

        protected override void OnAppearing()
        {
            VM.InitializeAsync(null);
        }
    }
}