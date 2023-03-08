using PTMicroservicios.Models;

namespace PTMicroservicios.Data
{
    public interface IPersonaRepo
    {
        Task<bool> SaveChanges();
        
        Task<IEnumerable<Persona>> GetAllPersonas();
        Task<Persona?> GetPersonaById(int id);
        Task CreatePersona(Persona persona);
        
    }
}