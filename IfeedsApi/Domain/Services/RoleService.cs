using System;
using System.Collections.Generic;
using System.Linq;
using IfeedsApi.Core.Database;
using IfeedsApi.Domain.Models;

namespace IfeedsApi.Domain.Services
{
    public class RoleService
    {
        private readonly ApplicationDbContext _context;

        public RoleService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Role> Listar()
        {
            return _context.Roles.ToList();
        }

        public Role Salvar(Role role)
        {
            var roleEncontrada = _context.Roles.Where(r => r.Tipo == role.Tipo).FirstOrDefault(); 
            if(roleEncontrada != null)
            {
                return null;
            }
            _context.Add(role);
            _context.SaveChanges();
            return role;
        }

        public Role Atualizar(int id, Role role)
        {   
            var roleEncontrada = _context.Roles.Find(id);
            var roleTipo = _context.Roles.Where(r => r.Tipo == role.Tipo).FirstOrDefault(); 

            if(roleEncontrada == null || roleTipo != null)
            {
                return  null;
            }

            roleEncontrada.Tipo = role.Tipo;
            roleEncontrada.DataAtualizacao = DateTime.UtcNow;
            _context.Update(roleEncontrada);
            _context.SaveChanges();
            return roleEncontrada;
        }

        public bool Deletar(int id)
        {
            var role = _context.Roles.Find(id);
            var usuario = _context.Usuarios.Where(u => u.RoleId == id).Count();

            if(role == null || usuario > 0)
            {
                return false;
            }
            _context.Remove(role);
            _context.SaveChanges();
            return true;
        }
        
        public Role BuscarPorId(int id)
        {
            return _context.Roles.Find(id);
        }

    }
}