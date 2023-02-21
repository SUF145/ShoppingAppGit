using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;
using Xamarin.Forms.PlatformConfiguration.WindowsSpecific;

namespace ShoppingApp.Experiment
{	
	public partial class Page2 : ContentPage
	{	
		public Page2 ()
		{
			InitializeComponent ();
		}

        async void RefreshView_Refreshing(System.Object sender, System.EventArgs e)
        {
			await Task.Delay(1000);
            myRefreshView.IsRefreshing = false;
        }
    }
}

