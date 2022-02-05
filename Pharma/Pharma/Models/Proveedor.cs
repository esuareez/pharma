using System;
using System.Collections.Generic;

#nullable disable

namespace Pharma.Models
{
    public partial class Proveedor
    {
        public Proveedor()
        {
            OrdenCompras = new HashSet<OrdenCompra>();
        }

        public int IdProveedor { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }

        public virtual ICollection<OrdenCompra> OrdenCompras { get; set; }
    }
}
