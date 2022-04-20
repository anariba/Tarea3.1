using PM3E44.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PM3E44.ViewModels
{
    public class AgregarEmplandoViewModel:BaseEmpladoViewModel
    {
        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        public AgregarEmplandoViewModel()

        {
            SaveCommand = new Command(OnSave);
            CancelCommand = new Command(OnCancel);
            Empleados = new Empleados();
            this.PropertyChanged += (_, __) => SaveCommand.ChangeCanExecute();
        }

        private async void OnSave()
        {
            var empleado = Empleados;
            await App.EmpleadoService.AddEmepladoAsync(empleado);

            await Shell.Current.GoToAsync("..");



        }
        private async void OnCancel()
        {


            await Shell.Current.GoToAsync("..");
        }


    }
}
