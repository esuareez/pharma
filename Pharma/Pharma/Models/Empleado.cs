using System;
using System.Collections.Generic;

#nullable disable

namespace Pharma.Models
{
    public partial class Empleado
    {
        public Empleado()
        {
            OrdenCompras = new HashSet<OrdenCompra>();
        }

        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Puesto { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }
        public string Cedula { get; set; }

        public virtual ICollection<OrdenCompra> OrdenCompras { get; set; }
    }
}
