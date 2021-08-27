using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using IfeedsApi.Api.Models;
using IfeedsApi.Core.Database;
using IfeedsApi.Domain.Exceptions;
using IfeedsApi.Domain.Models;
using Microsoft.IdentityModel.Tokens;

namespace IfeedsApi.Services
{
    public class AvaliacaoService
    {
        private readonly ApplicationDbContext _context;

        public AvaliacaoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Avaliacao> Listar()
        {
            return _context.Avaliacoes.ToList();
        }

        public List<Avaliacao> ListarPorCategoria(int categoriaId)
        {
            return _context.Avaliacoes
                .Where(e => e.CategoriaId == categoriaId)
                .ToList();
        }

        public Avaliacao Salvar(Avaliacao avaliacao)
        {
            avaliacao.MediaAvaliacao = 0.0m;
            _context.Avaliacoes.Add(avaliacao);
            _context.SaveChanges();
            return avaliacao;
        }

        public Avaliacao BuscarPorId(int avaliacaoId)
        {
            return _context.Avaliacoes.Find(avaliacaoId);
        }

        public Avaliacao Atualizar(int avaliacaoId, Avaliacao avaliacao)
        {

            var categoria = _context.Categorias.Find(avaliacao.CategoriaId);
            var campus = _context.Campus.Find(avaliacao.CampusId);
            var avaliacaoEncontrada = _context.Avaliacoes.Find(avaliacaoId);
            if (avaliacaoEncontrada == null || categoria == null || campus == null)
            {
                return null;
            }
            avaliacaoEncontrada.Titulo = avaliacao.Titulo;
            avaliacaoEncontrada.CategoriaId = avaliacao.CategoriaId;
            avaliacaoEncontrada.CampusId = avaliacao.CampusId;
            avaliacaoEncontrada.DataAtualizacao = DateTime.UtcNow;
            _context.Update(avaliacaoEncontrada);
            _context.SaveChanges();

            return avaliacaoEncontrada;
        }

        public bool Deletar(int id)
        {
            var avaliacao = _context.Avaliacoes.Find(id);
            var feedback = _context.Feedbacks.Where(f => f.AvaliacaoId == id).Count();

            if (avaliacao == null)
            {
                return false;
            }

            if (feedback > 0)
            {
                throw new EntidadeEmUsoException("O registro não pode ser deletado pois está em uso.");
            }

            _context.Remove(avaliacao);
            _context.SaveChanges();
            return true;
        }

    }
}