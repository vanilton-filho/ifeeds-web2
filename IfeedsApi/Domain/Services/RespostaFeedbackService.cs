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
            _context.Add(respostaFeedback);
            _context.SaveChanges();

            return respostaFeedback;
        }
    }
}