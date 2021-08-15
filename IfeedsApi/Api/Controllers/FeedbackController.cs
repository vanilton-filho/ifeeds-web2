using System.Collections.Generic;
using System.Linq;
using AutoMapper;
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
        private readonly IMapper _mapper;


        public FeedbackController(FeedbackService feedbackService, FeedbackMapper feedbackMapper, IMapper mapper)
        {
            _feedbackService = feedbackService;
            _feedbackMapper = feedbackMapper;
            _mapper = mapper;
        }
        
        [HttpGet]
        public ActionResult<ICollection<FeedbackModel>> Get()
        {
            var feedbacks = _feedbackService.Listar();
            return _feedbackMapper.ToCollection(feedbacks);
        }

        [HttpGet("{codigo}", Name = "GetPorCodigo")]
        public ActionResult<FeedbackModel> GetPorCodigo(string codigo)
        {
            var feedback = _feedbackService.GetPorCodigo(codigo);
            if(feedback == null)
            {
                return NotFound();
            } 

            var feedbackModel = _feedbackMapper.ToModel(feedback);
            return new OkObjectResult(feedbackModel);
        }

        [HttpPost]
        public ActionResult<FeedbackModel> Post([FromBody] FeedbaackModelRequest request)
        {
            var feedback = _mapper.Map<Feedback>(request);
            var feedbackSalvo = _feedbackService.Salvar(feedback);
            var feedbackModel = _feedbackMapper.ToModel(feedbackSalvo);
            return  new CreatedAtRouteResult("GetPorCodigo", new {codigo = feedbackSalvo.Codigo}, feedbackModel);
        }
    }
}