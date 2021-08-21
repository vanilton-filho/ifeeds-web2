using System;
using System.Linq;
using IfeedsApi.Core.Database;

namespace IfeedsApi.Domain.Services
{
    public class EstatisticaService
    {
        private readonly ApplicationDbContext _context;

        public EstatisticaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public int QuantidadeFeedbacks() 
        {
            return _context.Feedbacks.Count();
        }

        public int FeedbackSemResposta() 
        {
            return _context.Feedbacks.Where(
                f => f.Status == false
            ).Count();
        }

        public decimal SatisfacaoGeral()
        {
            var quantidadeFeedbacks = QuantidadeFeedbacks();
            var totalNotas = _context.Feedbacks.Sum(tn => tn.Nota);
            decimal satisfacao = (totalNotas / quantidadeFeedbacks);

            return Math.Round(satisfacao, 1); 
        }

        public int FeedbacksRespondidos(int usuarioId) 
        {
            return _context.RespostasFeedbacks.Join(
                _context.Feedbacks,
                resposta => resposta.FeedbackId,
                feedback => feedback.Id,
                (r, f) => new { Resposta = r, Feedback = f}
            ).Where(
                joinTable => 
                joinTable.Resposta.UsuarioId == usuarioId &&
                joinTable.Feedback.Status == true
            ).Count();
        }
    }
}