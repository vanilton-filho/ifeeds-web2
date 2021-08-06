using AutoMapper;
using IfeedsApi.Api.Models;
using IfeedsApi.Config.Database;
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

            var formulario = _context.FormulariosAvaliacaos.Find(feedback.FormularioAvaliacaoId);
            var usuario = _context.Usuarios.Find(feedback.UsuarioId);
            var avaliacao = _context.Avaliacoes.Find(feedback.AvaliacaoId);
            var campus = _context.Campus.Find(feedback.Avaliacao.CampusId);
            var respostaFeedback = _context.RespostasFeedbacks.Find(feedback.Id);
            

            feedbackModel.Formulario = _mapper.Map<FormularioAvaliacaoModel>(formulario);
            feedbackModel.Matricula = usuario.Matricula;
            feedbackModel.Avaliacao = _mapper.Map<FeedbackAvaliacaoModel>(avaliacao);
            feedbackModel.Nota = formulario.QuantidadeEstrelas;
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
