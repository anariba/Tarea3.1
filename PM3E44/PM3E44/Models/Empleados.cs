using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PM3E44.Models
{
    public class Empleados
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public String Nombre { get; set; }

        public String Apellidos { get; set; }

        public Int32 edad { get; set; }

        public String Dir { get; set; }

        public String Puesto { get; set; }
    }
}
