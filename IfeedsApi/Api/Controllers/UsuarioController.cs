using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using IfeedsApi.Api.Models;
using IfeedsApi.Config.Database;
using IfeedsApi.Domain.Models;
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

        /// <summary>Lista todos os usuários</summary>
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
        /// <response code="404">NotFound</response>
        [HttpGet("{matricula}", Name = "ObterUsuarioPorMatricula")]
        [Produces("application/json")]
        public ActionResult<UsuarioModel> Get(string matricula)
        {
            var usuario = _context.Usuarios
                .Where(e => e.Matricula == matricula)
                .FirstOrDefault();

            if (usuario == null)
            {
                return NotFound();
            }

            var usuarioModel = ToUsuarioModel(usuario);


            return new OkObjectResult(usuarioModel);
        }

        /// <summary>Cria um novo usuário</summary>
        /// <response code="201">Created</response>
        /// <response code="400">BadRequest</response>
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
        /// <response code="404">NotFound</response>
        [HttpPut("{matricula}")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public ActionResult<UsuarioModel> Put(string matricula, [FromBody] UsuarioModelRequest req)
        {
            if (matricula != req.Matricula)
            {
                return BadRequest();
            }

            // TODO: Desenvolver lógica para update
            // var usuario = UpdateUsuario(request: req);
            // var usuarioModel = ToUsuarioModel(usuario: usuario);
            return Ok();
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

            usuario.Senha = request.Senha;
            _context.Add(usuario);
            _context.SaveChanges();

            transaction.Commit(); // fim da transação
            return usuario;
        }

        private Usuario UpdateUsuario(UsuarioModelRequest request)
        {
            return null;
        }

    }
}
