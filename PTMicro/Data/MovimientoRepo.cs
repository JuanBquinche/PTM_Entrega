using System.Linq;
using PTMicroservicios.Models;

namespace PTMicroservicios.Data
{
    public class MovimientoRepo : IMovimientoRepo
    {
        private readonly AppDbContext _context;

        public MovimientoRepo(AppDbContext context)
        {
            _context = context;
        }

        public void CreateMovimiento(Movimiento movimiento)
        {
            if (movimiento == null){
                throw new ArgumentNullException(nameof(movimiento));
            }
            _context.Movimientos.Add(movimiento);
        }

        public IEnumerable<Movimiento> GetAllMovimientos()
        {
            return _context.Movimientos.ToList();
        }

        public async Task<Movimiento?> GetMovimientoById(int id)
        {
            var movimiento = await _context.Movimientos.FindAsync(id);
            if (movimiento != null)
            {
                return movimiento;
            }
            return null;
        }

        public IEnumerable<Movimiento> GetMovimientosByCuenta(int idCuenta){
            return _context.Movimientos.Where(m => m.IdCuenta == idCuenta).ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}