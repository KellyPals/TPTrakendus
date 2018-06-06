using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;


[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace TptRakendus
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new MainPage();
            AppCenter.Start("a51ff6f6-097c-4dcc-9e59-af18324c34bf", typeof(Analytics));
            Analytics.TrackEvent("App käivitus");
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
