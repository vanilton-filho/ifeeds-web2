using AutoMapper;
using IfeedsApi.Api.Models;
using IfeedsApi.Domain.Models;

namespace IfeedsApi.Api.Config
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Usuario, UsuarioModel>().ReverseMap();
            CreateMap<Contato, ContatoModel>().ReverseMap();
            CreateMap<UsuarioModelRequest, UsuarioModel>().ReverseMap();
            CreateMap<UsuarioModelRequest, ContatoModel>().ReverseMap();
            CreateMap<UsuarioModelRequest, Usuario>().ReverseMap();
            CreateMap<UsuarioModelRequest, Contato>().ReverseMap();
        }
    }
}