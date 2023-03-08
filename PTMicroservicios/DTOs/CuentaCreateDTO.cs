using System.ComponentModel.DataAnnotations;

namespace PTMicroservicios.DTOs
{

    public class CuentaCreateDTO
    {
        public int NumeroCuenta { get; set; }
        public Decimal SaldoInicial { get; set; }
        public string? Estado { get; set; }

    }
}