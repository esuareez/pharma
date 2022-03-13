using System;
using System.Collections.Generic;

#nullable disable

namespace Pharma.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            ClienteTipoPagos = new HashSet<ClienteTipoPago>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Cedula { get; set; }
        public string Password { get; set; }
        public string Ciudad { get; set; }
        public string CodPostal { get; set; }

        public virtual ICollection<ClienteTipoPago> ClienteTipoPagos { get; set; }
    }
}
