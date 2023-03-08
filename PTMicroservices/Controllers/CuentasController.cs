using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PTMicroservicios.Data;
using PTMicroservicios.DTOs;
using PTMicroservicios.Models;

namespace PTMicroservicios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuentasController : ControllerBase
    {
        private readonly ICuentaRepo _repository;
        private readonly IMapper _mapper;

        public CuentasController(ICuentaRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CuentaDTO>> GetCuentas()
        {
            var cuentas = _repository.GetAllCuentas();
            return Ok(_mapper.Map<IEnumerable<CuentaDTO>>(cuentas));
        }

        [HttpGet("{id}", Name = "GetCuentaById")]
        public async Task<ActionResult<CuentaDTO>> GetCuentaById(int id)
        {

            var data = await _repository.GetCuentaById(id);
            if (data != null)
            {
                return Ok(_mapper.Map<CuentaDTO>(data));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<CuentaDTO> CreateCuenta(CuentaCreateDTO cuenta)
        {
            var cuentaModel = _mapper.Map<Cuenta>(cuenta);
            _repository.CreateCuenta(cuentaModel);
            _repository.SaveChanges();

            var cuentaDTO = _mapper.Map<CuentaDTO>(cuentaModel);

            return CreatedAtRoute(nameof(GetCuentaById), new { Id = cuentaDTO.IdCuenta }, cuentaDTO);

        }
    }
}