using System;
using System.Collections.Generic;

namespace Pharma.Models
{
    public partial class Empleado
    {
        public Empleado()
        {
            OrdenCompras = new HashSet<OrdenCompra>();
        }

        public int IdEmpleado { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Puesto { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Cedula { get; set; } = null!;

        public virtual ICollection<OrdenCompra> OrdenCompras { get; set; }
    }
}
