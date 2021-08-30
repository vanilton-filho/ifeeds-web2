using System.Collections.Generic;
using AutoMapper;
using IfeedsApi.Api.Mappers;
using IfeedsApi.Api.Models;
using IfeedsApi.Domain.Exceptions;
using IfeedsApi.Domain.Models;
using IfeedsApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IfeedsApi.Api.Controllers.V1
{
    [ApiController]
    [Route("/v1/api/avaliacoes")]
    public class AvaliacaoController : ControllerBase
    {
        private readonly AvaliacaoMapper _avaliacaoMapper;
        private readonly AvaliacaoService _avaliacaoService;
        private readonly IMapper _mapper;


        public AvaliacaoController(AvaliacaoMapper avaliacaoMapper, AvaliacaoService avaliacaoService, IMapper mapper)
        {
            _avaliacaoMapper = avaliacaoMapper;
            _avaliacaoService = avaliacaoService;
            _mapper = mapper;

        }

        [Authorize(Roles = "ADMIN,USER")]
        [HttpGet]
        public ActionResult<ICollection<AvaliacaoModel>> Get()
        {
            var avaliacoes = _avaliacaoService.Listar();
            var avaliacoesModel = _avaliacaoMapper.ToCollection(avaliacoes);
            return new OkObjectResult(avaliacoesModel);
        }

        [Authorize(Roles = "ADMIN,USER")]
        [HttpGet("{id}/por-categoria")]
        public ActionResult<ICollection<AvaliacaoModel>> ListarPorCategoria(int id)
        {
            var avaliacoes = _avaliacaoService.ListarPorCategoria(id);
            var avaliacoesModel = _avaliacaoMapper.ToCollection(avaliacoes);
            return new OkObjectResult(avaliacoesModel);
        }

        [Authorize(Roles = "ADMIN,USER")]
        [HttpGet("{id}", Name = "GetCodigo")]
        public ActionResult<AvaliacaoModel> Get(int id)
        {
            var avaliacao = _avaliacaoService.BuscarPorId(id);
            if (avaliacao == null)
            {
                return NotFound();
            }
            var avaliacaoModel = _avaliacaoMapper.ToModel(avaliacao);
            return new OkObjectResult(avaliacaoModel);
        }

        [Authorize(Roles = "ADMIN")]
        [HttpPost]
        public ActionResult Post([FromBody] AvaliacaoModelRequest request)
        {
            var avaliacao = _mapper.Map<Avaliacao>(request);
            var avaliacaoSalva = _avaliacaoService.Salvar(avaliacao);
            var avaliacaoModel = _avaliacaoMapper.ToModel(avaliacaoSalva);
            return new CreatedAtRouteResult("GetCodigo", new { avaliacaoSalva.Id }, avaliacaoModel);
        }

        [Authorize(Roles = "ADMIN")]
        [HttpPut("{id}")]
        public ActionResult<AvaliacaoModel> Put(int id, [FromBody] AvaliacaoModelRequest request)
        {
            var avaliacao = _mapper.Map<Avaliacao>(request);
            var avaliacaoAtualizada = _avaliacaoService.Atualizar(id, avaliacao);

            if (avaliacaoAtualizada == null)
            {
                return NotFound();
            }
            var avaliacaoModel = _avaliacaoMapper.ToModel(avaliacaoAtualizada);
            return new OkObjectResult(avaliacaoModel);
        }

        [Authorize(Roles = "ADMIN")]
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                if (_avaliacaoService.Deletar(id))
                {
                    return NoContent();
                }
            }
            catch (EntidadeEmUsoException e)
            {
                throw e;
            }
            return NotFound();
        }
    }
}