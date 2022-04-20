using PM3E44.Models;
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
    public partial class AgregarEmpleadoPage : ContentPage
    {
        public Empleados Empleados { get; set; }
        public AgregarEmpleadoPage()
        {
            InitializeComponent();
            BindingContext = new AgregarEmplandoViewModel();

        }
        public AgregarEmpleadoPage(Empleados empleados)
        {
            InitializeComponent();
            BindingContext = new AgregarEmplandoViewModel();

            if(empleados != null) 
            {
                ((AgregarEmplandoViewModel)BindingContext).Empleados = empleados;
            }
        }
    }
}