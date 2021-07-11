using System.Collections.Generic;
using System.Linq;
using IfeedsApi.Config.Database;
using IfeedsApi.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace IfeedsApi.Api.Controllers
{
    [ApiController]
    [Route("/api/feedbacks")]
    public class FeedbackController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        [HttpGet]
        public ActionResult<ICollection<Feedback>> Get()
        {
            return _context.Feedbacks.ToList();
        }
    }
}