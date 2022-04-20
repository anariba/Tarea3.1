using PM3E44.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PM3E44.Views
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