using PM3E44.Services;
using PM3E44.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM3E44
{
    public partial class App : Application
    {
        static EmpleadoService _empleadoService;
        public static EmpleadoService EmpleadoService
        {
            get
            {
                if (_empleadoService == null) 
                {
                    _empleadoService = new EmpleadoService(Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Empleados.db3"));
                
                }

                return _empleadoService;
            }
        }

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
