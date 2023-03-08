using System.Collections.Generic;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PTMicroservicios.DTOs;
using PTMicroservicios.Models;

namespace PTMicroservicios.Data
{
    public class ClienteRepo : IClienteRepo
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public ClienteRepo(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ClienteDTO> CreateCliente(ClienteCreateDTO clienteCreateDTO)
        {
            try
            {
                var cliente = _mapper.Map<Cliente>(clienteCreateDTO);
                
                if (cliente == null)
                {
                    throw new ArgumentNullException(nameof(cliente));
                }
                _context.Clientes.Add(cliente);
                await _context.SaveChangesAsync();
                return _mapper.Map<ClienteDTO>(cliente);
            }
            catch (DbUpdateException ex)
            {
                throw new Exception($"-->error de DB: {ex.Message}");
            }
            catch (System.Exception ex)
            {
                throw new Exception($"----> Se ha presentado un error: {ex.Message}");
            }
        }

        public async Task<IEnumerable<ClienteDTO?>> GetAllClientes()
        {
            return await Task.Run(
                () => _mapper.Map<IEnumerable<ClienteDTO>>(
                    _context.Clientes.ToList()).ToList()
                    );
        }

        public async Task<ClienteDTO?> GetClienteById(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente != null)
            {
                return _mapper.Map<ClienteDTO>(cliente);
            }
            return null;
        }

        public async Task<bool> SaveChanges()
        {
            return await Task.Run(() =>  _context.SaveChanges() >= 0);
        }

        public async Task<bool> Delete(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente !=null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;

        }
    }
}