using System.Collections.Generic;
using AutoMapper;
using IfeedsApi.Api.Models;
using IfeedsApi.Core.Database;
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
            var totalFeedbacks = _context.Feedbacks.Where(f => f.AvaliacaoId == avaliacao.Id).Count();


            //Anexando Campus e Categoria ao model
            avaliacaoModel.Campus = campus.Nome;
            avaliacaoModel.Categoria = categoria.Nome;
            avaliacaoModel.TotalFeedbacks = totalFeedbacks;

            return avaliacaoModel;
        }

        public List<AvaliacaoModel> ToCollection(List<Avaliacao> avaliacoes)
        {
            List<AvaliacaoModel> avaliacoesModel = new List<AvaliacaoModel>();
            avaliacoes.ForEach(a =>
            {
                avaliacoesModel.Add(ToModel(a));
            });
            return avaliacoesModel;
        }

    }
}