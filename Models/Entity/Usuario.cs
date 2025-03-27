using System;
using System.ComponentModel.DataAnnotations;

namespace inmobiliariaCorales.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }         
        public string? Role { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
    }
}