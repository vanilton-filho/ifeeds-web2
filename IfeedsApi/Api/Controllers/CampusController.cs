using System.Collections.Generic;
using System.Linq;
using IfeedsApi.Core.Database;
using IfeedsApi.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace IfeedsApi.Api.Controllers
{
    [ApiController]
    [Route("/api/campus")]
    public class CampusController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CampusController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<ICollection<Campus>> Get()
        {
            return _context.Campus.ToList();
        }
    }
}