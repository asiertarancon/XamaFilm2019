using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Views
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            ActivityIndicator.IsVisible = true;
            ActivityIndicator.IsRunning = true;

            await Task.Delay(5000);

            ActivityIndicator.IsVisible = false;
            ActivityIndicator.IsRunning = false;
        }
    }
}
