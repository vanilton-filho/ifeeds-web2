using System;
using System.Collections.Generic;
using System.Security.Claims;
using AutoMapper;
using IfeedsApi.Api.Mappers;
using IfeedsApi.Api.Models;
using IfeedsApi.Domain.Models;
using IfeedsApi.Domain.Services;
using IfeedsApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IfeedsApi.Api.Controllers.V1
{
    [ApiController]
    [Route("/v1/api/respostas-feedbacks")]
    public class RespostaFeedbackController : ControllerBase
    {
        private readonly RespostaFeedbackService _respostaFeedbackService;
        private readonly RespostaFeedbackMapper _respostaFeedbackMapper;
        private readonly FeedbackService _feedbackService;

        private readonly UsuarioService _usuarioService;

        private readonly IMapper _mapper;


        public RespostaFeedbackController(RespostaFeedbackService respostaFeedbackService, RespostaFeedbackMapper respostaFeedbackMapper, FeedbackService feedbackService, UsuarioService usuarioService, IMapper mapper)
        {
            _respostaFeedbackService = respostaFeedbackService;
            _respostaFeedbackMapper = respostaFeedbackMapper;
            _feedbackService = feedbackService;
            _usuarioService = usuarioService;
            _mapper = mapper;
        }

        [Authorize(Roles = "ADMIN")]
        [HttpGet]
        public ActionResult<ICollection<RespostaFeedbackModel>> Get()
        {
            var respostas = _respostaFeedbackService.Listar();

            return _respostaFeedbackMapper.ToCollection(respostas);
        }

        [Authorize(Roles = "ADMIN,USER")]
        [HttpGet("{id}", Name = "GetRespostaId")]
        public ActionResult<RespostaFeedbackModel> GetPorId(int id)
        {
            var respostaFeedback = _respostaFeedbackService.GetPorId(id);

            if (respostaFeedback == null)
            {
                return NotFound();
            }

            var feedback = _feedbackService.GetPorId(respostaFeedback.Id);
            var usuario = _usuarioService.GetPorId(feedback.UsuarioId);
            var respostaFeedbackModel = _respostaFeedbackMapper.ToModel(respostaFeedback);
            if (HttpContext.User.HasClaim(ClaimTypes.Role, "ADMIN"))
            {
                return new OkObjectResult(respostaFeedbackModel);
            }
            else if (HttpContext.User.HasClaim("matricula", usuario.Matricula))
            {
                return new OkObjectResult(respostaFeedbackModel);

            }

            return new UnauthorizedResult();

        }

        [Authorize(Roles = "ADMIN")]
        [HttpPost]
        public ActionResult Post([FromBody] RespostaFeedbackModelRequest request)
        {
            var resposta = _mapper.Map<RespostaFeedback>(request);
            var respostaSalva = _respostaFeedbackService.Salvar(resposta);
            if (respostaSalva == null)
            {
                return BadRequest();
            }

            var respostaFeedbackModel = _respostaFeedbackMapper.ToModel(respostaSalva);
            return new CreatedAtRouteResult("GetRespostaId", new { id = respostaSalva.Id }, respostaFeedbackModel);
        }

        [Authorize(Roles = "ADMIN")]
        [HttpPut("{id}")]
        public ActionResult<ContatoModel> Put(int id, [FromBody] RespostaFeedbackModelUpdateRequest request)
        {
            var resposta = _mapper.Map<RespostaFeedback>(request);
            var respostaAtualizada = _respostaFeedbackService.Atualizar(id, resposta);

            if (respostaAtualizada == null)
            {
                return NotFound();
            }
            var respostaModel = _respostaFeedbackMapper.ToModel(respostaAtualizada);
            return new OkObjectResult(respostaModel);
        }

        [Authorize(Roles = "ADMIN")]
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (_respostaFeedbackService.Deletar(id))
            {
                return NoContent();
            }
            return NotFound();
        }
    }
}