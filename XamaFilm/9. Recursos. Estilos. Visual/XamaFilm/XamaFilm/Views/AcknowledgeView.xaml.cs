using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaFilm.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamaFilm.Views
{
    public partial class AcknowledgeView : ContentPage
	{
		public AcknowledgeView ()
		{
			InitializeComponent ();

            BindingContext = new AcknowledgementViewModel();
		}
	}
}