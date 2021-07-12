using System.Collections.Generic;
using System.Linq;
using IfeedsApi.Config.Database;
using IfeedsApi.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace IfeedsApi.Api.Controllers
{
    [ApiController]
    [Route("/api/formularios-avaliacoes")]
    public class FormularioAvaliacaoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FormularioAvaliacaoController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<ICollection<FormularioAvaliacao>> Get()
        {
            return _context.FormulariosAvaliacaos.ToList();
        }
    }
}