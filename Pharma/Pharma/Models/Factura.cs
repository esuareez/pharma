using System;
using System.Collections.Generic;

#nullable disable

namespace Pharma.Models
{
    public partial class Factura
    {
        public int IdFactura { get; set; }
        public double? Impuesto { get; set; }
        public double? Descuento { get; set; }
        public double Monto { get; set; }
        public DateTime FechaFactura { get; set; }
        public int IdPedido { get; set; }
        public int IdTipoPago { get; set; }

        public virtual Pedido IdPedidoNavigation { get; set; }
        public virtual TipoPago IdTipoPago1 { get; set; }
        public virtual FormaPago IdTipoPagoNavigation { get; set; }
    }
}
