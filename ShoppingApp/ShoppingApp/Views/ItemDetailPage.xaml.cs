using System.ComponentModel;
using Xamarin.Forms;
using ShoppingApp.ViewModels;

namespace ShoppingApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
