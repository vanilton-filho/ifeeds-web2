using System.Collections.Generic;
using System.Linq;
using IfeedsApi.Api.Mappers;
using IfeedsApi.Api.Models;
using IfeedsApi.Core.Database;
using IfeedsApi.Domain.Models;
using IfeedsApi.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace IfeedsApi.Api.Controllers
{
    [ApiController]
    [Route("/api/feedbacks")]
    public class FeedbackController : ControllerBase
    {
        private readonly FeedbackService _feedbackService;
        private readonly FeedbackMapper _feedbackMapper;

        public FeedbackController(FeedbackService feedbackService, FeedbackMapper feedbackMapper)
        {
            _feedbackService = feedbackService;
            _feedbackMapper = feedbackMapper;
        }
        
        [HttpGet]
        public ActionResult<ICollection<FeedbackModel>> Get()
        {
            var feedbacks = _feedbackService.Listar();
            return _feedbackMapper.ToCollection(feedbacks);
        }
    }
}