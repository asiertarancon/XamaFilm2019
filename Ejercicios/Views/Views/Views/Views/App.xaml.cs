using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Views
{
	public partial class App : Application
	{
		public App ()
		{
            LiveReload.Init();

			InitializeComponent();

            //MainPage = new LoginPage();
            //MainPage = new EventPage();
            MainPage = new CalculatorPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
