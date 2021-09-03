using IfeedsApi.Core.Database;
using IfeedsApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IfeedsApi.Domain.Services
{
    public class FeedbackService
    {
        private readonly ApplicationDbContext _context;

        public FeedbackService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Feedback> Listar()
        {
            return _context.Feedbacks.ToList();
        }
        public Feedback Salvar(Feedback feedback)
        {
            var usuario = _context.Usuarios.Find(feedback.UsuarioId);
            if(usuario.RoleId == ((int)TipoRole.ADMIN)){
                return null;
            } 
            using var transaction = _context.Database.BeginTransaction(); // início da transação

            _context.Add(feedback);
            _context.SaveChanges();
            decimal media = GetTotalNotasPorAvaliacao(feedback.AvaliacaoId) / GetTotalFeedbacks(feedback.AvaliacaoId);
            var avaliacao = _context.Avaliacoes.Find(feedback.AvaliacaoId);
            avaliacao.MediaAvaliacao = media;
            _context.Avaliacoes.Update(avaliacao);
            _context.SaveChanges();

            transaction.Commit(); // fim da transação
            return feedback;
        }

        public List<Feedback> ListarFeedbackPorUsuarioId(int usuarioId){
            return _context.Feedbacks.Where(f => f.UsuarioId == usuarioId).ToList();
        }

        private int GetTotalFeedbacks(int avaliacaoId)
        {
            return _context.Feedbacks.Where(f => f.AvaliacaoId == avaliacaoId).Count();

        }

        private decimal GetTotalNotasPorAvaliacao(int avaliacaoId)
        {
            return _context.Feedbacks.Where(f => f.AvaliacaoId == avaliacaoId).Sum(f => f.Nota);

        }

        public Feedback GetPorCodigo(String codigo)
        {
            return _context.Feedbacks.Where(f => f.Codigo.ToString().Equals(codigo)).FirstOrDefault();
        }

        public Feedback GetPorId(int id)
        {
            return _context.Feedbacks.Find(id);
        }

    }
}
