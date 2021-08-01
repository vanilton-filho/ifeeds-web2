using System.Collections.Generic;
using System.Linq;
using IfeedsApi.Api.Mappers;
using IfeedsApi.Api.Models;
using IfeedsApi.Config.Database;
using IfeedsApi.Domain.Models;
using IfeedsApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace IfeedsApi.Api.Controllers
{
    [ApiController]
    [Route("/api/avaliacoes")]
    public class AvaliacaoController : ControllerBase
    {
        private readonly AvaliacaoMapper _avaliacaoMapper;
        private readonly AvaliacaoService _avaliacaoService;

        public AvaliacaoController(AvaliacaoMapper avaliacaoMapper, AvaliacaoService avaliacaoService)
        {
            _avaliacaoMapper = avaliacaoMapper;
            _avaliacaoService = avaliacaoService;
        }

        [HttpGet]
        public ActionResult<ICollection<AvaliacaoModel>> Get()
        {
            var avaliacoes = _avaliacaoService.Listar();
            var avaliacoesModel = _avaliacaoMapper.ToCollection(avaliacoes);
            return new OkObjectResult(avaliacoesModel);
        }
    }
}