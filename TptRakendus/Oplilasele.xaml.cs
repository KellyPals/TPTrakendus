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
            AppCenter.Start("397a1dbc-291f-49ac-9d1c-d8825888a83d", typeof(Analytics));
            Analytics.TrackEvent("Õpilasele");
        }
	}
}