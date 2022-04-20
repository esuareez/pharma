using System;
using System.Collections.Generic;

namespace Pharma.Models
{
    public partial class Pedido
    {
        public Pedido()
        {
            Facturas = new HashSet<Factura>();
            PedidoProductos = new HashSet<PedidoProducto>();
        }

        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public DateTime? FechaPedido { get; set; }
        public int Estado { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<Factura> Facturas { get; set; }
        public virtual ICollection<PedidoProducto> PedidoProductos { get; set; }
    }
}
