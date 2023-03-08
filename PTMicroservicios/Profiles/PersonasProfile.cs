using AutoMapper;
using PTMicroservicios.DTOs;
using PTMicroservicios.Models;

namespace PTMicroservicios.Profiles
{
    public class PersonasProfile : Profile
    {
        public PersonasProfile()
        {
            CreateMap<Persona, PersonaDTO>();
            CreateMap<PersonaDTO, Persona>();
            CreateMap<PersonaCreateDTO,Persona>();
        }
    }
}