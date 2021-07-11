using System.Collections.Generic;
using System.Linq;
using IfeedsApi.Config.Database;
using IfeedsApi.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace IfeedsApi.Api.Controllers
{
    [ApiController]
    [Route("/api/respostas-feedbacks")]
    public class RespostaFeedbackController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        [HttpGet]
        public ActionResult<ICollection<RespostaFeedback>> Get()
        {
            return _context.RespostasFeedbacks.ToList();
        }
    }
}