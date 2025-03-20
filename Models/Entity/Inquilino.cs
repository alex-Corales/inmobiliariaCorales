using System;
using inmobiliariaCorales.Models.Model;

namespace inmobiliariaCorales.Models
{
    public class Inquilino
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public string? Direccion { get; set; }
        public string? Garantia { get; set; }
        public string? NombreGarante { get; set; }
        public string? TelefonoGarante { get; set; }
        public Inmueble? Inmueble { get; set; }
    }
}