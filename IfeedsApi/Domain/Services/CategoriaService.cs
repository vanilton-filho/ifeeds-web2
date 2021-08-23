using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using IfeedsApi.Api.Models;
using IfeedsApi.Core.Auth;
using IfeedsApi.Core.Database;
using IfeedsApi.Domain.Models;
using Microsoft.IdentityModel.Tokens;

namespace IfeedsApi.Services
{
    public class CategoriaService
    {
        private readonly ApplicationDbContext _context;

        public CategoriaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Categoria> Listar()
        {
            return _context.Categorias.ToList();
        }

        public Categoria Salvar(Categoria categoria)
        {
            var categoriaEncontrada = _context.Categorias.Where(c => c.Nome == categoria.Nome).FirstOrDefault(); 
            if(categoriaEncontrada != null)
            {
                return null;
            }
            _context.Add(categoria);
            _context.SaveChanges();
            return categoria;
        }

        public Categoria Atualizar(int id, Categoria categoria)
        {   
            var categoriaNome = _context.Categorias.Where(c => c.Nome == categoria.Nome).FirstOrDefault(); 
            var categoriaEncontrada = _context.Categorias.Find(id);

            if(categoriaEncontrada == null || categoriaNome != null)
            {
                return  null;
            }

            categoriaEncontrada.Nome = categoria.Nome;
            categoriaEncontrada.DataAtualizacao = DateTime.UtcNow;
            _context.Update(categoriaEncontrada);
            _context.SaveChanges();
            return categoriaEncontrada;
        }

        public bool Deletar(int id)
        {
            var categoria = _context.Categorias.Find(id);
            var avalicao = _context.Avaliacoes.Where(f => f.CategoriaId == categoria.Id).Count();

            if(categoria == null || avalicao > 0)
            {
                return false;
            }
            _context.Categorias.Remove(categoria);
            _context.SaveChanges();
            return true;
        }

        public Categoria BuscarPorId(int id)
        {
            return _context.Categorias.Find(id);
        }

    }
}