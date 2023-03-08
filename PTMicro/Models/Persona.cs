using System.ComponentModel.DataAnnotations;

namespace PTMicroservicios.Models
{
    public class Persona
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Genero { get; set; }
        public int Edad { get; set; }
        public int Identificacion { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }

        // public Persona(string nombre, string genero, int edad,
        //     int identificacion, string direccion, string telefono)
        // {
        //     Nombre = nombre ?? string.Empty;
        //     Genero = genero ?? string.Empty;
        //     Edad = edad;
        //     Identificacion = identificacion;
        //     Direccion = direccion ?? string.Empty;
        //     Telefono = telefono ?? string.Empty;
        // }
    }
}