using System;

namespace inmobiliariaCorales.Models.Model
{
    public class Inmueble
    {
        public int Id { get; set; }
        public string? Direccion { get; set; }
        public string? Tipo { get; set; } // Ejemplo: Casa, Apartamento, etc.
        public decimal Precio { get; set; }
        public int Habitaciones { get; set; }
        public int Banos { get; set; }
        public bool Disponible { get; set; }
        public DateTime FechaConstruccion { get; set; }
        public string? Descripcion { get; set; }
        public int PropietarioId { get; set; }
        public Propietario? Propietario { get; set; }
    }
}