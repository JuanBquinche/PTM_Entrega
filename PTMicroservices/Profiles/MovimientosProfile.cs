using AutoMapper;
using PTMicroservicios.DTOs;
using PTMicroservicios.Models;

namespace PTMicroservicios.Profiles
{
    public class MovimientosProfile : Profile
    {
        public MovimientosProfile()
        {
            CreateMap<Movimiento, MovimientoDTO>();
            CreateMap<MovimientoDTO, Movimiento>();
            CreateMap<MovimientoCreateDTO, Movimiento>();
        }
    }
}