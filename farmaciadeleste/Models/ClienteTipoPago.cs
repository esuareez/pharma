using System;
using System.Collections.Generic;

#nullable disable

namespace Pharma.Models
{
    public partial class ClienteTipoPago
    {
        public int IdPago { get; set; }
        public string Descripcion { get; set; }
        public int IdCliente { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual TipoPago IdPagoNavigation { get; set; }
    }
}
