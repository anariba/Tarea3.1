using PM3E44.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PM3E44.Services
{
   public  interface IEmpleadoRepositoy
    {

        Task<bool> AddEmepladoAsync(Empleados empleados);
        Task<bool> UpdateEmepladoAsync(Empleados empleados);
        Task<bool> DeleteEmepladoAsync(int id);
        Task<Empleados> GetEmpleadoAsync(int id);
        Task< IEnumerable<Empleados>> GetEmepladosAsync();




    }
}
