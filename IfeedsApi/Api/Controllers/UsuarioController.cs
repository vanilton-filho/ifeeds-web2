using System.Collections.Generic;
using System.Linq;
using IfeedsApi.Config.Database;
using IfeedsApi.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace IfeedsApi.Api.Controllers
{
    [ApiController]
    [Route("/api/usuarios")]
    public class UsuarioController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsuarioController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<ICollection<Usuario>> Get()
        {
            return _context.Usuarios.ToList();
        }
    }
}