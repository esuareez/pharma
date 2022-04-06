﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Pharma.Models
{
    public partial class TipoPago
    {
        public TipoPago()
        {
            Facturas = new HashSet<Factura>();
        }

        public int IdPago { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Factura> Facturas { get; set; }
    }
}
