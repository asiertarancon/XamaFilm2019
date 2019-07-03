using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EventPage : ContentPage
	{
		public EventPage ()
		{
			InitializeComponent ();
		}

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            SeatsStepper.Text = Stepper.Value.ToString();
        }
    }
}