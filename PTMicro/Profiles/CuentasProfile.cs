using AutoMapper;
using PTMicroservicios.DTOs;
using PTMicroservicios.Models;

namespace PTMicroservicios.Profiles
{
    public class CuentasProfile : Profile
    {
        public CuentasProfile()
        {
            CreateMap<Cuenta, CuentaDTO>();
            CreateMap<CuentaDTO, Cuenta>();
            CreateMap<CuentaCreateDTO, Cuenta>();
        }
    }
}