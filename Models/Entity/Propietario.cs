using System;
using System.Collections.Generic;
using inmobiliariaCorales.Models.Model;

namespace inmobiliariaCorales.Models
{
    public class Propietario
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public string? Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public List<Inmueble>? Inmuebles { get; set; }
    }
}