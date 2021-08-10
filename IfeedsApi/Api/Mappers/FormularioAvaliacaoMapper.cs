using AutoMapper;
using IfeedsApi.Api.Models;
using IfeedsApi.Config.Database;
using IfeedsApi.Domain.Models;

namespace IfeedsApi.Api.Mappers
{
    public class FormularioAvaliacaoMapper
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public FormularioAvaliacaoMapper(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper  = mapper;
        }
        

        
    }
}