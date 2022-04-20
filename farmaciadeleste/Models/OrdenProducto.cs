using System;
using System.Collections.Generic;

namespace Pharma.Models
{
    public partial class OrdenProducto
    {
        public int IdOc { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }

        public virtual OrdenCompra IdOcNavigation { get; set; } = null!;
        public virtual Producto IdProductoNavigation { get; set; } = null!;
    }
}
