using System;
using System.Collections.Generic;

namespace Pharma.Models
{
    public partial class Producto
    {
        public Producto()
        {
            OrdenProductos = new HashSet<OrdenProducto>();
            PedidoProductos = new HashSet<PedidoProducto>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string TipoProducto { get; set; } = null!;
        public int Cantidad { get; set; }
        public double PrecioCompra { get; set; }
        public double PrecioVenta { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public byte[]? Img { get; set; }
        public int Estado { get; set; }
        public string? Laboratorio { get; set; }
        public int? Itbis { get; set; }

        public virtual ICollection<OrdenProducto> OrdenProductos { get; set; }
        public virtual ICollection<PedidoProducto> PedidoProductos { get; set; }
    }
}
