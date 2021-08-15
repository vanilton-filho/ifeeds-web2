using System.Collections.Generic;
using AutoMapper;
using IfeedsApi.Api.Models;
using IfeedsApi.Core.Database;
using IfeedsApi.Domain.Models;

namespace IfeedsApi.Api.Mappers
{
    public class RespostaFeedbackMapper
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public RespostaFeedbackMapper(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public RespostaFeedbackModel ToModel(RespostaFeedback respostaFeedback)
        {
            var respostaFeedbackModel = _mapper.Map<RespostaFeedbackModel>(respostaFeedback);
            var feedback = _context.Feedbacks.Find(respostaFeedback.FeedbackId);
            var usuario = _context.Usuarios.Find(respostaFeedback.UsuarioId);

            respostaFeedbackModel.Titulo = feedback.Titulo;
            respostaFeedbackModel.Descricao = feedback.Descricao;
            respostaFeedbackModel.Nota = feedback.Nota;
            respostaFeedbackModel.Usuario = usuario.Matricula;

             
            return respostaFeedbackModel; 
        }

        public List<RespostaFeedbackModel> ToCollection(List<RespostaFeedback> respostas)
        {
            List<RespostaFeedbackModel> respostasModel = new List<RespostaFeedbackModel>();
            respostas.ForEach(r =>
            {
                respostasModel.Add(ToModel(r));
            });
            return respostasModel;
        }
    }
}