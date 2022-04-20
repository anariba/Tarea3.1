using PM3E44.Models;
using PM3E44.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PM3E44.ViewModels
{
    public class EmpleadoViewModel : BaseViewModel
    {
        public Command LoadEmpleadoCommand { get; }

        public  ObservableCollection<Empleados> Empleados { get; }

        public Command AgregarEmpleadoCommand { get; }
        public Command EmpleadoEdit { get; }
        public Command EmpleadoDelete { get; }

        public EmpleadoViewModel(INavigation _navigation)
        {
            LoadEmpleadoCommand = new Command(async () => await ExecuteLoadEmpleadoCommand());
            Empleados = new ObservableCollection<Empleados>();
             AgregarEmpleadoCommand = new Command(OnAddEmpleado);
            EmpleadoEdit = new Command<Empleados>(OnEditEmpleado);
            EmpleadoDelete = new Command<Empleados>(OnDeleteEmpleado);
            Navigation = _navigation;

        }
        private async void OnEditEmpleado(Empleados empleados)
        {
            await Navigation.PushAsync(new AgregarEmpleadoPage(empleados));
        }

        private async void OnDeleteEmpleado(Empleados empleados)
        {
            if (empleados == null)
            {
                return;
            }
            await App.EmpleadoService.DeleteEmepladoAsync(empleados.Id);
            await ExecuteLoadEmpleadoCommand();
        }




        private async void OnAddEmpleado(object obj)
        {
            await Shell.Current.GoToAsync(nameof(AgregarEmpleadoPage));
        }

       

        public  void OnAppearing()
        {
            IsBusy = true;
           
        }
        async Task ExecuteLoadEmpleadoCommand()
        {
            IsBusy = true;
            
            try
            {
                Empleados.Clear();
                var empList = await App.EmpleadoService.GetEmepladosAsync();
                foreach (var emp in empList)
                {
                    Empleados.Add(emp);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                IsBusy = false;
            }

        }
    }
}
