namespace PTMicroservicios.DTOs
{
    public class CuentaDTO
    {
        public int IdCuenta { get; set; }

        public int NumeroCuenta { get; set; }
        public Decimal SaldoInicial { get; set; }
        public string? Estado { get; set; }
    }
}