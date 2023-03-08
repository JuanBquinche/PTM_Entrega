using AutoMapper;
using PTMicroservicios.DTOs;
using PTMicroservicios.Models;

namespace PTMicroservicios.Profiles {
        public class ClientesProfile : Profile
    {
        public ClientesProfile()
        {
            CreateMap<Cliente, ClienteDTO>();
            CreateMap<ClienteDTO, Cliente>();
            CreateMap<ClienteCreateDTO,Cliente>();

        }
    }
}