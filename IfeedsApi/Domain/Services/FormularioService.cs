using AutoMapper;
using IfeedsApi.Config.Database;
using IfeedsApi.Domain.Models;

namespace IfeedsApi.Domain.Services
{
    public class FormularioService
    {
        private readonly ApplicationDbContext _context;

        public FormularioService(ApplicationDbContext context){
            _context = context;
        }

        public FormularioAvaliacao Salvar(FormularioAvaliacao formularioAvaliacao)
        {
            _context.Add(formularioAvaliacao);
            _context.SaveChanges();
            return formularioAvaliacao;
        }
        
    }
}