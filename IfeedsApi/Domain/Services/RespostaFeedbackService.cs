using System;
using System.Collections.Generic;
using System.Linq;
using IfeedsApi.Core.Database;
using IfeedsApi.Domain.Models;

namespace IfeedsApi.Domain.Services
{
    public class RespostaFeedbackService
    {
        private readonly ApplicationDbContext _context;

        public RespostaFeedbackService( ApplicationDbContext context)
        {
            _context = context;
        }
        public List<RespostaFeedback> Listar()
        {
            return _context.RespostasFeedbacks.ToList();
        }     

        public RespostaFeedback GetPorId(int id)
        {
            return _context.RespostasFeedbacks.Find(id);    
        }   

        public RespostaFeedback Salvar(RespostaFeedback respostaFeedback)
        {
            
            using var transaction = _context.Database.BeginTransaction(); // início da transação

            var feedback = _context.Feedbacks.Find(respostaFeedback.FeedbackId);
            if(feedback.Status)
            {
                return null;
            }

            _context.Add(respostaFeedback);
            _context.SaveChanges();

            feedback.Status = true;
            _context.Update(feedback);
            _context.SaveChanges();

            transaction.Commit(); // fim da transação

            return respostaFeedback;
        }

        public RespostaFeedback Atualizar(int id, RespostaFeedback respostaFeedback)
        {   
            var respostaEncontrada = _context.RespostasFeedbacks.Find(id);

            if(respostaEncontrada == null)
            {
                return  null;
            }

            respostaEncontrada.Resposta = respostaFeedback.Resposta;
            respostaEncontrada.DataAtualizacao = DateTime.UtcNow;
            _context.Update(respostaEncontrada);
            _context.SaveChanges();
            return respostaEncontrada;
        }

        public bool Deletar(int id)
        {
            var resposta = _context.RespostasFeedbacks.Find(id);

            if(resposta == null)
            {
                return false;
            }
            using var transaction = _context.Database.BeginTransaction(); // início da transação

            var feedback = _context.Feedbacks.Where(f => f.Id == resposta.FeedbackId).FirstOrDefault();
            feedback.Status = false;
            _context.Update(feedback);
            _context.SaveChanges();
            _context.Remove(resposta);
            _context.SaveChanges();
            transaction.Commit();
            return true;
        }
    }
}