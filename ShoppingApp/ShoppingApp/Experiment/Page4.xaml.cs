using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using Xamarin.Forms.PlatformConfiguration.WindowsSpecific;
using ShoppingApp.Models;

namespace ShoppingApp.Experiment
{	
	public partial class Page4 : ContentPage
	{
		public Page4 ()
		{
			InitializeComponent ();
        }

        async void ExploreMoreButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}

