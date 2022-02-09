using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Correo { get; set; }
        [Required]
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        [Required]
        public string Cedula { get; set; }
        [Required]
        public string Password { get; set; }
        public string Ciudad { get; set; }
        public string CodPostal { get; set; }

        public virtual ICollection<ClienteTipoPago> ClienteTipoPagos { get; set; }
    }
}
