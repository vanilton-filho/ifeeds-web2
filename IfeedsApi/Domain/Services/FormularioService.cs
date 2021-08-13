using System.Linq;
using AutoMapper;
using IfeedsApi.Core.Database;
using IfeedsApi.Domain.Models;

namespace IfeedsApi.Domain.Services
{
    public class FormularioService
    {
        private readonly ApplicationDbContext _context;

        public FormularioService(ApplicationDbContext context){
            _context = context;
        }

        public FormularioAvaliacao Salvar(FormularioAvaliacao formularioAvaliacao, int avaliacaoId, int usuarioId)
        {

            //var qtdAvaliacao = _context.Feedbacks.Where(f => f.AvaliacaoId == avaliacaoId);
            _context.Add(formularioAvaliacao);
            _context.SaveChanges();
            //var media = _context.Feedbacks.Join(
                //formulariosAvaliacoes, 
                //feedback => feedback.AvaliacaoId,
               // formularioAvaliacao => formularioAvaliacao;
           // );
            return formularioAvaliacao;
        }
        //
    }
}