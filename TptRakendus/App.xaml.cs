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
            AppCenter.Start("397a1dbc-291f-49ac-9d1c-d8825888a83d", typeof(Analytics));
            Analytics.TrackEvent("App käitivus");
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
