using System;
using System.Collections.Generic;

namespace Pharma.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Pedidos = new HashSet<Pedido>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public string Cedula { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? Ciudad { get; set; }
        public string? CodPostal { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
