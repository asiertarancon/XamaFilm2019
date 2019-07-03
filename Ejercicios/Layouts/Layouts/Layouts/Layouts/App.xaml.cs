using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Layouts
{
	public partial class App : Application
	{
		public App ()
		{
            // Initialize Live Reload.
#if DEBUG
            LiveReload.Init();
#endif
            InitializeComponent();

            //MainPage = new StackLayoutPage();
            //MainPage = new GridPage();
            MainPage = new FlexLayoutPage();
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
