using PTMicroservicios.Models;

namespace PTMicroservicios.Data
{
    public interface IMovimientoRepo
    {

        bool SaveChanges();

        IEnumerable<Movimiento> GetAllMovimientos();
        Task<Movimiento?> GetMovimientoById(int id);
        IEnumerable<Movimiento> GetMovimientosByCuenta(int idCuenta);
        void CreateMovimiento(Movimiento movimiento);
    }
}