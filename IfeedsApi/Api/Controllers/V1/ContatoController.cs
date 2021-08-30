using System.Collections.Generic;
using System.Linq;
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
    [Route("/v1/api/contatos")]
    public class ContatoController : ControllerBase
    {
        private readonly ContatoService _contatoService;
        private readonly ContatoMapper _contatoMapper;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ContatoController(ApplicationDbContext context, IMapper mapper, ContatoMapper contatoMapper, ContatoService contatoService)
        {
            _context = context;
            _mapper = mapper;
            _contatoService = contatoService;
            _contatoMapper = contatoMapper;
        }

        [Authorize(Roles = "ADMIN")]
        [HttpGet]
        [Produces("application/json")]
        public ActionResult<ICollection<ContatoModel>> Get()
        {
            var contatos = _contatoService.Listar();
            var contatosModel = _contatoMapper.ToCollection(contatos);
            return new OkObjectResult(contatosModel);
        }

        [Authorize(Roles = "ADMIN,USER")]
        [HttpGet("{id}", Name = "ObterContatoPorId")]
        [Produces("application/json")]
        public ActionResult<ContatoModel> Get(int id)
        {
            var usuario = _context.Usuarios
                .Where(e => e.ContatoId == id)
                .FirstOrDefault();

            if (usuario != null &&
                    HttpContext.User.HasClaim("matricula", usuario.Matricula))
            {
                var contato = _context.Contatos
                    .Where(e => e.Id == id)
                    .FirstOrDefault();

                if (contato == null)
                {
                    return NotFound();
                }

                var contatoModel = _mapper.Map<ContatoModel>(contato);

                return new OkObjectResult(contatoModel);
            }

            return new UnauthorizedResult();
        }

        [Authorize(Roles = "ADMIN,USER")]
        [HttpPut("{id}")]
        public ActionResult<ContatoModel> Put(int id, [FromBody] ContatoModelRequest request)
        {
            var contato = _mapper.Map<Contato>(request);
            var contatoAtualizado = _contatoService.Atualizar(id, contato);

            if (contatoAtualizado == null)
            {
                return NotFound();
            }
            var contatoModel = _contatoMapper.ToModel(contatoAtualizado);
            return new OkObjectResult(contatoModel);
        }
    }
}