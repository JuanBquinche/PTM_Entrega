using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTMicroservicios.Models
{
    
    public class Cliente 
    {
        [Key]
        [Required]
        public int IdCliente {get; set;}

        public int Id {get;set;}
        public string? Contrasena { get; set; }
        public string? Estado { get; set; }
        public string? TipoPersona {get; set;} = "C";
    }
}