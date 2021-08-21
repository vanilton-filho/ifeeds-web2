using AutoMapper;
using IfeedsApi.Api.Models;
using IfeedsApi.Core.Database;
using IfeedsApi.Domain.Services;

namespace IfeedsApi.Api.Mappers
{
    public class EstatisticaMapper
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly EstatisticaService _estatisticaService;

        public EstatisticaMapper(ApplicationDbContext context, IMapper mapper, EstatisticaService estatisticaService)
        {
            _context = context;
            _mapper = mapper;
            _estatisticaService = estatisticaService;
        }

        public EstatisticaModel ToModel(int usuarioId)
        {
            var estatisticasModel = new EstatisticaModel();
            estatisticasModel.FeedbacksRespondidos = _estatisticaService.FeedbacksRespondidos(usuarioId);
            estatisticasModel.FeedbacksSemResposta = _estatisticaService.FeedbackSemResposta();
            estatisticasModel.QuantidadeFeedbacks = _estatisticaService.QuantidadeFeedbacks();
            estatisticasModel.SatisfacaoGeral = _estatisticaService.SatisfacaoGeral();


            return estatisticasModel;
        }



    }
}