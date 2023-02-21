using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace ShoppingApp.Views
{
    public partial class AboutPage : ContentPage
    {
        ObservableCollection<Tshirt> Tshirts;
        public AboutPage()
        {
            InitializeComponent();
            Tshirts = new ObservableCollection<Tshirt>
            {
                new Tshirt{ Name="Delhi ", Description="Men Oversized pure cotton Tshirt", Price=599, Url="https://www.mydesignation.com/wp-content/uploads/2019/02/harry-potter-tshirt-glow-in-the-dark-mydesignation-mockup-glow.gif"},
                new Tshirt{ Name="Karnataka ", Description="Men Oversized pure cotton Tshirt", Price=699, Url="https://www.mydesignation.com/wp-content/uploads/2019/06/trivandrum-tshirt-mydesignation-image-latest.jpg"},
                new Tshirt{ Name="Kerela ", Description="Men Oversized pure cotton Tshirt", Price=799, Url="https://www.mydesignation.com/wp-content/uploads/2021/07/adipoli-tshirt-mydesignation-glowing-image.gif"},
                new Tshirt{ Name="Goa ", Description="Men Oversized pure cotton Tshirt", Price=899, Url="https://www.mydesignation.com/wp-content/uploads/2022/12/naatil-evideya-tshirt-mockup-image-.jpg"},
                new Tshirt{ Name="Tamil Nadu ", Description="Men Oversized pure cotton Tshirt", Price=999, Url="https://www.mydesignation.com/wp-content/uploads/2019/08/malayali-tshirt-mydesignation-mockup-image-latest-golden-.jpg"},
                new Tshirt{ Name="Punjab ", Description="Men Oversized pure cotton Tshirt", Price=499, Url="https://www.mydesignation.com/wp-content/uploads/2022/01/minnal-murali-tshirt-saniya-iyappan-maroon-mydesignation-latest.jpg"}
            };
            TshirtCollecion.ItemsSource = Tshirts;
        }
    }
}
