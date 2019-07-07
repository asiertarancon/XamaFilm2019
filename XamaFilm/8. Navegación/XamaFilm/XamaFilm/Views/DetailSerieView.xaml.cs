using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaFilm.Models;
using XamaFilm.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamaFilm.Views
{
	public partial class DetailSerieView : TabbedPage
	{
		public DetailSerieView ()
		{
			InitializeComponent ();

                        
        }

        public DetailSerieView(Serie serie) : this()
        {
            BindingContext = new DetailSerieViewModel(serie);
        }
    }
}