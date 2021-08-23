using System;
using System.Collections.Generic;
using System.Linq;
using IfeedsApi.Core.Database;
using IfeedsApi.Domain.Models;

namespace IfeedsApi.Domain.Services
{
    public class CampusService
    {
        private readonly ApplicationDbContext _context;

        public CampusService(ApplicationDbContext context)
        {
            _context = context;
        }
    
         public List<Campus> Listar()
        {
            return _context.Campus.ToList();
        }

        public Campus Salvar(Campus campus)
        {
            var campusEncontrado = _context.Campus.Where(c => c.Nome == campus.Nome).FirstOrDefault(); 
            if(campusEncontrado != null)
            {
                return null;
            }
            _context.Add(campus);
            _context.SaveChanges();
            return campus;
        }

        public Campus Atualizar(int id, Campus campus)
        {   
            var campusNome = _context.Campus.Where(c => c.Nome == campus.Nome).FirstOrDefault(); 
            var campusEncontrado = _context.Campus.Find(id);

            if(campusEncontrado == null || campusNome != null)
            {
                return  null;
            }

            campusEncontrado.Nome = campus.Nome;
            campusEncontrado.DataAtualizacao = DateTime.UtcNow;
            _context.Update(campusEncontrado);
            _context.SaveChanges();
            return campusEncontrado;
        }

        public bool Deletar(int id)
        {
            var campus = _context.Campus.Find(id);
            var avalicao = _context.Avaliacoes.Where(f => f.CampusId == campus.Id).Count();

            if(campus == null || avalicao > 0)
            {
                return false;
            }
            _context.Campus.Remove(campus);
            _context.SaveChanges();
            return true;
        }

        public Campus BuscarPorId(int id)
        {
            return _context.Campus.Find(id);
        }
        
    }
}