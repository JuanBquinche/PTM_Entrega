using PTMicroservicios.Models;

namespace PTMicroservicios.Data
{
    public interface ICuentaRepo
    {

        bool SaveChanges();

        IEnumerable<Cuenta> GetAllCuentas();
        Task<Cuenta?> GetCuentaById(int id);
        void CreateCuenta(Cuenta cuenta);
    }
}