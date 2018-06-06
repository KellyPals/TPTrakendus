using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;

namespace TptRakendus
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Oplilasele : ContentPage
	{
		public Oplilasele ()
		{
			InitializeComponent ();
            AppCenter.Start("a51ff6f6-097c-4dcc-9e59-af18324c34bf", typeof(Analytics));
            Analytics.TrackEvent("Õpilasele");
        }
	}
}