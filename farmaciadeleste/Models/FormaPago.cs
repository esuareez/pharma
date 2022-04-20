using System;
using System.Collections.Generic;

namespace Pharma.Models
{
    public partial class FormaPago
    {
        public FormaPago()
        {
            Facturas = new HashSet<Factura>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<Factura> Facturas { get; set; }
    }
}
