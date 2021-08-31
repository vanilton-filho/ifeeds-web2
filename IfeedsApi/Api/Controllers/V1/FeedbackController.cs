using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using AutoMapper;
using IfeedsApi.Api.Mappers;
using IfeedsApi.Api.Models;
using IfeedsApi.Core.Database;
using IfeedsApi.Domain.Models;
using IfeedsApi.Domain.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IfeedsApi.Api.Controllers.V1
{
    [ApiController]
    [Route("/v1/api/feedbacks")]
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

        [Authorize(Roles = "ADMIN")]
        [HttpGet]
        public ActionResult<ICollection<FeedbackModel>> Get()
        {
            var feedbacks = _feedbackService.Listar();
            return _feedbackMapper.ToCollection(feedbacks);
        }

        [Authorize(Roles = "ADMIN,USER")]
        [HttpGet("usuario/{id}")]
        public ActionResult<ICollection<FeedbackModel>> GetFeedbackPorUsuarioId(int id)
        {
            var feedbacks = _feedbackService.ListarFeedbackPorUsuarioId(id);
            if(feedbacks.Count() == 0 && HttpContext.User.HasClaim("id", id.ToString())) 
            {
                return NotFound();
            }
            else if (HttpContext.User.HasClaim("id", id.ToString()))
            {
                return _feedbackMapper.ToCollection(feedbacks);
            }
            return new UnauthorizedResult();
        }

        [Authorize(Roles = "ADMIN,USER")]
        [HttpGet("{codigo}", Name = "GetPorCodigo")]
        public ActionResult<FeedbackModel> GetPorCodigo(string codigo)
        {
            var feedback = _feedbackService.GetPorCodigo(codigo);

            var feedbackModel = _feedbackMapper.ToModel(feedback);

            if (feedback == null)
            {
                return NotFound();
            }

            // O ADMIN terá acesso a qualquer feedback por código
            if (feedback != null && HttpContext.User.HasClaim(ClaimTypes.Role, "ADMIN"))
            {
                return new OkObjectResult(feedbackModel);
            } // O USER vai ter acesso apenas ao feedback feito por ele
            else if (feedback != null &&
                    HttpContext.User.HasClaim("matricula", feedback.Usuario.Matricula))
            {
                return new OkObjectResult(feedbackModel);

            }

            return new UnauthorizedResult();

        }

        [Authorize(Roles = "ADMIN,USER")]
        [HttpPost]
        public ActionResult<FeedbackModel> Post([FromBody] FeedbaackModelRequest request)
        {
            var feedback = _mapper.Map<Feedback>(request);
            var feedbackSalvo = _feedbackService.Salvar(feedback);
            var feedbackModel = _feedbackMapper.ToModel(feedbackSalvo);
            return new CreatedAtRouteResult("GetPorCodigo", new { codigo = feedbackSalvo.Codigo }, feedbackModel);
        }
    }
}