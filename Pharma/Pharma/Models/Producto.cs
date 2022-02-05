using System;
using System.Collections.Generic;

#nullable disable

namespace Pharma.Models
{
    public partial class Producto
    {
        public Producto()
        {
            Pedidos = new HashSet<Pedido>();
            ProductoTipoProductos = new HashSet<ProductoTipoProducto>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string TipoProducto { get; set; }
        public int Cantidad { get; set; }
        public double PrecioCompra { get; set; }
        public double? PrecioVenta { get; set; }
        public DateTime? FechaVencimiento { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }
        public virtual ICollection<ProductoTipoProducto> ProductoTipoProductos { get; set; }
    }
}
