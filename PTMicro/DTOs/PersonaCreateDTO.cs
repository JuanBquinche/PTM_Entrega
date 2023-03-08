using System.ComponentModel.DataAnnotations;

namespace PTMicroservicios.DTOs
{

    public class PersonaCreateDTO
    {
        [Required]
        public string? Nombre { get; set; }

        public string? Genero { get; set; }
        public int Edad { get; set; }

        [Required]
        public int Identificacion { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
    }
}