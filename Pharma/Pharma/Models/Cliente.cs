using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pharma.Models
{
    public class Cliente
    {
        [Key] // Primary Key. No se puede repetir
        public int Id { get; set; }
        [Required(ErrorMessage = "La cédula es obligatoria.")] // Required es para campos que no pueden quedar vacios.
        [StringLength(11, ErrorMessage = "La cédula debe tener un tamaño máximo de {1} caracteres ")]
        [Display(Name = "Cédula")]
        public string Cedula { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio.")] // Required es para campos que no pueden quedar vacios.
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El apellido es obligatorio.")]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El correo es obligatorio.")]
        public string Correo { get; set; }
        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        public string Passw { get; set; }
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "El telefono es obligatorio")]
        [Display(Name = "Telefono")]
        public string Telefono { get; set; }
    }
}
