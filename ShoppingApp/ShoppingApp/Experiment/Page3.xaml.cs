using System;
using System.Collections.Generic;

using Xamarin.Forms;

[assembly: ExportFont("CabinSketch-Regular.ttf", Alias = "Cabin-Sketch")]
namespace ShoppingApp.Experiment
{	
	public partial class Page3 : ContentPage
	{	
		public Page3 ()
		{
			InitializeComponent ();
		}

        async void SignInButton_Clicked(System.Object sender, System.EventArgs e)
        {
			await DisplayAlert("Congratulations","You are signed in","Ok");
        }
    }
}

