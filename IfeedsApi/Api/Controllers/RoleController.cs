using System.Collections.Generic;
using System.Linq;
using IfeedsApi.Config.Database;
using IfeedsApi.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace IfeedsApi.Api.Controllers
{
    [ApiController]
    [Route("/api/roles")]
    public class RoleController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        [HttpGet]
        public ActionResult<ICollection<Role>> Get()
        {
            return _context.Roles.ToList();
        }
    }
}