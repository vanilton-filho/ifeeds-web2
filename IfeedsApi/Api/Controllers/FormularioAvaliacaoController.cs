using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using IfeedsApi.Api.Models;
using IfeedsApi.Core.Database;
using IfeedsApi.Domain.Models;
using IfeedsApi.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace IfeedsApi.Api.Controllers
{
    [ApiController]
    [Route("/api/formularios-avaliacoes")]
    public class FormularioAvaliacaoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        private readonly FormularioService _formularioAvaliacaoService;

        public FormularioAvaliacaoController(ApplicationDbContext context, IMapper mapper, FormularioService formularioService)
        {
            _context = context;
            _formularioAvaliacaoService = formularioService;           
            _mapper  = mapper;
        }

        [HttpGet]
        public ActionResult<ICollection<FormularioAvaliacao>> Get()
        {
            return _context.FormulariosAvaliacaos.ToList();
        }

        [HttpPost]
        public ActionResult<FormularioAvaliacaoModel> Post([FromBody] FormularioAvaliacaoModelRequest formularioAvaliacaoModelRequest){
            var formularioAvaliacao = _mapper.Map<FormularioAvaliacao>(formularioAvaliacaoModelRequest);
            formularioAvaliacao.QuantidadeEstrelas = formularioAvaliacaoModelRequest.Nota;
            _formularioAvaliacaoService.Salvar(formularioAvaliacao);
            return _mapper.Map<FormularioAvaliacaoModel>(formularioAvaliacao);
        }
    }
}