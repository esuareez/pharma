using System;
using System.Collections.Generic;

#nullable disable

namespace Pharma.Models
{
    public partial class ProductoTipoProducto
    {
        public int IdProducto { get; set; }
        public string IdTipo { get; set; }
        public string Descripcion { get; set; }

        public virtual Producto IdProductoNavigation { get; set; }
        public virtual TipoProducto IdTipoNavigation { get; set; }
    }
}
