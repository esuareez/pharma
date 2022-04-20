using System;
using System.Collections.Generic;

namespace Pharma.Models
{
    public partial class Proveedor
    {
        public Proveedor()
        {
            OrdenCompras = new HashSet<OrdenCompra>();
        }

        public int IdProveedor { get; set; }
        public string Direccion { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public byte[]? Img { get; set; }
        public int Estado { get; set; }

        public virtual ICollection<OrdenCompra> OrdenCompras { get; set; }
    }
}
