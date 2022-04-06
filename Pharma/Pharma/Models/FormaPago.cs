using System;
using System.Collections.Generic;

#nullable disable

namespace Pharma.Models
{
    public partial class FormaPago
    {
        public FormaPago()
        {
            Facturas = new HashSet<Factura>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Factura> Facturas { get; set; }
    }
}
