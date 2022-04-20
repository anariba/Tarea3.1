using PM3E44.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PM3E44.Services
{
    public class EmpleadoService : IEmpleadoRepositoy
    {
        public SQLiteAsyncConnection _database;

        public EmpleadoService (String dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Empleados>().Wait();
        }
        public async  Task<bool> AddEmepladoAsync(Empleados empleados)
        {
            if (empleados.Id > 0)

            {
                await _database.UpdateAsync(empleados);
            }
            else
            {
                await _database.InsertAsync(empleados);
            }

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteEmepladoAsync(int id)
        {
            await _database.DeleteAsync<Empleados>(id);
            return await Task.FromResult(true);
        }

        public async  Task<IEnumerable<Empleados>> GetEmepladosAsync()
        {
            return await Task.FromResult(await _database.Table<Empleados>().ToListAsync());
        }

        public async Task<Empleados> GetEmpleadoAsync(int id)
        {
            return await _database.Table<Empleados>().Where(e => e.Id == id).FirstOrDefaultAsync();
        }

        public Task<bool> UpdateEmepladoAsync(Empleados empleados)
        {
            throw new NotImplementedException();
        }
    }
}
