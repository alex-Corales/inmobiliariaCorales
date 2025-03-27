namespace inmobiliariaCorales.Models
{
    public class Pago
    {
        public int Id { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public string? MetodoPago { get; set; }
        public int ContratoId { get; set; }
        public Contrato? Contrato { get; set; }
        
    }
}