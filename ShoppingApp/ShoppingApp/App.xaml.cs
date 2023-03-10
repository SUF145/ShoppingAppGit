using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ShoppingApp.Services;
using ShoppingApp.Views;

namespace ShoppingApp
{
    public partial class App : Application
    {

        public App ()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new ExpShell();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

