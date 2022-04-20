using System;
using System.Collections.Generic;

#nullable disable

namespace Pharma.Models
{
    public partial class TipoProducto
    {
        public TipoProducto()
        {
            ProductoTipoProductos = new HashSet<ProductoTipoProducto>();
        }

        public string Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<ProductoTipoProducto> ProductoTipoProductos { get; set; }
    }
}
