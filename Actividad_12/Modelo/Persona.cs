using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Actividad_12.Modelo
{
    public class Persona
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public Int64 Telefono { get; set; }
    }
}