using System;
using XamaFilm.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

//[assembly: XamlCompilation (XamlCompilationOptions.Compile)]

namespace XamaFilm
{
	public partial class App : Application
	{
		public App ()
		{

			InitializeComponent();

#if DEBUG
            HotReloader.Current.Run(this);
#endif

            //MainPage = new MasterView();
            //MainPage = new LoginView();
            //MainPage = new SettingsView();
            MainPage = new AppShell();
            //MainPage = new DetailMovieView();
            //MainPage = new DetailSerieView();
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
