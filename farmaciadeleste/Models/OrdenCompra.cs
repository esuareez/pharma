using System;
using System.Collections.Generic;

namespace Pharma.Models
{
    public partial class OrdenCompra
    {
        public OrdenCompra()
        {
            OrdenProductos = new HashSet<OrdenProducto>();
        }

        public int IdOrComp { get; set; }
        public int? IdProveedor { get; set; }
        public int IdEmpleado { get; set; }
        public double MontoPagar { get; set; }
        public DateTime Fecha { get; set; }
        public int? Estado { get; set; }

        public virtual Empleado IdEmpleadoNavigation { get; set; } = null!;
        public virtual Proveedor? IdProveedorNavigation { get; set; }
        public virtual ICollection<OrdenProducto> OrdenProductos { get; set; }
    }
}
