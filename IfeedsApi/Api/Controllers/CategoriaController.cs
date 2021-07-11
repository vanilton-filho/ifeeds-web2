using System.Collections.Generic;
using System.Linq;
using IfeedsApi.Config.Database;
using IfeedsApi.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace IfeedsApi.Api.Controllers
{
    [ApiController]
    [Route("/api/categorias")]
    public class CategoriaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        [HttpGet]
        public ActionResult<ICollection<Categoria>> Get()
        {
            return _context.Categorias.ToList();
        }
    }
}