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

            CreateMap<Usuario, UsuarioModelRequest>().ReverseMap();

            CreateMap<Usuario, UsuarioUpdateModelRequest>().ReverseMap();

            CreateMap<Contato, UsuarioModelRequest>().ReverseMap();

            CreateMap<Campus, CampusModel>().ReverseMap();

            CreateMap<Campus, UsuarioModelRequest>().ReverseMap();

            CreateMap<Avaliacao, AvaliacaoModel>().ReverseMap();

            CreateMap<Categoria, CategoriaModel>().ReverseMap();

            CreateMap<Feedback, FeedbackModel>().ReverseMap();

            CreateMap<Usuario, FeedbackModel>().ReverseMap();

            CreateMap<FormularioAvaliacao, FormularioAvaliacaoModel>().ReverseMap();

            CreateMap<Avaliacao, FeedbackAvaliacaoModel>().ReverseMap();
        }
    }
}