namespace PTMicroservicios.DTOs
{
    public class MovimientoCreateDTO
    {
        public int IdCuenta { get; set; }
        public DateTime Fecha { get; set; }
        public Decimal Valor { get; set; }
        public Decimal Saldo { get; set; }
    }
}