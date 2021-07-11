using System.Collections.Generic;
using System.Linq;
using IfeedsApi.Config.Database;
using IfeedsApi.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace IfeedsApi.Api.Controllers
{
    [ApiController]
    [Route("/api/contatos")]
    public class ContatoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ContatoController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<ICollection<Contato>> Get()
        {
            return _context.Contatos.ToList();
        }
    }
}