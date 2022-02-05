using System;
using System.Collections.Generic;

#nullable disable

namespace Pharma.Models
{
    public partial class OrdenCompra
    {
        public string IdOrComp { get; set; }
        public int IdProveedor { get; set; }
        public int IdEmpleado { get; set; }
        public string Producto { get; set; }
        public int CantidadProduc { get; set; }
        public double MontoPagar { get; set; }
        public DateTime Fecha { get; set; }
        public string DescripcionProducto { get; set; }
        public string Estado { get; set; }

        public virtual Empleado IdEmpleadoNavigation { get; set; }
        public virtual Proveedor IdProveedorNavigation { get; set; }
    }
}
