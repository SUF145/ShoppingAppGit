   using System;
using ShoppingApp;
using ShoppingApp.Experiment;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.WindowsSpecific;

namespace ShoppingApp.ViewModels
{
    public class ExpShellViewModel : INotifyPropertyChanged
    {
        public ExpShellViewModel()
        {
            TshirtList = new ObservableCollection<Tshirt>
            {
                new Tshirt{ Name="Delhi ", Description="Men Oversized pure cotton Tshirt", Price=599, Url="harry-potter-tshirt-glow-in-the-dark-mydesignation-mockup-glow.gif"},
                new Tshirt{ Name="Karnataka ", Description="Men Oversized pure cotton Tshirt", Price=699, Url="trivandrum-tshirt-mydesignation-image-latest.jpg"},
                new Tshirt { Name = "Kerela ", Description = "Men Oversized pure cotton Tshirt", Price = 799, Url = "adipoli-tshirt-mydesignation-glowing-image.gif" },
                new Tshirt { Name = "Goa ", Description = "Men Oversized pure cotton Tshirt", Price = 899, Url = "naatil-evideya-tshirt-mockup-image-.jpg" },
                new Tshirt { Name = "Tamil Nadu ", Description = "Men Oversized pure cotton Tshirt", Price = 999, Url = "but-why-tshirt-mydesignation-image-latest.jpg" },
                new Tshirt { Name = "Punjab ", Description = "Men Oversized pure cotton Tshirt", Price = 499, Url = "Onnu-nannayikoode-main-800x800.gif" }
            };
        }


        public ObservableCollection<Tshirt> Tshirts;

        public ObservableCollection<Tshirt> TshirtList
        {
            get { return Tshirts; }
            set
            {
                Tshirts = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

