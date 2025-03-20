using System;
using inmobiliariaCorales.Models.Model;

namespace inmobiliariaCorales.Models
{
    public class Contrato
    {
        public long Id { get; set; }
        public Inquilino? Inquilino { get; set; }
        public Inmueble? Inmueble { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal Monto { get; set; }
    }
}