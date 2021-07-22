using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using AutoMapper;
using IfeedsApi.Api.Models;
using IfeedsApi.Config.Database;
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
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public UsuarioController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        /// <summary>Realiza o login do usuário</summary>
        [AllowAnonymous]
        [HttpPost("login")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public ActionResult<dynamic> Login([FromBody] LoginModelRequest req)
        {
            var usuario = AutenticarUsuario(req.Matricula, req.Senha);
            if (usuario == null)
            {
                return NotFound();
            }

            var token = TokenService.GenerateToken(ToUsuarioModel(usuario));
            return new
            {
                usuario = ToUsuarioModel(usuario),
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
            var usuarios = _context.Usuarios.ToList();
            var usuariosModel = _mapper.Map<List<UsuarioModel>>(usuarios);

            usuarios.ForEach(u =>
            {
                var contato = _context.Contatos.Find(u.ContatoId);
                var role = _context.Roles.Find(u.RoleId);

                var usuarioModel = usuariosModel.Where(e => e.Matricula == u.Matricula);
                usuarioModel.Single().Contato = _mapper.Map<ContatoModel>(contato);
                usuarioModel.Single().Role = role.Tipo;
            });

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
            if (HttpContext.User.HasClaim(ClaimTypes.Actor, matricula))
            {

                var usuario = FindByMatricula(matricula);

                if (usuario == null)
                {
                    return NotFound();
                }

                var usuarioModel = ToUsuarioModel(usuario);


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
            var usuario = SaveUsuario(request: req);
            var usuarioModel = ToUsuarioModel(usuario: usuario);
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
            if (HttpContext.User.HasClaim(ClaimTypes.Actor, matricula))
            {
                if (matricula != req.Matricula)
                {
                    return BadRequest();
                }

                var usuario = _context.Usuarios
                    .Where(e => e.Matricula == req.Matricula)
                    .FirstOrDefault();

                _mapper.Map<UsuarioUpdateModelRequest, Usuario>(req, usuario);
                _context.Update(usuario);
                _context.SaveChanges();
                var usuarioModel = ToUsuarioModel(usuario);
                return new OkObjectResult(usuarioModel);
            }

            return new UnauthorizedResult();
        }

        private UsuarioModel ToUsuarioModel(Usuario usuario)
        {
            var usuarioModel = _mapper.Map<UsuarioModel>(usuario);

            var contato = _context.Contatos.Find(usuario.ContatoId);
            var role = _context.Roles.Find(usuario.RoleId);

            // Anexando contato e role ao model
            usuarioModel.Contato = _mapper.Map<ContatoModel>(contato);
            usuarioModel.Role = role.Tipo;

            return usuarioModel;
        }

        private Usuario SaveUsuario(UsuarioModelRequest request)
        {
            var usuario = _mapper.Map<Usuario>(request);
            var contato = _mapper.Map<Contato>(request);

            // É importante considerarmos que pode haver um erro
            // no meio do caminho, então vamos garantir o rollback de
            // tudo o que ocorrer até o commit
            using var transaction = _context.Database.BeginTransaction(); // início da transação

            _context.Add(contato);
            _context.SaveChanges();

            // Atribuindo IDs das entidades Contato e Role
            usuario.ContatoId = contato.Id;
            // TODO: Definir lógica para o tipo de usuário
            usuario.RoleId = 2;

            usuario.Senha = BCrypt.Net.BCrypt.HashPassword(request.Senha);
            _context.Add(usuario);
            _context.SaveChanges();

            transaction.Commit(); // fim da transação
            return usuario;
        }

        private Usuario FindByMatricula(string matricula)
        {
            var usuario = _context.Usuarios
                .Where(e => e.Matricula == matricula)
                .FirstOrDefault();

            return usuario;
        }

        private Usuario AutenticarUsuario(string matricula, string senha)
        {
            var usuario = _context.Usuarios
                .Where(e => e.Matricula == matricula)
                .FirstOrDefault();

            return (usuario != null) && CheckSenha(senha, usuario) ? usuario : null;
        }

        private bool CheckSenha(string senhaReq, Usuario usuario)
        {
            return BCrypt.Net.BCrypt.Verify(senhaReq, usuario.Senha) ? true : false;
        }

    }
}
