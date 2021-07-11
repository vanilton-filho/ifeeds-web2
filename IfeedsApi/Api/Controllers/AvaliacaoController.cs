using System.Collections.Generic;
using System.Linq;
using IfeedsApi.Config.Database;
using IfeedsApi.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace IfeedsApi.Api.Controllers
{
    [ApiController]
    [Route("/api/avaliacoes")]
    public class AvaliacaoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AvaliacaoController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<ICollection<Avaliacao>> Get()
        {
            return _context.Avaliacoes.ToList();
        }
    }
}