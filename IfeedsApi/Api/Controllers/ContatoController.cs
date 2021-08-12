using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using IfeedsApi.Api.Models;
using IfeedsApi.Core.Database;
using IfeedsApi.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IfeedsApi.Api.Controllers
{
    [ApiController]
    [Route("/api/contatos")]
    public class ContatoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ContatoController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [Authorize(Roles = "ADMIN")]
        [HttpGet]
        [Produces("application/json")]
        public ActionResult<ICollection<Contato>> Get()
        {
            return _context.Contatos.ToList();
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
    }
}