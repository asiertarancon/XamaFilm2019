using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaFilm.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamaFilm
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AppShell : Shell
	{
		public AppShell()
		{
			InitializeComponent();

			Routing.RegisterRoute("aboutus", typeof(AboutUsView));
			Routing.RegisterRoute("acknowledge", typeof(AcknowledgeView));

		}
	}
}