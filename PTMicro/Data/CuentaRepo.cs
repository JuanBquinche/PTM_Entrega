using PTMicroservicios.Models;

namespace PTMicroservicios.Data
{

    public class CuentaRepo : ICuentaRepo
    {
        private readonly AppDbContext _context;

        public CuentaRepo(AppDbContext context)
        {
            _context = context;
        }
        public void CreateCuenta(Cuenta cuenta)
        {
            if (cuenta == null)
            {
                throw new ArgumentNullException(nameof(cuenta));
            }
            _context.Cuentas.Add(cuenta);
        }

        public IEnumerable<Cuenta> GetAllCuentas()
        {
            return _context.Cuentas.ToList();
        }

        public async Task<Cuenta?> GetCuentaById(int id)
        {
            var cuenta = await _context.Cuentas.FindAsync( id);
            if (cuenta != null)
            {
                return cuenta;
            }
            return null;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}