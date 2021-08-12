using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using IfeedsApi.Api.Models;
using IfeedsApi.Core.Database;
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

    }
}