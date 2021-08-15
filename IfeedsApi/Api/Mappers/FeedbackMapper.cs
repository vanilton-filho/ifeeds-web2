using AutoMapper;
using IfeedsApi.Api.Models;
using IfeedsApi.Core.Database;
using IfeedsApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IfeedsApi.Api.Mappers
{
    public class FeedbackMapper
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public FeedbackMapper(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public FeedbackModel ToModel(Feedback feedback)
        {
            var feedbackModel = _mapper.Map<FeedbackModel>(feedback);

            var usuario = _context.Usuarios.Find(feedback.UsuarioId);
            var avaliacao = _context.Avaliacoes.Find(feedback.AvaliacaoId);
            var campus = _context.Campus.Find(avaliacao.CampusId);
            var respostaFeedback = _context.RespostasFeedbacks.Find(feedback.Id);
            

            feedbackModel.Matricula = usuario.Matricula;
            feedbackModel.Avaliacao = _mapper.Map<FeedbackAvaliacaoModel>(avaliacao);
            feedbackModel.Nota = feedback.Nota;
            feedbackModel.Campus = campus.Nome;
            feedbackModel.Resposta = respostaFeedback is null ? null : respostaFeedback.Resposta;
            feedbackModel.Status = respostaFeedback is not null && respostaFeedback.Status;
            feedbackModel.DataResposta = respostaFeedback is null ? null : respostaFeedback.DataCriacao;

            return feedbackModel;
        }

        public List<FeedbackModel> ToCollection(List<Feedback> feedbacks)
        {
            List<FeedbackModel> feedbackModels = new List<FeedbackModel>();
            feedbacks.ForEach(f =>
            {
                feedbackModels.Add(ToModel(f));
            });
            return feedbackModels;
        }
    }
}
