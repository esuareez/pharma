using System;
using System.Collections.Generic;

#nullable disable

namespace Pharma.Models
{
    public partial class PedidoProducto
    {
        public int Idpedido { get; set; }
        public int Idproducto { get; set; }
        public int Cantidad { get; set; }

        public virtual Pedido IdpedidoNavigation { get; set; }
        public virtual Producto IdproductoNavigation { get; set; }
    }
}
