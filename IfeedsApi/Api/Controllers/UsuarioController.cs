using System.Collections.Generic;
using AutoMapper;
using IfeedsApi.Api.Mappers;
using IfeedsApi.Api.Models;
using IfeedsApi.Domain.Models;
using IfeedsApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IfeedsApi.Api.Controllers
{
    [ApiController]
    [Route("/api/usuarios")]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioMapper _usuarioMapper;
        private readonly IMapper _mapper;

        private readonly UsuarioService _usuarioService;

        public UsuarioController(IMapper mapper, UsuarioMapper usuarioMapper, UsuarioService usuarioService)
        {
            _usuarioMapper = usuarioMapper;
            _usuarioService = usuarioService;
            _mapper = mapper;
        }


        /// <summary>Realiza o login do usuário</summary>
        [AllowAnonymous]
        [HttpPost("login")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public ActionResult<dynamic> Login([FromBody] LoginModelRequest req)
        {
            var usuario = _usuarioService.AutenticarUsuario(req.Matricula, req.Senha);
            if (usuario == null)
            {
                return NotFound();
            }

            var token = TokenService.GenerateToken(_usuarioMapper.ToModel(usuario));
            return new
            {
                usuario = _usuarioMapper.ToModel(usuario),
                token = token
            };

        }

        /// <summary>Lista todos os usuários</summary>
        /// <response code="401">Unauthorized</response>
        [Authorize(Roles = "ADMIN")]
        [HttpGet]
        [Produces("application/json")]
        public ActionResult<ICollection<UsuarioModel>> Get()
        {
            var usuarios = _usuarioService.Listar();
            var usuariosModel = _usuarioMapper.ToCollection(usuarios);

            return new OkObjectResult(usuariosModel);
        }

        /// <summary>Busca um usuário por matrícula</summary>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">NotFound</response>
        [Authorize(Roles = "ADMIN,USER")]
        [HttpGet("{matricula}", Name = "ObterUsuarioPorMatricula")]
        [Produces("application/json")]
        public ActionResult<UsuarioModel> Get(string matricula)
        {
            if (HttpContext.User.HasClaim("matricula", matricula))
            {
                var usuario = _usuarioService.FindByMatricula(matricula);

                if (usuario == null)
                {
                    return NotFound();
                }

                var usuarioModel = _usuarioMapper.ToModel(usuario);

                return new OkObjectResult(usuarioModel);
            }

            return new UnauthorizedResult();
        }

        /// <summary>Cria um novo usuário</summary>
        /// <response code="201">Created</response>
        /// <response code="400">BadRequest</response>
        /// <response code="401">Unauthorized</response>
        [AllowAnonymous]
        [HttpPost]
        [Produces("application/json")]
        [Consumes("application/json")]
        public ActionResult Post([FromBody] UsuarioModelRequest req)
        {
            // Vou extrair da requisição recebida meu usuário e contato
            var usuario = _mapper.Map<Usuario>(req);
            var contato = _mapper.Map<Contato>(req);
            usuario = _usuarioService.SaveUsuario(usuario, contato);
            var usuarioModel = _usuarioMapper.ToModel(usuario);
            // Aqui nos vamos retornar um usuário criado e retornaremos o DTO e no header o seu Location
            return new CreatedAtRouteResult("ObterUsuarioPorMatricula", new { matricula = usuario.Matricula }, usuarioModel);
        }

        /// <summary>Atualiza os dados de um usuário</summary>
        /// <response code="400">BadRequest</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">NotFound</response>
        [Authorize(Roles = "ADMIN,USER")]
        [HttpPut("{matricula}")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public ActionResult<UsuarioModel> Put(string matricula, [FromBody] UsuarioUpdateModelRequest req)
        {
            if (HttpContext.User.HasClaim("matricula", matricula))
            {
                if (matricula != req.Matricula)
                {
                    return BadRequest();
                }


                var usuario = _usuarioService.FindByMatricula(req.Matricula);

                if (usuario == null)
                {
                    return NotFound();
                }

                // Copiando o que tem na requisição recebida para o usuário encontrado
                usuario = _mapper.Map<UsuarioUpdateModelRequest, Usuario>(req, usuario);
                _usuarioService.UpdateUsuario(usuario);
                var usuarioModel = _usuarioMapper.ToModel(usuario);
                return new OkObjectResult(usuarioModel);
            }

            return new UnauthorizedResult();
        }

    }
}
