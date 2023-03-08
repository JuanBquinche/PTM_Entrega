using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PTMicroservicios.Data;
using PTMicroservicios.DTOs;
using PTMicroservicios.Models;

namespace PTMicroservicios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private readonly IPersonaRepo _repository;
        private readonly IMapper _mapper;

        public PersonasController(IPersonaRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonaDTO>>> GetAllPersonas()
        {

            var data = await _repository.GetAllPersonas();

            return Ok(_mapper.Map<IEnumerable<PersonaDTO>>(data));
        }

        [HttpGet("{id}", Name = "GetPersonasById")]
        public async Task<ActionResult<PersonaDTO>> GetPersonasById(int id)
        {

            var data = await _repository.GetPersonaById(id);
            if (data != null)
            {
                return Ok(_mapper.Map<PersonaDTO>(data));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<PersonaDTO> CreatePersona(PersonaCreateDTO persona)
        {
            var personaModel = _mapper.Map<Persona>(persona);
            _repository.CreatePersona(personaModel);
            _repository.SaveChanges();

            var personaDTO = _mapper.Map<PersonaDTO>(personaModel);

            return CreatedAtRoute(nameof(GetPersonasById), new { Id = personaDTO.Id}, personaDTO );

        }

        [HttpPut]
        public ActionResult UpdatePersona(PersonaDTO persona)
        {
            // var pesonalModel = _mapper.Map<Persona>(persona);
            // _repository.GetPersonaById();

            // _repository.SaveChanges();

            return Ok();

        }
    }
}