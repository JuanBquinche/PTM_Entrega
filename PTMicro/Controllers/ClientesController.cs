using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PTMicroservicios.Data;
using PTMicroservicios.DTOs;
using PTMicroservicios.Models;

namespace PTMicroservicios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteRepo _repository;
        private readonly IMapper _mapper;
        private readonly IPersonaRepo _repoPersonas;

        public ClientesController(IClienteRepo repository, IMapper mapper, IPersonaRepo repoPersonas)
        {
            _repository = repository;
            _mapper = mapper;
            _repoPersonas = repoPersonas;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ClienteDTO>> GetClientes()
        {
            var clientes = _repository.GetAllClientes();
            return Ok(_mapper.Map<IEnumerable<ClienteDTO>>(clientes));
        }

        [HttpGet("{id}", Name = "GetClienteById")]
        public async Task<ActionResult<ClienteDTO>> GetClienteById(int id)
        {

            var data = await _repository.GetClienteById(id);
            if (data != null)
            {
                return Ok(_mapper.Map<ClienteDTO>(data));
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<ClienteDTO?>> CreateCliente(ClienteCreateDTO cliente)
        {
            await _repository.CreateCliente(cliente);
            var clienteDTO = _mapper.Map<ClienteDTO>(cliente);

            return CreatedAtRoute(nameof(GetClienteById), new { Id = clienteDTO.IdCliente }, clienteDTO);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteCliente(int id)
        {
            var data = await _repository.GetClienteById(id);
            if (data != null)
            {
                if (await _repository.Delete(id))
                {
                    return Ok();
                }
                else
                {
                    return NotFound(new { message = "Not completed" });
                }
            }
            return NotFound();
        }
    }
}