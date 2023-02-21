using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using ShoppingApp.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.WindowsSpecific;

namespace ShoppingApp.Experiment
{	
	public partial class Page1 : ContentPage
	{
        public Page1()
        {
            InitializeComponent();
            BindingContext = new ExpShellViewModel();
        }

        async void RefreshView_Refreshing(System.Object sender, System.EventArgs e)
        {
            await Task.Delay(2000);
            myRefreshView.IsRefreshing = false;
        }

        async void ShopButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Page4());
        }
    }
}

