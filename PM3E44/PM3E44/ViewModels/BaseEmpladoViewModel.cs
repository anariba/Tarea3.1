using PM3E44.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace PM3E44.ViewModels
{
   public  class BaseEmpladoViewModel
    {
        private Empleados _empleado;

        //public INavigation Navigation { get; set; }

        public Empleados Empleados
        {
            get { return _empleado; }
            set { _empleado = value; OnPropertyChanged(); }
        }

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                SetProperty(ref isBusy, value);
            }
        }
        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName] String propertyName = "",
            Action OnChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            OnChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            var Changed = PropertyChanged;
            if (Changed == null)
                return;

            Changed.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}
