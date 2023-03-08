using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PTMicroservicios.Data;
using PTMicroservicios.DTOs;

namespace PTMicroservicios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovimientosController : ControllerBase
    {
        private readonly IMovimientoRepo _repository;
        private readonly IMapper _mapper;

        public MovimientosController(IMovimientoRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<MovimientoDTO>> GetMovimientosbyCuenta(int id)
        {
            var movimientos = _repository.GetMovimientosByCuenta(id);

            return Ok(_mapper.Map<IEnumerable<MovimientoDTO>>(movimientos));

        }

        [HttpGet]
        public ActionResult<IEnumerable<MovimientoDTO>> GetMovimientosbyFecha(int id)
        {
            var movimientos = _repository.GetMovimientosByCuenta(id);

            return Ok(_mapper.Map<IEnumerable<MovimientoDTO>>(movimientos));

        }
    }
}