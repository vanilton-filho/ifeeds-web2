using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using IfeedsApi.Api.Mappers;
using IfeedsApi.Api.Models;
using IfeedsApi.Core.Database;
using IfeedsApi.Domain.Models;
using IfeedsApi.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace IfeedsApi.Api.Controllers.V1
{
    [ApiController]
    [Route("/v1/api/respostas-feedbacks")]
    public class RespostaFeedbackController : ControllerBase
    {
        private readonly RespostaFeedbackService _respostaFeedbackService;
        private readonly RespostaFeedbackMapper _respostaFeedbackMapper;
        private readonly IMapper _mapper;


        public RespostaFeedbackController(RespostaFeedbackService respostaFeedbackService, RespostaFeedbackMapper respostaFeedbackMapper, IMapper mapper)
        {
            _respostaFeedbackService = respostaFeedbackService;
            _respostaFeedbackMapper = respostaFeedbackMapper;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ICollection<RespostaFeedbackModel>> Get()
        {
            var respostas = _respostaFeedbackService.Listar();

            return _respostaFeedbackMapper.ToCollection(respostas);
        }

        [HttpGet("{id}", Name = "GetRespostaId")]
        public ActionResult<RespostaFeedbackModel> GetPorId(int id)
        {
            var respostaFeedback = _respostaFeedbackService.GetPorId(id);
            if (respostaFeedback == null)
            {
                return NotFound();
            }

            var respostaFeedbackModel = _respostaFeedbackMapper.ToModel(respostaFeedback);
            return new OkObjectResult(respostaFeedbackModel);
        }

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