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

    }
}