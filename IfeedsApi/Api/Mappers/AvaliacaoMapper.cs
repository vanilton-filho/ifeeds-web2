using System.Collections.Generic;
using AutoMapper;
using IfeedsApi.Api.Models;
using IfeedsApi.Config.Database;
using IfeedsApi.Domain.Models;
using System.Linq;

namespace IfeedsApi.Api.Mappers
{
    public class AvaliacaoMapper
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public AvaliacaoMapper(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public AvaliacaoModel ToModel(Avaliacao avaliacao)
        {
            var avaliacaoModel = _mapper.Map<AvaliacaoModel>(avaliacao);

            var categoria = _context.Categorias.Find(avaliacao.CategoriaId);
            var campus = _context.Campus.Find(avaliacao.CampusId);

            // Anexando Campus e Categoria ao model
            avaliacaoModel.Campus = campus.Nome;
            avaliacaoModel.Categoria = categoria.Nome;

            return avaliacaoModel;
        }

        public List<AvaliacaoModel> ToCollection(List<Avaliacao> avaliacaos)
        {
            var avaliacoesModel = _mapper.Map<List<AvaliacaoModel>>(avaliacaos);
            avaliacaos.ForEach(a =>
         {
             var campus = _context.Campus.Find(a.CampusId);
             var categoria = _context.Categorias.Find(a.CategoriaId);

             var avaliacaoModel = avaliacoesModel.Where(e => e.Titulo == a.Titulo);
             avaliacaoModel.Single().Categoria = categoria.Nome;
             avaliacaoModel.Single().Campus = campus.Nome;
         });
            return avaliacoesModel;
        }

    }
}