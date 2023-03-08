using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace PTMicroservicios.Models{
    public class Cuenta{
        [Key]
        [Required]
        public int IdCuenta { get; set; }
        [Required]
        public int NumeroCuenta { get; set; }   
        [Precision(18, 0)]
        public Decimal SaldoInicial { get; set; }
        public string? Estado { get; set; }
    }
}