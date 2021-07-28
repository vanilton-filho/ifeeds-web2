using System.Collections.Generic;
using AutoMapper;
using IfeedsApi.Api.Models;
using IfeedsApi.Config.Database;
using IfeedsApi.Domain.Models;
using System.Linq;

namespace IfeedsApi.Api.Mappers
{
    public class UsuarioMapper
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public UsuarioMapper(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public UsuarioModel ToModel(Usuario usuario)
        {
            var usuarioModel = _mapper.Map<UsuarioModel>(usuario);

            var contato = _context.Contatos.Find(usuario.ContatoId);
            var role = _context.Roles.Find(usuario.RoleId);
            var campus = _context.Campus.Find(usuario.CampusId);
            // Anexando contato e role ao model
            usuarioModel.Campus = campus.Nome;
            usuarioModel.Contato = _mapper.Map<ContatoModel>(contato);
            usuarioModel.Role = role.Tipo;

            return usuarioModel;
        }

        public List<UsuarioModel> ToCollection(List<Usuario> usuarios)
        {
            var usuariosModel = _mapper.Map<List<UsuarioModel>>(usuarios);
            usuarios.ForEach(u =>
            {
                var contato = _context.Contatos.Find(u.ContatoId);
                var role = _context.Roles.Find(u.RoleId);

                var usuarioModel = usuariosModel.Where(e => e.Matricula == u.Matricula);
                usuarioModel.Single().Contato = _mapper.Map<ContatoModel>(contato);
                usuarioModel.Single().Role = role.Tipo;
            });
            return usuariosModel;
        }
    }
}