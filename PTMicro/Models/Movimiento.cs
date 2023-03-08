using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace PTMicroservicios.Models{
    public class Movimiento{
        [Key]
        [Required]
        public int IdMovimiento { get; set; }   
        [Required]
        public int IdCuenta { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Precision(18, 0)]
        public Decimal Valor { get; set; }
        [Precision(18, 0)]
        public Decimal Saldo { get; set; }
    }
}