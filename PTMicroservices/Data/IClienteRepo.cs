using PTMicroservicios.DTOs;
using PTMicroservicios.Models;

namespace PTMicroservicios.Data
{
    public interface IClienteRepo
    {

        Task<bool> SaveChanges();

        Task<IEnumerable<ClienteDTO?>> GetAllClientes();
        Task<ClienteDTO?> GetClienteById(int id);
        Task<bool> Delete(int id);
        Task<ClienteDTO> CreateCliente(ClienteCreateDTO cliente);
    }
}