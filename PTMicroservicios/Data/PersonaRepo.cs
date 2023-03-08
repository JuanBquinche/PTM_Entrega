using PTMicroservicios.Models;

namespace PTMicroservicios.Data
{
    public class PersonaRepo : IPersonaRepo
    {
        private readonly AppDbContext _context;

        public PersonaRepo(AppDbContext context)
        {
            _context = context;
        }
        public async Task CreatePersona(Persona persona)
        {
            if (persona == null)
            {
                throw new ArgumentNullException(nameof(persona));
            }
            await _context.Personas.AddAsync(persona);
        }

        public async Task<IEnumerable<Persona>> GetAllPersonas()
        {
            return await Task.Run(() =>_context.Personas.ToList());
        }

        public async Task<Persona?> GetPersonaById(int id)
        {
            var persona = await _context.Personas.FindAsync(id);
            if (persona != null)
                return persona;
            return null;
        }

        public async Task<bool> SaveChanges()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }
    }
}