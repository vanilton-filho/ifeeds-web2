using System;
using System.Collections.Generic;
using System.Linq;
using IfeedsApi.Core.Database;
using IfeedsApi.Domain.Models;

namespace IfeedsApi.Domain.Services
{
    public class ContatoService
    {
        private readonly ApplicationDbContext _context;

        public ContatoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Contato> Listar()
        {
            return _context.Contatos.ToList();
        }

         public Contato Salvar(Contato contato)
        {
            var contatoEncontrado = _context.Contatos.Where(c => c.Id == contato.Id).FirstOrDefault(); 
            if(contatoEncontrado != null)
            {
                return null;
            }
            _context.Add(contato);
            _context.SaveChanges();
            return contato;
        }

        public Contato Atualizar(int id, Contato contato)
        {   
            var contatoEmail = _context.Contatos.Where(c => c.Email == contato.Email && c.Telefone == contato.Telefone).FirstOrDefault(); 
            var contatoEncontrado = _context.Contatos.Find(id);

            if(contatoEncontrado == null || contatoEmail != null)
            {
                return  null;
            }

            contatoEncontrado.Email = contato.Email;
            contatoEncontrado.Telefone = contato.Telefone;
            contatoEncontrado.DataAtualizacao = DateTime.UtcNow;
            _context.Update(contatoEncontrado);
            _context.SaveChanges();
            return contatoEncontrado;
        }

        public bool Deletar(int id)
        {
            var contato = _context.Contatos.Find(id);
            var usuario = _context.Usuarios.Where(u => u.ContatoId == id).Count();

            if(contato == null || usuario > 0)
            {
                return false;
            }
            _context.Remove(contato);
            _context.SaveChanges();
            return true;
        }

        public Contato BuscarPorId(int id)
        {
            return _context.Contatos.Find(id);
        }
    }
}