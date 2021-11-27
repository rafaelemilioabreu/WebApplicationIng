using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplicationIng.Models
{
    public partial class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public DateTime? Nacimiento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Puesto { get; set; }
        public string Correo { get; set; }
    }
}
