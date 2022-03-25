using System;
using System.Collections.Generic;

#nullable disable

namespace Pharma.Models
{
    public partial class OrdenProducto
    {
        public int IdOc { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }

        public virtual OrdenCompra IdOcNavigation { get; set; }
        public virtual Producto IdProductoNavigation { get; set; }
    }
}
