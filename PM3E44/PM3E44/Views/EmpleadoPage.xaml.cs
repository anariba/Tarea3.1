using PM3E44.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM3E44.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmpleadoPage : ContentPage
    {
        EmpleadoViewModel empleadoViewModel;
        public EmpleadoPage()
        {
            InitializeComponent();
            BindingContext = empleadoViewModel = new EmpleadoViewModel(Navigation);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            empleadoViewModel.OnAppearing();
        }
    }
}